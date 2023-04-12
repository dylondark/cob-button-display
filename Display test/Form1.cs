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
            inActivityWindow = new InActivityWindow(closeWebpage, timerRef, DebugIfAble);

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

        /*
         * Stat Codes:
         * 0: close page
         * 1-6: Form1 Buttons (topleft origin)
         * 7-8: Debug on, off
         * 9-11: Form2 Buttons
         * 12: form1 URL change
         * 13: form2 URL change
         * 14: second level back
         * 20: program start
         */
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
                    File.WriteAllText(statsFile, "UTC Timestamp,Action Code,Details" + Environment.NewLine);
                }
                File.AppendAllText(statsFile, string.Format("{0},{1}{2}", DateTimeOffset.UtcNow.ToString("s"), "20", Environment.NewLine));
            }
        }

        public void writeStat(int code)
        {
            Task.Run(() =>
            {
                lock (statsLock)
                {
                    File.AppendAllText(statsFile, string.Format("{0},{1}{2}", DateTimeOffset.UtcNow.ToString("s"), code, Environment.NewLine));
                }
            });
        }

        public void writeStat(int code, string str)
        {
            Task.Run(() =>
            {
                lock (statsLock)
                {
                    File.AppendAllText(statsFile, string.Format("{0},{1},{2}{3}", DateTimeOffset.UtcNow.ToString("s"), code, str, Environment.NewLine));
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
            writeStat(8);
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
            writeStat(7);
#if DEBUG
            Debug.WriteLine("WinForm Debug Enabled");
            debugEnabled = true;
            lblDebug.BackColor = Color.LightSeaGreen;
            await DebugIfAble("EN");
            lblDebug.BackColor = Color.PaleGoldenrod;
#endif
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeStat(4);
            showWebPage("https://www.uakron.edu/cba/centers-and-institutes/");
            this.ControlBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeStat(5);
            showWebPage("https://www.uakron.edu/cba/outcomes/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            writeStat(6);
            showWebPage("https://www.uakron.edu/cba/executive/");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            writeStat(2);
            showWebPage("https://uakron.edu/cba/undergraduate/majors/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            writeStat(3);
            showWebPage("https://www.uakron.edu/cba/graduate/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            writeStat(1);
            currentPage = CurrentPage.SecondLevelButtonsPage;
            secondLevelButtonsWindow = new Form2(this);
            this.Controls.Remove(lblDebug);
            secondLevelButtonsWindow.Controls.Add(lblDebug);
            secondLevelButtonsWindow.Show();
            secondLevelButtonsWindow.FormClosed += new FormClosedEventHandler(onSecondLevelFormClosed);
            inActivityWindow.startTimer();
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

        private void pictureBox3_Resize(object sender, EventArgs e)
        {
            int colW = picCOB.Size.Width + picCOB.Margin.Horizontal;
            int imgWidthScaled = picCOB.Size.Height * picCOB.BackgroundImage.Width / picCOB.BackgroundImage.Height;
            var marg = picCOB.Margin;
            int hMarg = colW - imgWidthScaled;
            marg.Left = hMarg - 10;
            marg.Right = 10;
            picCOB.Margin = marg;
        }

        private void label1_Resize(object sender, EventArgs e)
        {
            Font font = lblWelcome.Font;
            int fontW = TextRenderer.MeasureText(lblWelcome.Text, font).Width,
                w = lblWelcome.Width,
                target = w * 9 / 10;
            if (fontW < target || fontW > w)
            {
                lblWelcome.Font = new Font(font.FontFamily, font.Size * target / fontW, font.Style, font.Unit);
            }
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
                writeStat(12, e.Address);
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