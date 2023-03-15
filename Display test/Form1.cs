using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

            FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
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
           webBrowser2.Load(url);
           
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
    }
}
