using System;

using System.Drawing;

using System.Windows.Forms;


namespace Display_test
{
    public partial class Form1 : Form
    {
        
        Cursor cursor = new Cursor(Cursor.Current.Handle);
        InActivityWindow inActivityWindow;
        private Timer timer;
        private bool isShowingInactivityModal = false;
        private int inactivityCheckDuration = 2000;//milliseconds

        public Form1()
        {
          
            timer = new Timer();
            timer.Interval = inactivityCheckDuration;
            timer.Tick += new System.EventHandler(onTimerTick);
            inActivityWindow = new InActivityWindow();

            InitializeComponent();
            webBrowser2.Hide();
            backButton.Hide();
            webBrowser2.ScriptErrorsSuppressed = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
           
            
            //this.ControlBox = false;
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //Form2 frm = new Form2();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            showWebPage("https://www.uakron.edu/cba/news-and-events/");
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
            Form2 frm = new Form2();
            frm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            closeWebpage();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //new comment
        }

        void showWebPage(String url)
        {
            webBrowser2.Navigate(url);
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            webBrowser2.Show();
            backButton.Show();
            pictureBox1.Hide();
            tableLayoutPanel1.Hide();
            pictureBox3.Hide();
            timer.Start();
        }

        void closeWebpage()
        {
            button1.Show();
            button2.Show();
            button3.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            webBrowser2.Hide();
            backButton.Hide();
            pictureBox1.Show();
            tableLayoutPanel1.Show();
            pictureBox3.Show();
        }

        void onTimerTick(object sender, EventArgs args)
        {
           navigateBackAfterInacitivity();
        }

        void navigateBackAfterInacitivity()
        {
            timer.Stop();

            DialogResult result = inActivityWindow.ShowDialog();
            if (result == DialogResult.Yes)
            {
                timer.Start();
            }
            else
            {
                closeWebpage();
            }
        }
    }
}
