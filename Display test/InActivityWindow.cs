using System;
using System.Windows.Forms;

namespace Display_test
{
    public delegate void OnInactivityDetected();
    public partial class InActivityWindow : Form
    {
        Timer timeChecker;

        const int timerInterval = 6000;
        OnInactivityDetected onInactivity;

        public InActivityWindow(OnInactivityDetected onInactivityDetected)
        {
            InitializeComponent();
            this.Shown += new EventHandler(onFormShown);
            this.FormClosed += new FormClosedEventHandler(onFormClosed);
            this.onInactivity = onInactivityDetected;
        }

        void onFormShown(object obj, EventArgs args)
        {
            timeChecker = new Timer();
            timeChecker.Interval = timerInterval;
            timeChecker.Tick += new EventHandler(autoCloseWindow);
            timeChecker.Start();
        }

        void onFormClosed(object obj, EventArgs args)
        {
            timeChecker.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        void autoCloseWindow(object obj, EventArgs args)
        {
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

        }

        private void InActivityWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
