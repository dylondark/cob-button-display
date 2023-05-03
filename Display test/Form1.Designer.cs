
using System.Windows.Forms;

namespace Display_test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chromium = new CefSharp.WinForms.ChromiumWebBrowser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProfDev = new System.Windows.Forms.Button();
            this.btnCentersInstitutes = new System.Windows.Forms.Button();
            this.btnExecEd = new System.Windows.Forms.Button();
            this.btnUndergrad = new System.Windows.Forms.Button();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.btnGrad = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCOB = new System.Windows.Forms.PictureBox();
            this.lblDebug = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCOB)).BeginInit();
            this.SuspendLayout();
            // 
            // chromium
            // 
            this.chromium.ActivateBrowserOnCreation = false;
            this.chromium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromium.Location = new System.Drawing.Point(0, 0);
            this.chromium.Margin = new System.Windows.Forms.Padding(2);
            this.chromium.MinimumSize = new System.Drawing.Size(10, 10);
            this.chromium.Name = "chromium";
            this.chromium.Size = new System.Drawing.Size(1370, 749);
            this.chromium.TabIndex = 4;
            this.chromium.AddressChanged += new System.EventHandler<CefSharp.AddressChangedEventArgs>(this.activity_event);
            this.chromium.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.webBrowser2_LoadingStateChanged);
            this.chromium.ConsoleMessage += new System.EventHandler<CefSharp.ConsoleMessageEventArgs>(this.webBrowser2_ConsoleMessage);
            this.chromium.Click += new System.EventHandler(this.activity_event);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImage = global::Display_test.Properties.Resources.Untitled_design__1_;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.btnProfDev, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCentersInstitutes, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExecEd, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnUndergrad, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDirectory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnGrad, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.picCOB, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 749);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnProfDev
            // 
            this.btnProfDev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfDev.AutoSize = true;
            this.btnProfDev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProfDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnProfDev.BackgroundImage = global::Display_test.Properties.Resources.PD_Picture;
            this.btnProfDev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnProfDev.Location = new System.Drawing.Point(481, 338);
            this.btnProfDev.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfDev.Name = "btnProfDev";
            this.btnProfDev.Size = new System.Drawing.Size(407, 258);
            this.btnProfDev.TabIndex = 1;
            this.btnProfDev.UseVisualStyleBackColor = false;
            this.btnProfDev.Click += new System.EventHandler(this.ProfDev_Click);
            this.btnProfDev.Resize += new System.EventHandler(this.gridbuttonResize);
            // 
            // btnCentersInstitutes
            // 
            this.btnCentersInstitutes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCentersInstitutes.AutoSize = true;
            this.btnCentersInstitutes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCentersInstitutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnCentersInstitutes.BackgroundImage = global::Display_test.Properties.Resources.centers_and_institutes;
            this.btnCentersInstitutes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCentersInstitutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentersInstitutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnCentersInstitutes.Location = new System.Drawing.Point(71, 339);
            this.btnCentersInstitutes.Name = "btnCentersInstitutes";
            this.btnCentersInstitutes.Size = new System.Drawing.Size(405, 256);
            this.btnCentersInstitutes.TabIndex = 0;
            this.btnCentersInstitutes.UseVisualStyleBackColor = false;
            this.btnCentersInstitutes.Click += new System.EventHandler(this.CentersInstitutes_Click);
            this.btnCentersInstitutes.Resize += new System.EventHandler(this.gridbuttonResize);
            // 
            // btnExecEd
            // 
            this.btnExecEd.AutoSize = true;
            this.btnExecEd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExecEd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnExecEd.BackgroundImage = global::Display_test.Properties.Resources.Executive_Education;
            this.btnExecEd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExecEd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExecEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecEd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnExecEd.Location = new System.Drawing.Point(892, 338);
            this.btnExecEd.Margin = new System.Windows.Forms.Padding(2);
            this.btnExecEd.Name = "btnExecEd";
            this.btnExecEd.Size = new System.Drawing.Size(407, 258);
            this.btnExecEd.TabIndex = 2;
            this.btnExecEd.UseVisualStyleBackColor = false;
            this.btnExecEd.Click += new System.EventHandler(this.ExecEd_Click);
            this.btnExecEd.Resize += new System.EventHandler(this.gridbuttonResize);
            // 
            // btnUndergrad
            // 
            this.btnUndergrad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndergrad.AutoSize = true;
            this.btnUndergrad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUndergrad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnUndergrad.BackgroundImage = global::Display_test.Properties.Resources.undergraduate3;
            this.btnUndergrad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUndergrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndergrad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnUndergrad.Location = new System.Drawing.Point(481, 76);
            this.btnUndergrad.Margin = new System.Windows.Forms.Padding(2);
            this.btnUndergrad.Name = "btnUndergrad";
            this.btnUndergrad.Size = new System.Drawing.Size(407, 258);
            this.btnUndergrad.TabIndex = 9;
            this.btnUndergrad.UseVisualStyleBackColor = false;
            this.btnUndergrad.Click += new System.EventHandler(this.Undergrad_Click);
            this.btnUndergrad.Resize += new System.EventHandler(this.gridbuttonResize);
            // 
            // btnDirectory
            // 
            this.btnDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirectory.AutoSize = true;
            this.btnDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnDirectory.BackgroundImage = global::Display_test.Properties.Resources.Executive_Education__1_;
            this.btnDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnDirectory.Location = new System.Drawing.Point(71, 77);
            this.btnDirectory.MaximumSize = new System.Drawing.Size(1300, 1250);
            this.btnDirectory.MinimumSize = new System.Drawing.Size(325, 200);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(405, 256);
            this.btnDirectory.TabIndex = 8;
            this.btnDirectory.Text = "\r\n";
            this.btnDirectory.UseVisualStyleBackColor = false;
            this.btnDirectory.Click += new System.EventHandler(this.Directory_Click);
            this.btnDirectory.Resize += new System.EventHandler(this.gridbuttonResize);
            // 
            // btnGrad
            // 
            this.btnGrad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrad.AutoSize = true;
            this.btnGrad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGrad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnGrad.BackgroundImage = global::Display_test.Properties.Resources.Graduate3;
            this.btnGrad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnGrad.Location = new System.Drawing.Point(892, 76);
            this.btnGrad.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrad.Name = "btnGrad";
            this.btnGrad.Size = new System.Drawing.Size(407, 258);
            this.btnGrad.TabIndex = 10;
            this.btnGrad.UseVisualStyleBackColor = false;
            this.btnGrad.Click += new System.EventHandler(this.Grad_Click);
            this.btnGrad.Resize += new System.EventHandler(this.gridbuttonResize);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.lblWelcome, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(482, 601);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(405, 145);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Location = new System.Drawing.Point(3, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(237, 145);
            this.lblWelcome.TabIndex = 14;
            this.lblWelcome.Text = "Touch Screen to Interact";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // picCOB
            // 
            this.picCOB.BackColor = System.Drawing.Color.Transparent;
            this.picCOB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCOB.Image = global::Display_test.Properties.Resources.re_sized;
            this.picCOB.Location = new System.Drawing.Point(482, 3);
            this.picCOB.MaximumSize = new System.Drawing.Size(900, 287);
            this.picCOB.MinimumSize = new System.Drawing.Size(157, 48);
            this.picCOB.Name = "picCOB";
            this.picCOB.Size = new System.Drawing.Size(405, 68);
            this.picCOB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCOB.TabIndex = 6;
            this.picCOB.TabStop = false;
            this.picCOB.Click += new System.EventHandler(this.pictureBox3_Click);
            this.picCOB.DoubleClick += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblDebug.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDebug.Location = new System.Drawing.Point(8, 8);
            this.lblDebug.Margin = new System.Windows.Forms.Padding(8);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Padding = new System.Windows.Forms.Padding(1);
            this.lblDebug.Size = new System.Drawing.Size(65, 24);
            this.lblDebug.TabIndex = 13;
            this.lblDebug.Text = "Debug";
            this.lblDebug.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.BackgroundImage = global::Display_test.Properties.Resources.backbutton;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1250, 630);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 100);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.BackColor = System.Drawing.Color.Silver;
            this.btnHome.BackgroundImage = global::Display_test.Properties.Resources.homebutton;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1150, 630);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 100);
            this.btnHome.TabIndex = 15;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chromium);
            this.MaximumSize = new System.Drawing.Size(3840, 2160);
            this.MinimumSize = new System.Drawing.Size(960, 171);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.activity_event);
            this.ResizeEnd += new System.EventHandler(this.autoScale);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.activity_event);
            this.Click += new System.EventHandler(this.activity_event);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.activity_event);
            this.MouseHover += new System.EventHandler(this.activity_event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.activity_event);
            this.Resize += new System.EventHandler(this.autoScale);
            this.ImeModeChanged += new System.EventHandler(this.activity_event);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCOB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser chromium;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExecEd;
        private System.Windows.Forms.Button btnGrad;
        private System.Windows.Forms.Button btnUndergrad;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Button btnCentersInstitutes;
        private System.Windows.Forms.Button btnProfDev;
        private System.Windows.Forms.PictureBox picCOB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Label lblDebug;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblWelcome;
    }
}

