﻿using System;
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
            webBrowser1.Load("https://www.uakron.edu/search/search.dot?searchText=&collection=l2");
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           showWebPage("https://www.uakron.edu/cba/about-us/staff.dot");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showWebPage("https://www.uakron.edu/cba/faculty/");

        }

        private void button3_Click(object sender, EventArgs e)
        {
           showWebPage("https://www.uakron.edu/search/search.dot?searchText=&collection=l2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(webBrowser1.Visible)
            {
                closeWebPage();
            } else
            {
                this.Close();
            }
            
        }

        void showWebPage(String url)
        {
            if(url == null || url.Length == 0)
            {
                Console.WriteLine("invalid url");
                return;
            }

            webBrowser1.Load(url);
            button1.Hide();
            button2.Hide();
            button3.Hide();
            webBrowser1.Show();
            pictureBox1.Hide();
            tableLayoutPanel1.Hide();
            this.ControlBox = false;
        }

        void closeWebPage()
        {
            button1.Show();
            button2.Show();
            button3.Show();

            webBrowser1.Hide();
            pictureBox1.Show();
            tableLayoutPanel1.Show();
        }
    }
}
