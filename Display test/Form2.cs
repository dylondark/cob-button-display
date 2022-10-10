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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button4.Hide();
            webBrowser1.Navigate("https://www.uakron.edu/search/search.dot?searchText=&collection=l2");
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.uakron.edu/cba/about-us/staff.dot");
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Show();
            webBrowser1.Show();
            pictureBox1.Hide();
            tableLayoutPanel1.Hide();
            this.ControlBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.uakron.edu/cba/faculty/");
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Show();
            webBrowser1.Show();
            pictureBox1.Hide();
            tableLayoutPanel1.Hide();
            this.ControlBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.uakron.edu/search/search.dot?searchText=&collection=l2");
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Show();
            webBrowser1.Show();
            pictureBox1.Hide();
            tableLayoutPanel1.Hide();
            this.ControlBox = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Show();
            button3.Show();
           
            webBrowser1.Hide();
            button4.Hide();
            pictureBox1.Show();
            tableLayoutPanel1.Show();
            //Form1 frm = new Form1();
            this.Hide();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
