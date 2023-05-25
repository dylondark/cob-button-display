using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_test
{
    public delegate void OnInactivityDetected();
    public partial class InActivityWindow : Form
    {
        Timer timeChecker;

        const int timerInterval = 20000; // milliseconds window will show before closing
        public OnInactivityDetected onInactivity;
        public Func<string, Task> WriteDebug;
        Timer activityTimer;

        public InActivityWindow(OnInactivityDetected onInactivityDetected,
            Timer timerRef, Func<string, Task> writeDebug, int width)
        {
            InitializeComponent();
            activityTimer = timerRef;
            timeChecker = new Timer();
            timeChecker.Interval = timerInterval;
            timeChecker.Tick += new EventHandler(autoCloseWindow);
            this.Shown += new EventHandler(onFormShown);
            this.FormClosed += new FormClosedEventHandler(onFormClosed);
            this.onInactivity = onInactivityDetected;
            this.WriteDebug = writeDebug;
            this.Width = width;
            this.Height = width / 2;
            this.CenterToParent();
        }

        public void activityDetected(string m = "")
        {
            WriteDebug("ACTDET " + m);

            // reset timer
            activityTimer.Stop();
            activityTimer.Start();

            if (timeChecker.Enabled)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        public void startTimer()
        {
            WriteDebug("TM STR");
            activityTimer.Start();
        }

        public void stopTimer()
        {
            WriteDebug("TM STP");
            activityTimer.Stop();
        }

        void onFormShown(object obj, EventArgs args)
        {
            timeChecker.Stop();
            timeChecker.Start();
            this.CenterToParent();
            Form1 thisParent = (Form1)this.Owner;
            thisParent.writeStat(Form1.statCodes.IAWOpened);
        }

        void onFormClosed(object obj, EventArgs args)
        {
            timeChecker.Stop();
            Form1 thisParent = (Form1)this.Owner;
            thisParent.writeStat(Form1.statCodes.IAWClosed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteDebug("BTN CLICK");
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        void autoCloseWindow(object obj, EventArgs args)
        {
            WriteDebug("ACW");
            this.DialogResult = DialogResult.Cancel;
            timeChecker.Stop();
            this.Close();
            if (onInactivity != null)
            {
                this.onInactivity();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WriteDebug("LBL CLICK");
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void InActivityWindow_Load(object sender, EventArgs e)
        {

        }

        private void InActivityWindow_Click(object sender, EventArgs e)
        {
            WriteDebug("IAW CLICK");
            // If they click the window at all (even if they miss the button), they're not inactive.
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void InActivityWindow_Leave(object sender, EventArgs e)
        {
            WriteDebug("IAW FOCLV");
            // If they click the window at all (even if they miss the button), they're not inactive.
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void autoScale(object sender, EventArgs e)
        {
            const int scaleFactor = 60; // based on the desired font size for the label text on a 4k display
            float resFactor = Convert.ToSingle(this.Width) / 960f; // this will be 1 at 4k assuming the input width is 960 (3840 / 4)

            Font labelFont = new Font(new FontFamily("Microsoft Sans Serif"), scaleFactor * resFactor, FontStyle.Bold);
            label1.Font = labelFont;

            button1.Width = (int)(this.Width / 2.5f);
            button1.Height = (int)(this.Height / 5f);
            button1.Left = (this.Width / 2) - (button1.Width / 2);
            button1.Top = (int)((this.Height / 2) / 2.5f) - (button1.Height / 2);
            button1.Font = new Font(new FontFamily("Microsoft Sans Serif"), scaleFactor * resFactor * 0.5f, FontStyle.Bold);
        }
    }
}
