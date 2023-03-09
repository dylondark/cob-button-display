using System;
using System.Security.Permissions;
using System.Windows.Forms;


namespace Display_test
{
    public enum CurrentPage {  HomePage, FirstLevelWebpage, SecondLevelButtonsPage,
        Directions
    }
    public partial class Form1 : Form
    {

        
        Form2 secondLevelButtonsWindow;
        private CurrentPage currentPage;
        DirectionsForm directionsForm;

        private Timer timer;
        private int inactivityCheckDuration = 60000;//milliseconds
        private const int WM_TOUCH = 0x246;
        private const int WM_TOUCHUPDATE = 0x245;

        public Form1()
        {
            currentPage = CurrentPage.HomePage;
            timer = new Timer();
            timer.Interval = inactivityCheckDuration;
            timer.Tick += new System.EventHandler(onTimerTick);

            createBackButton();
            createMap();
            InitializeComponent();
            webBrowser2.Hide();
            backButton.Hide();
            webBrowser2.ScriptErrorsSuppressed = true;
            FormBorderStyle = FormBorderStyle.None;
            
            this.WindowState = FormWindowState.Maximized;
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_TOUCH:
                case WM_TOUCHUPDATE:
                    System.Diagnostics.Debug.WriteLine("Gesture seen");
                    timer.Stop();
                    timer.Start();
                    break;
                default:
                    break;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            currentPage = CurrentPage.Directions;
            directionsForm = new DirectionsForm();
            directionsForm.Show();
            timer.Start();

            // showWebPage("https://www.uakron.edu/cba/news-and-events/");
            // this.ControlBox = false;
            // FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            closeCurrentPage();
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

        void closeCurrentPage()
        {
            if (currentPage != CurrentPage.Directions)
            {
                webBrowser2.Hide();
                backButton.Hide();
                pictureBox1.Show();
                tableLayoutPanel1.Show();
                pictureBox3.Show();
                currentPage = CurrentPage.HomePage;
            }
            else
            {
                directionsForm.Hide();
            }
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
               inActivityWindow = new InActivityWindow(closeCurrentPage);
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
