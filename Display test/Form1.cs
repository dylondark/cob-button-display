using CefSharp;
using CefSharp.Handler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
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

        public Form1()
        {
            currentPage = CurrentPage.HomePage;
            timerRef = new Timer();
            timerRef.Interval = inactivityCheckDuration;
            timerRef.Tick += onTimerTick;
            inActivityWindow = new InActivityWindow(closeWebpage, timerRef, DebugIfAble);

            createBackButton();
            InitializeComponent();
            webBrowser2.Hide();
            backButton.Hide();
            labelDebug.Hide();

            labelDebug.Text = "";

            FormBorderStyle = FormBorderStyle.None;
            
            this.WindowState = FormWindowState.Maximized;
        }

        private List<string> Debugs = new List<string>();

        private async Task DebugIfAble(string msg)
        {
            if (!debugEnabled) return;
            Debug.WriteLine(msg);
            Debugs.Add(msg);
            labelDebug.Text = string.Join(Environment.NewLine, Debugs);
            labelDebug.BringToFront();
            labelDebug.Show();
            labelDebug.BringToFront();
            await Task.Delay(6000);
            Debugs.Remove(msg);
            if(Debugs.Count == 0)
            {
                labelDebug.Hide();
                labelDebug.Text = "";
            } else
            {
                labelDebug.Text = string.Join(Environment.NewLine, Debugs);
            }
        }

        private async Task DebugDisable()
        {
            debugEnabled = false;
            Debug.WriteLine("WinForm Debug Disabled");
            labelDebug.BackColor = Color.LightCoral;
            labelDebug.Text = "OFF";
            labelDebug.BringToFront();
            labelDebug.Show();
            await Task.Delay(6000);
            labelDebug.Hide();
            labelDebug.Text = "";
            labelDebug.BackColor = Color.PaleVioletRed;
        }
        private async Task DebugEnable()
        {
            Debug.WriteLine("WinForm Debug Enabled");
            debugEnabled = true;
            labelDebug.BackColor = Color.LightSeaGreen;
            await DebugIfAble("EN");
            labelDebug.BackColor = Color.PaleVioletRed;
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_TOUCH:
                case WM_TOUCHUPDATE:
                    inActivityWindow.activityDetected();
                    DebugIfAble("WMSG");
                    break;
                default:
                    break;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            showWebPage("https://www.uakron.edu/cba/centers-and-institutes/");
            this.ControlBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showWebPage("https://www.uakron.edu/cba/outcomes/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           showWebPage("https://www.uakron.edu/cba/executive/");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            showWebPage("https://uakron.edu/cba/undergraduate/majors/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showWebPage("https://www.uakron.edu/cba/graduate/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentPage = CurrentPage.SecondLevelButtonsPage;
            secondLevelButtonsWindow = new Form2();
            secondLevelButtonsWindow.Show();
            secondLevelButtonsWindow.FormClosed += new FormClosedEventHandler(onSecondLevelFormClosed);
            inActivityWindow.startTimer();
        }

       void  onSecondLevelFormClosed(object obj, EventArgs args)
        {
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
           webBrowser2.Load(url);
           
           webBrowser2.Show();
           pictureBox1.Hide();
           tableLayoutPanel1.Hide();
            pictureBox3.Hide();

            inActivityWindow.startTimer();
        }

        void closeWebpage()
        {
            webBrowser2.Hide();
            backButton.Hide();
            pictureBox1.Show();
            tableLayoutPanel1.Show();
            pictureBox3.Show();
            currentPage = CurrentPage.HomePage;
        }

        void secondLevelBack()
        {
            secondLevelButtonsWindow.Close();
            inActivityWindow.stopTimer();
        }

        void onTimerTick(object sender, EventArgs args)
        {
            navigateBackAfterInacitivity();
        }

        class InactivityAudioHandler : AudioHandler
        {
            private InActivityWindow inActivityWindow;
            private IAudioHandler handle;
            public InactivityAudioHandler(InActivityWindow inActivityWindow, IAudioHandler handle)
            {
                this.inActivityWindow = inActivityWindow;
                this.handle = handle;
            }

            protected override void OnAudioStreamStarted(CefSharp.IWebBrowser chromiumWebBrowser, CefSharp.IBrowser browser, CefSharp.Structs.AudioParameters parameters, int channels)
            {
                inActivityWindow.stopTimer(); // inactivity shouldn't be detected when media is playing.
                if (handle != null)
                    handle.OnAudioStreamStarted(chromiumWebBrowser, browser, parameters, channels);
            }

            protected override void OnAudioStreamStopped(IWebBrowser chromiumWebBrowser, IBrowser browser)
            {
                inActivityWindow.activityDetected(); // media stopped, start timing for inactivity again.
                if (handle != null)
                    handle.OnAudioStreamStopped(chromiumWebBrowser, browser);
            }

            protected override void OnAudioStreamError(IWebBrowser chromiumWebBrowser, IBrowser browser, string errorMessage)
            {
                inActivityWindow.activityDetected(); // media stopped, start timing for inactivity again.
                if (handle != null)
                    handle.OnAudioStreamError(chromiumWebBrowser, browser, errorMessage);
            }
        }

        void navigateBackAfterInacitivity()
        {
            inActivityWindow.stopTimer();
            DialogResult result = DialogResult.None;
            if (currentPage == CurrentPage.FirstLevelWebpage)
            {
                inActivityWindow = new InActivityWindow(closeWebpage, timerRef, DebugIfAble);
                result = inActivityWindow.ShowDialog();
            } else if(currentPage == CurrentPage.SecondLevelButtonsPage && secondLevelButtonsWindow != null)
            {
                inActivityWindow = new InActivityWindow(secondLevelBack, timerRef, DebugIfAble);
                result = inActivityWindow.ShowDialog();
            }

            if (result  == DialogResult.Yes)
            {
                inActivityWindow.startTimer();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser2_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if(!(webBrowser2.AudioHandler is InactivityAudioHandler))
            {
                webBrowser2.AudioHandler = new InactivityAudioHandler(inActivityWindow, webBrowser2.AudioHandler);
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
            int colW = pictureBox3.Size.Width + pictureBox3.Margin.Horizontal;
            int imgWidthScaled = pictureBox3.Size.Height * pictureBox3.BackgroundImage.Width / pictureBox3.BackgroundImage.Height;
            var marg = pictureBox3.Margin;
            int hMarg = colW - imgWidthScaled;
            marg.Left = hMarg - 10;
            marg.Right = 10;
            pictureBox3.Margin = marg;
        }

        private void label1_Resize(object sender, EventArgs e)
        {
            Font font = label1.Font;
            int fontW = TextRenderer.MeasureText(label1.Text, font).Width,
                w = label1.Width,
                target = w * 9 / 10;
            if (fontW < target || fontW > w)
            {
                label1.Font = new Font(font.FontFamily, font.Size * target / fontW, font.Style, font.Unit);
            }
        }

        // Tap the logo 5 times quickly (within 3 secs) to toggle debugging.
        // In order to fully disable debugging (for publishing), either
        // return at the top of this method or make DebugEnable return at the top
        // However that shouldn't be necessary anyway, debugging is just a small textbox in the bottom right corner with error codes.
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
    }
}
