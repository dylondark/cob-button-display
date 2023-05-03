using CefSharp;
using CefSharp.DevTools.DOM;
using CefSharp.DevTools.Runtime;
using CefSharp.Handler;
using CefSharp.WinForms;
using Display_test;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Display_test
{
    public enum CurrentPage {  HomePage, FirstLevelWebpage, SecondLevelButtonsPage }
    public partial class Form1 : Form
    {

        
        Form2 secondLevelButtonsWindow;
        private CurrentPage currentPage;

        private int inactivityCheckDuration = 60000;//milliseconds
        // keep the same inactivity window, reshowing it when needed.
        // This way when normal activity is detected after its shown, they dont need to still click Yes we can force it.
        private InActivityWindow inActivityWindow; 
        private const int WM_TOUCH = 0x246;
        private const int WM_TOUCHUPDATE = 0x245;
        private bool debugEnabled = false;

        private Timer timerRef;
        private string statsFile;
        private object statsLock = new object();

        private List<string> urlHistory = new List<string>();

        // runs on startup
        public Form1()
        {
            currentPage = CurrentPage.HomePage;
            timerRef = new Timer();
            timerRef.Interval = inactivityCheckDuration;
            timerRef.Tick += new EventHandler(onTimerTick);
            inActivityWindow = new InActivityWindow(closeWebpageAuto, timerRef, DebugIfAble);

            setupStats();

            InitializeComponent();
            chromium.Hide();
            backButton.Hide();
            lblDebug.Hide();

            lblDebug.Text = "";

            FormBorderStyle = FormBorderStyle.None;
            
            this.WindowState = FormWindowState.Maximized;

            // init lifespanhandler for redirection of new tab requests back to the original browser
            chromium.LifeSpanHandler = new ChromiumLifeSpanHandler();
        }

        // automatically scale certain ui elements like text and margin size based on screen resolution
        private void autoScale(object sender, EventArgs e)
        {
            const int scaleFactor = 60; // based on the desired font size for the welcome text on a 4k display, everything else will scale accordingly with this
            float resFactor = Convert.ToSingle(this.Width) / 3840f; // this will be 1 at 4k

            Font labelFont = new Font(new FontFamily("Calibri"), scaleFactor * resFactor, FontStyle.Bold); ;
            lblWelcome.Font = labelFont;
            pictureBox1.Margin = new Padding(Convert.ToInt32(Math.Ceiling(scaleFactor * resFactor)));

            Padding buttonMargin = new Padding(Convert.ToInt32(Math.Ceiling(scaleFactor * 0.2f * resFactor)));
            btnCentersInstitutes.Margin = buttonMargin;
            btnDirectory.Margin = buttonMargin;
            btnExecEd.Margin = buttonMargin;
            btnGrad.Margin = buttonMargin;
            btnProfDev.Margin = buttonMargin;
            btnUndergrad.Margin = buttonMargin;

            // back buttons scaling
            int buttonDim = Convert.ToInt32(scaleFactor * 4f * resFactor);
            backButton.Width = buttonDim;
            backButton.Height = buttonDim;

            // back button positions
            int[] buttonPos = new int[] {this.Width - 20 - buttonDim, this.Height - 20 - buttonDim};
            backButton.Left = buttonPos[0];
            backButton.Top = buttonPos[1];

            
        }

        #region "stats"

        // each code describes an action that will be recorded and stored in the stats csv file
        public enum statCodes
        {
            PageClose,
            Directory, Undergraduate, Graduate, CentersInstitutes, ProfDev, ExecEd, // form1 buttons
            DebugOn, DebugOff, 
            Staff, Faculty, Search, // form2 buttons
            Form1UrlChange, Form2UrlChange,
            Back,
            ProgramStart
        }

        // creates the stats file 'data.csv' in home user documents folder and sets up proper formatting
        private void setupStats()
        {
            string targetDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Documents", "displaytest_output");
            Directory.CreateDirectory(targetDir);
            statsFile = Path.Combine(targetDir, "data.csv");
            lock (statsLock)
            {
                if (File.Exists(statsFile))
                {
                    if (new FileInfo(statsFile).Length > 1000000000L)
                    {
                        statsFile = null;
                        return;
                    }
                }
                else
                {
                    try
                    {
                        File.WriteAllText(statsFile, "UTC Timestamp,Action Code,Details" + Environment.NewLine);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("[" + DateTime.Now + "] File access error: Unable to begin formatting of stats file. Exception: " + e.Message);
                    }
                    
                }
                try
                {
                    File.AppendAllText(statsFile, string.Format("{0},{1}{2}", DateTimeOffset.UtcNow.ToString("s"), statCodes.ProgramStart.ToString(), Environment.NewLine));
                }
                catch (Exception e)
                {
                    Console.WriteLine("[" + DateTime.Now + "] File access error: Unable to write line to stats file. Exception: " + e.Message);
                }
            }
        }

        // writes stat to stats file
        public void writeStat(statCodes code)
        {
            Task.Run(() =>
            {
                lock (statsLock)
                { 
                    try
                    {
                        File.AppendAllText(statsFile, string.Format("{0},{1}{2}", DateTimeOffset.UtcNow.ToString("s"), code.ToString(), Environment.NewLine));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("[" + DateTime.Now + "] File access error: Unable to write line to stats file. Exception: " + e.Message);
                    }
                }
            });
        }

        // writes stat to stats file (with description message)
        public void writeStat(statCodes code, string str)
        {
            Task.Run(() =>
            {
                lock (statsLock)
                {
                    try
                    {
                        File.AppendAllText(statsFile, string.Format("{0},{1},{2}{3}", DateTimeOffset.UtcNow.ToString("s"), code.ToString(), str, Environment.NewLine));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("[" + DateTime.Now + "] File access error: Unable to write line to stats file. Exception: " + e.Message);
                    }
                }
            });
        }

        #endregion

        #region "debug"

        // stores debug messages that show up in the debug label
        private List<string> Debugs = new List<string>();

        // Tap the logo 5 times quickly (within 3 secs) to toggle debugging.
        int clicks = 0;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (clicks == 0)
                Task.Run(async () => {
                    await Task.Delay(3000);
                    if (clicks < 5) clicks = 0;
                });
            clicks++;
            if (clicks >= 5)
            {
                clicks = 0;
                if (debugEnabled) DebugDisable();
                else DebugEnable();
            }
        }

        // update debug label with new debug messages and show
        private async Task DebugIfAble(string msg)
        {
            if (!debugEnabled) return;
            Debug.WriteLine(msg);
            Debugs.Add(msg);
            Invoke(new Action(() =>
            {
                lblDebug.Text = string.Join(Environment.NewLine, Debugs.Distinct());
                lblDebug.BringToFront();
                lblDebug.Show();
            }));
            await Task.Delay(6000);
            Debugs.Remove(msg);
            Invoke(new Action(() =>
            {
                if (Debugs.Count == 0)
                {
                    lblDebug.Hide();
                    lblDebug.Text = "";
                }
                else
                {
                    lblDebug.Text = string.Join(Environment.NewLine, Debugs.Distinct());
                }
            }));
        }

        // enables debug system after clicking cob logo 5 times
        private async Task DebugEnable()
        {
            writeStat(statCodes.DebugOn);
#if DEBUG
            Debug.WriteLine("WinForm Debug Enabled");
            debugEnabled = true;
            lblDebug.BackColor = Color.LightSeaGreen;
            await DebugIfAble("EN");
            lblDebug.BackColor = Color.PaleGoldenrod;
#endif
        }

        // disables debug system after clicking cob logo 5 times again
        private async Task DebugDisable()
        {
            writeStat(statCodes.DebugOff);
            debugEnabled = false;
            Debugs.Clear();
            Debug.WriteLine("WinForm Debug Disabled");
            lblDebug.BackColor = Color.LightCoral;
            lblDebug.Text = "OFF";
            lblDebug.BringToFront();
            lblDebug.Show();
            await Task.Delay(6000);
            lblDebug.Hide();
            lblDebug.Text = "";
            lblDebug.BackColor = Color.PaleGoldenrod;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 't')
                DebugIfAble("TM " + timerRef.Enabled + timerRef.ToString());
        }

        #endregion

        #region "button clicks"

        private void Directory_Click(object sender, EventArgs e)
        {
            writeStat(statCodes.Directory);
            currentPage = CurrentPage.SecondLevelButtonsPage;
            secondLevelButtonsWindow = new Form2(this);
            this.Controls.Remove(lblDebug);
            secondLevelButtonsWindow.Controls.Add(lblDebug);
            secondLevelButtonsWindow.Show();
            secondLevelButtonsWindow.FormClosed += new FormClosedEventHandler(onSecondLevelFormClosed);
            inActivityWindow.startTimer();
        }

        private void Undergrad_Click(object sender, EventArgs e)
        {
            writeStat(statCodes.Undergraduate);
            showWebPage("https://uakron.edu/cba/undergraduate/majors/");
        }

        private void Grad_Click(object sender, EventArgs e)
        {
            writeStat(statCodes.Graduate);
            showWebPage("https://www.uakron.edu/cba/graduate/");
        }

        private void CentersInstitutes_Click(object sender, EventArgs e)
        {
            writeStat(statCodes.CentersInstitutes);
            showWebPage("https://www.uakron.edu/cba/centers-and-institutes/");
            this.ControlBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void ProfDev_Click(object sender, EventArgs e)
        {
            writeStat(statCodes.ProfDev);
            showWebPage("https://www.uakron.edu/cba/outcomes/");
        }

        private void ExecEd_Click(object sender, EventArgs e)
        {
            writeStat(statCodes.ExecEd);
            showWebPage("https://www.uakron.edu/cba/executive/");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            int historyMax = urlHistory.Count - 1;
            string backUrl;
            if (historyMax > 0)
            {
                // go back to last url and remove most current url from list
                backUrl = urlHistory[historyMax - 1];
                chromium.LoadUrl(backUrl);
                urlHistory.RemoveRange(historyMax - 1, 2); // remove current url and url that was just navigated to
            }
            else
            {
                closeWebpage();
            }
            
        }

        #endregion

        #region "activity"

        // go back to main page after inactivity timer
        void onTimerTick(object sender, EventArgs args)
        {
            navigateBackAfterInactivity();
        }

        void navigateBackAfterInactivity()
        {
            inActivityWindow.stopTimer();
            DialogResult result = DialogResult.None;
            if (currentPage == CurrentPage.FirstLevelWebpage)
            {
                inActivityWindow = new InActivityWindow(closeWebpageAuto, timerRef, DebugIfAble);
                result = inActivityWindow.ShowDialog(this);
            }
            else if (currentPage == CurrentPage.SecondLevelButtonsPage && secondLevelButtonsWindow != null)
            {
                inActivityWindow = new InActivityWindow(secondLevelBack, timerRef, DebugIfAble);
                result = inActivityWindow.ShowDialog(secondLevelButtonsWindow);
            }

            if (result == DialogResult.Yes)
            {
                inActivityWindow.startTimer();
            }
        }

        // when activity event is noticed
        private void activity_event(object sender, EventArgs e)
        {
            inActivityWindow.activityDetected("EVNT");
        }
        // js script to detect activity in browser
        private const string script = @"if(typeof WINFORMS_SCR_LOADED === 'undefined') { document.addEventListener(""click"", function(e) { console.log(""WINFORMS CLICK ACTIVITY""); }); document.addEventListener(""scroll"", function(e) { console.log(""WINFORMS SCROLL ACTIVITY""); }); WINFORMS_SCR_LOADED = true; }";

        // inject said script into page
        public void webBrowser2_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading)
            {
                e.Browser.ExecuteScriptAsync(script);
            }
        }

        // detects activity from console output from js script
        public void webBrowser2_ConsoleMessage(object sender, ConsoleMessageEventArgs e)
        {
            if (e.Message.Equals("WINFORMS CLICK ACTIVITY"))
            {
                Invoke(new Action(() =>
                {
                    inActivityWindow.activityDetected("JS CLK");
                }));
            }
            else if (e.Message.Equals("WINFORMS SCROLL ACTIVITY"))
            {
                Invoke(new Action(() =>
                {
                    inActivityWindow.activityDetected("JS SCR");
                }));
            }
        }

        // detect scroll action on form
        private void activity_event(object sender, ScrollEventArgs e)
        {
            inActivityWindow.activityDetected("EVNT SCR");
        }

        // detect mouse click/movement on form
        private void activity_event(object sender, MouseEventArgs e)
        {
            inActivityWindow.activityDetected("EVNT MOU");
        }

        // detect change of web browser url
        private void activity_event(object sender, AddressChangedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                writeStat(statCodes.Form1UrlChange, e.Address);
                urlHistory.Add(e.Address);
                inActivityWindow.activityDetected("URL CHNG");
            }));
        }

        // when activity is detected on form2
        public void form2Activity()
        {
            Invoke(new Action(() =>
            {
                inActivityWindow.activityDetected("FORM2");
            }));
        }

        #endregion

        // when directory menu is closed
        void onSecondLevelFormClosed(object obj, EventArgs args)
        {
            writeStat(statCodes.PageClose, "lvl2-ev");
            secondLevelButtonsWindow.Controls.Remove(lblDebug);
            this.Controls.Add(lblDebug);
            inActivityWindow.stopTimer();
        }

        // changes form1 web browser url and shows the browser
        void showWebPage(String url)
        {
            currentPage = CurrentPage.FirstLevelWebpage;
            backButton.Show();
            backButton.BringToFront();
            backButton.BringToFront();
            chromium.Load(url);

            chromium.Show();
            tableLayoutPanel1.Hide();
            picCOB.Hide();

            inActivityWindow.startTimer();
        }

        // show main menu after user hits back button
        void closeWebpage(bool auto = false)
        {
            writeStat(statCodes.PageClose, auto ? "auto" : "back"); // write whether this was done by timer or by user
            chromium.Hide();
            backButton.Hide();
            tableLayoutPanel1.Show();
            picCOB.Show();
            currentPage = CurrentPage.HomePage;
            urlHistory.Clear();
        }

        // called when inactivity timer has reached limit
        void closeWebpageAuto()
        {
            closeWebpage(true);
        }

        // called when going back from directoy menu
        void secondLevelBack()
        {
            writeStat(statCodes.PageClose, "lvl2-auto");
            secondLevelButtonsWindow.Close();
            inActivityWindow.stopTimer();
        }

        // ensure proper resizing of buttons 
        private void gridbuttonResize(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int colW = b.Size.Width + b.Margin.Horizontal;
            int imgWidthScaled = b.Size.Height * b.BackgroundImage.Width / b.BackgroundImage.Height;
            var marg = b.Margin;
            int hMarg = colW - imgWidthScaled;
            marg.Left = hMarg / 2;
            marg.Right = hMarg / 2;
            b.Margin = marg;
        }

        
    }
}