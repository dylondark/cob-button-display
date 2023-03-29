using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_test
{
    public delegate void OnInactivityDetected();
    public partial class InActivityWindow : Form
    {
        Timer timeChecker;

        const int timerInterval = 10000;
        public OnInactivityDetected onInactivity;
        public Func<string, Task> WriteDebug;
        Timer activityTimer;

        public InActivityWindow(OnInactivityDetected onInactivityDetected, 
            Timer timerRef, Func<string, Task> writeDebug)
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
            this.CenterToParent();
        }

        public void activityDetected(string m = "")
        {
            WriteDebug("ACTDET " + m);
            activityTimer.Stop();
            activityTimer.Start();
            if(timeChecker.Enabled)
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
        }

        void onFormClosed(object obj, EventArgs args)
        {
            timeChecker.Stop();
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
    }
}
