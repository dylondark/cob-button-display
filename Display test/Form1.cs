using System;

using System.Drawing;

using System.Windows.Forms;


namespace Display_test
{
    public enum CurrentPage {  HomePage, FirstLevelWebpage, SecondLevelButtonsPage }
    public partial class Form1 : Form
    {
        
        Form2 secondLevelButtonsWindow;
        private CurrentPage currentPage;

        private Timer timer;
        private int inactivityCheckDuration = 60000;//milliseconds

        public Form1()
        {
            currentPage = CurrentPage.HomePage;
            timer = new Timer();
            timer.Interval = inactivityCheckDuration;
            timer.Tick += new System.EventHandler(onTimerTick);

            createBackButton();
            InitializeComponent();
            webBrowser2.Hide();
            backButton.Hide();
            webBrowser2.ScriptErrorsSuppressed = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            currentPage = CurrentPage.SecondLevelButtonsPage;
            secondLevelButtonsWindow = new Form2();
            secondLevelButtonsWindow.Show();
            secondLevelButtonsWindow.FormClosed += new FormClosedEventHandler(onSecondLevelFormClosed);
            timer.Start();
        }

       void  onSecondLevelFormClosed(object obj, EventArgs args)
        {
             timer.Stop();
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
            currentPage = CurrentPage.FirstLevelWebpage;
           backButton.Show();
            backButton.BringToFront();
            backButton.BringToFront();
           webBrowser2.Navigate(url);
           
           webBrowser2.Show();
           pictureBox1.Hide();
           tableLayoutPanel1.Hide();
            pictureBox3.Hide();

           timer.Start();
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

        void onTimerTick(object sender, EventArgs args)
        {
           navigateBackAfterInacitivity();
        }

        void navigateBackAfterInacitivity()
        {
            timer.Stop();
            DialogResult result = DialogResult.None;
            InActivityWindow inActivityWindow;
            if (currentPage == CurrentPage.FirstLevelWebpage)
            {
               inActivityWindow = new InActivityWindow(closeWebpage);
               result = inActivityWindow.ShowDialog();

            } else if(currentPage == CurrentPage.SecondLevelButtonsPage && secondLevelButtonsWindow != null)
            {
                inActivityWindow = new InActivityWindow(() => {
                    secondLevelButtonsWindow.Close();
                    timer.Stop();
                });
                result = inActivityWindow.ShowDialog();
            }

            if (result  == DialogResult.Yes)
            {
                timer.Start();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
