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
        private string backAddr = "";
        private string firstAddr = "";

        private Timer timerRef;
        private string statsFile;
        private object statsLock = new object();

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
            lblDebug.Hide();
            btnHome.SendToBack();
            btnBack.SendToBack();
            lblDebug.Text = "";

            FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;
        }

        // automatically scale certain ui elements like text and margin size based on screen resolution
        private void autoScale(object sender, EventArgs e)
        {
            const int scaleFactor = 60; // based on the desired font size for the welcome text on a 4k display, everything else will scale accordingly with this
            float resFactor = Convert.ToSingle(this.Width) / 3840f; // this will be 1 at 4k

            Font labelFont = new Font(new FontFamily("Calibri"), scaleFactor * resFactor, FontStyle.Bold); ;
            lblWelcome.Font = labelFont;

            Padding buttonMargin = new Padding(Convert.ToInt32(Math.Ceiling(scaleFactor * 0.2f * resFactor)));
            btnCentersInstitutes.Margin = buttonMargin;
            btnDirectory.Margin = buttonMargin;
            btnExecEd.Margin = buttonMargin;
            btnGrad.Margin = buttonMargin;
            btnProfDev.Margin = buttonMargin;
            btnUndergrad.Margin = buttonMargin;

            // back buttons scaling
            int buttonDim = Convert.ToInt32(scaleFactor * 4f * resFactor);
            btnBack.Width = buttonDim;
            btnBack.Height = buttonDim;
            btnHome.Width = buttonDim;
            btnHome.Height = buttonDim;

            // back button positions
            int[] buttonPos = new int[] {this.Width - 20 - buttonDim, this.Height - 20 - buttonDim};
            btnBack.Left = buttonPos[0];
            btnBack.Top = buttonPos[1];
            btnHome.Left = buttonPos[0] - buttonDim;
            btnHome.Top = buttonPos[1];

            // directory back button
            btnDirectoryBack.Width = Convert.ToInt32(scaleFactor * 8f * resFactor);
            btnDirectoryBack.Height = Convert.ToInt32(scaleFactor * 4f * resFactor);
            btnDirectoryBack.Left = this.Width - 20 - btnDirectoryBack.Width;
            btnDirectoryBack.Top = this.Height - 20 - btnDirectoryBack.Height;
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
                        File.WriteAllText(statsFile, "Timestamp,Action Code,Details" + Environment.NewLine);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("[" + DateTime.Now + "] File access error: Unable to begin formatting of stats file. Exception: " + e.Message);
                    }
                    
                }
                try
                {
                    File.AppendAllText(statsFile, string.Format("{0},{1}{2}", DateTime.Now.ToString("s"), statCodes.ProgramStart.ToString(), Environment.NewLine));
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
                        File.AppendAllText(statsFile, string.Format("{0},{1}{2}", DateTime.Now.ToString("s"), code.ToString(), Environment.NewLine));
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
                        File.AppendAllText(statsFile, string.Format("{0},{1},{2}{3}", DateTime.Now.ToString("s"), code.ToString(), str, Environment.NewLine));
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
            tlpDirectory.BringToFront();
            btnDirectoryBack.BringToFront();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            closeWebpage();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (chromium.CanGoBack)
            {
                /*
                 * check if we are on the first page and go back anyway.
                 * fixes an irritating issue where when on the first page from the main menu chromium will report it can go back 
                 * but nothing happens when you try to actually go back, preventing the user from going back to the main 
                 * menu even though the back button is not grayed out.
                 */
                if (chromium.Address == firstAddr)
                    closeWebpage();
                else
                {
                    // save current url
                    backAddr = chromium.Address;
                    chromium.Back();
                }
            }
            else
            {
                /*
                 * for some unknown reason, chromium will report that it cannot go back while it is still in the process of loading a page.
                 * if we always close webpage when chromium reports it cannot go back, we may encounter a situation where the user clicks 
                 * back and it closes the page on them when it shouldnt because it is still loading.
                 * the safest option here is to just not do anything when the user clicks back and the browser is still loading.
                 */
                if (!chromium.IsLoading)
                    closeWebpage();
            }
        }

        private void btnDirectoryBack_Click(object sender, EventArgs e)
        {
            tlpDirectory.SendToBack();
            btnDirectoryBack.SendToBack();
            writeStat(statCodes.Back, "lvl2-back");
            currentPage = CurrentPage.HomePage;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            writeStat(statCodes.Staff);
            showWebPage("https://www.uakron.edu/cba/about-us/staff.dot");
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            writeStat(statCodes.Faculty);
            showWebPage("https://www.uakron.edu/cba/faculty/");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            writeStat(statCodes.Search);
            showWebPage("https://www.uakron.edu/search/search.dot?searchText=&collection=l2");
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

        // inject script into page and handle back logic
        public void webBrowser2_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading)
            {
                e.Browser.ExecuteScriptAsync(script);
            }

            if (e.IsLoading && !chromium.CanGoBack)
            {
                btnBack.BackgroundImage = Properties.Resources.backbutton_grayed;
            }
            else
            {
                btnBack.BackgroundImage = Properties.Resources.backbutton;
            }

            // ensure that a back button click never results in the browser going back to the same page (even when this is the website's fault and would happen in a normal browser)
            // this will repeatedly call the back method until the browser's address has actually changed
            if (backAddr != "" && !e.IsLoading)
            {
                if (chromium.Address == backAddr)
                    Invoke(new Action(() => btnBack_Click(null, null))); // this method apparently gets called from a non ui thread so we must invoke the ui thread to do it
                else
                    backAddr = "";
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
            initBrowser();  
            if (currentPage == CurrentPage.HomePage)
                currentPage = CurrentPage.FirstLevelWebpage;
            chromium.Load(url);
            firstAddr = url;
            chromium.BringToFront();
            btnBack.BringToFront();
            btnHome.BringToFront();
            tlpMain.SendToBack();

            inActivityWindow.startTimer();
        }

        // show main menu after user hits back button
        void closeWebpage(bool auto = false)
        {
            writeStat(statCodes.PageClose, auto ? "auto" : "back");
            btnHome.SendToBack();
            btnBack.SendToBack();
            if (currentPage == CurrentPage.SecondLevelButtonsPage)
            {
                tlpDirectory.BringToFront();
                btnDirectoryBack.BringToFront();
            }
            else
                tlpMain.BringToFront();

            // destroy chromium browser
            Controls.Remove(chromium);
            if (chromium != null) // potential fix for object reference not set to an instance of an object error
            {
                chromium.Dispose();
                chromium = null;
            }

            backAddr = "";
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