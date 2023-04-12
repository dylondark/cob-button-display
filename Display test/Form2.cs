﻿using CefSharp;
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

        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            webBrowser1.Load("https://www.uakron.edu/search/search.dot?searchText=&collection=l2");
            this.form1 = form1;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // init lifespanhandler for redirection of new tab requests back to the original browser
            webBrowser1.LifeSpanHandler = new ChromiumLifeSpanHandler();

            picCOB.Left = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.writeStat(9);
           showWebPage("https://www.uakron.edu/cba/about-us/staff.dot");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.writeStat(10);
            showWebPage("https://www.uakron.edu/cba/faculty/");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            form1.writeStat(11);
            showWebPage("https://www.uakron.edu/search/search.dot?searchText=&collection=l2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(webBrowser1.Visible)
            {
                closeWebPage();
            } else
            {
                form1.writeStat(0, "lvl2-back");
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
            form1.form2Activity();

            webBrowser1.Load(url);
            btnStaff.Hide();
            btnFaculty.Hide();
            btnSearch.Hide();
            webBrowser1.Show();
            picCOB.Hide();
            tableLayoutPanel1.Hide();
            this.ControlBox = false;
        }

        void closeWebPage()
        {
            btnStaff.Show();
            btnFaculty.Show();
            btnSearch.Show();
            form1.writeStat(14);
            webBrowser1.Hide();
            picCOB.Show();
            tableLayoutPanel1.Show();
        }

        private void activity_event(object sender, EventArgs e)
        {
            form1.form2Activity();
        }

        private void activity_event(object sender, MouseEventArgs e)
        {
            form1.form2Activity();
        }

        private void webBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {
            form1.webBrowser2_LoadingStateChanged(sender, e);
        }

        private void webBrowser1_ConsoleMessage(object sender, CefSharp.ConsoleMessageEventArgs e)
        {
            form1.webBrowser2_ConsoleMessage(sender, e);
        }

        private void webBrowser1_AddressChanged(object sender, CefSharp.AddressChangedEventArgs e)
        {
            form1.writeStat(13, e.Address);
        }
    }
}
