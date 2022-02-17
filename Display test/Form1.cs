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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser2.Hide();
            //button4.Hide();


        }
       //nope
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            webBrowser2.Show();
            // Form1 f1 = new Form1();
            //Form2 f2 = new Form2();
            //f2.ShowDialog(); // Shows Form2
            //f1.Close();
            button4.Show();
            pictureBox1.Hide();
            tableLayoutPanel1.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            webBrowser2.Show();
            button4.Show();
            pictureBox1.Hide();
            tableLayoutPanel1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            webBrowser2.Show();
            button4.Show();
            pictureBox1.Hide();
            tableLayoutPanel1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Show();
            button3.Show();
            webBrowser2.Hide();
            button4.Hide();
            pictureBox1.Show();
            tableLayoutPanel1.Show();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
