﻿using CefSharp;
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

        public Form1()
        {
            currentPage = CurrentPage.HomePage;
            timerRef = new Timer();
            timerRef.Interval = inactivityCheckDuration;
            timerRef.Tick += new EventHandler(onTimerTick);
            inActivityWindow = new InActivityWindow(closeWebpageAuto, timerRef, DebugIfAble);

            setupStats();

            createBackButton();
            InitializeComponent();
            webBrowser.Hide();
            backButton.Hide();
            lblDebug.Hide();

            lblDebug.Text = "";

            FormBorderStyle = FormBorderStyle.None;
            
            this.WindowState = FormWindowState.Maximized;

            // init lifespanhandler for redirection of new tab requests back to the original browser
            webBrowser.LifeSpanHandler = new ChromiumLifeSpanHandler();
        }

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

        private List<string> Debugs = new List<string>();

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
        
       void  onSecondLevelFormClosed(object obj, EventArgs args)
        {
            writeStat(0, "lvl2-ev");
            secondLevelButtonsWindow.Controls.Remove(lblDebug);
            this.Controls.Add(lblDebug);
            inActivityWindow.stopTimer();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            closeWebpage();
        }

        void showWebPage(String url)
        {
            currentPage = CurrentPage.FirstLevelWebpage;
            backButton.Show();
            backButton.BringToFront();
            backButton.BringToFront();
            webBrowser.Load(url);

            webBrowser.Show();
            tableLayoutPanel1.Hide();
            picCOB.Hide();

            inActivityWindow.startTimer();
        }

        void closeWebpage(bool auto = false)
        {
            writeStat(0, auto ? "auto" : "back");
            webBrowser.Hide();
            backButton.Hide();
            tableLayoutPanel1.Show();
            picCOB.Show();
            currentPage = CurrentPage.HomePage;
        }

        void closeWebpageAuto()
        {
            closeWebpage(true);
        }

        void secondLevelBack()
        {
            writeStat(0, "lvl2-auto");
            secondLevelButtonsWindow.Close();
            inActivityWindow.stopTimer();
        }

        void onTimerTick(object sender, EventArgs args)
        {
            navigateBackAfterInacitivity();
        }

        void navigateBackAfterInacitivity()
        {
            inActivityWindow.stopTimer();
            DialogResult result = DialogResult.None;
            if (currentPage == CurrentPage.FirstLevelWebpage)
            {
                inActivityWindow = new InActivityWindow(closeWebpageAuto, timerRef, DebugIfAble);
                result = inActivityWindow.ShowDialog(this);
            } else if(currentPage == CurrentPage.SecondLevelButtonsPage && secondLevelButtonsWindow != null)
            {
                inActivityWindow = new InActivityWindow(secondLevelBack, timerRef, DebugIfAble);
                result = inActivityWindow.ShowDialog(secondLevelButtonsWindow);
            }

            if (result  == DialogResult.Yes)
            {
                inActivityWindow.startTimer();
            }
        }
        private void activity_event(object sender, EventArgs e)
        {
            inActivityWindow.activityDetected("EVNT");
        }
        private const string script = @"if(typeof WINFORMS_SCR_LOADED === 'undefined') { document.addEventListener(""click"", function(e) { console.log(""WINFORMS CLICK ACTIVITY""); }); document.addEventListener(""scroll"", function(e) { console.log(""WINFORMS SCROLL ACTIVITY""); }); WINFORMS_SCR_LOADED = true; }";

        public void webBrowser2_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if(!e.IsLoading)
            {
                e.Browser.ExecuteScriptAsync(script);
            }
        }

        public void webBrowser2_ConsoleMessage(object sender, ConsoleMessageEventArgs e)
        {
            if (e.Message.Equals("WINFORMS CLICK ACTIVITY"))
            {
                Invoke(new Action(() =>
                {
                    inActivityWindow.activityDetected("JS CLK");
                }));
            } else if (e.Message.Equals("WINFORMS SCROLL ACTIVITY"))
            {
                Invoke(new Action(() =>
                {
                    inActivityWindow.activityDetected("JS SCR");
                }));
            }
        }

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
            if(clicks >= 5)
            {
                clicks = 0;
                if (debugEnabled) DebugDisable();
                else DebugEnable();
            }
        }

        private void activity_event(object sender, ScrollEventArgs e)
        {
            inActivityWindow.activityDetected("EVNT SCR");
        }

        private void activity_event(object sender, MouseEventArgs e)
        {
            inActivityWindow.activityDetected("EVNT MOU");
        }

        private void activity_event(object sender, AddressChangedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                writeStat(statCodes.Form1UrlChange, e.Address);
                inActivityWindow.activityDetected("URL CHNG");
            }));
        }

        public void form2Activity()
        {
            Invoke(new Action(() =>
            {
                inActivityWindow.activityDetected("FORM2");
            }));
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 't')
                DebugIfAble("TM " + timerRef.Enabled + timerRef.ToString());
        }
    }
}