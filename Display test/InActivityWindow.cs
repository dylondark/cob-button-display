using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_test
{
    public partial class InActivityWindow : Form
    {
        Timer timeChecker;
        const int timerInterval = 5000; 
        public InActivityWindow()
        {
            InitializeComponent();
            this.Shown += new EventHandler(onFormShown);
            this.FormClosed += new FormClosedEventHandler(onFormClosed);
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
