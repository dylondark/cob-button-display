
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDebug = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnPartners = new System.Windows.Forms.Button();
            this.btnPrograms = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTouch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImage = global::Display_test.Properties.Resources.fishernewbg;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.btnHistory, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnPartners, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnPrograms, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.picLogo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 749);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnHistory
            // 
            this.btnHistory.AutoSize = true;
            this.btnHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnHistory.BackgroundImage = global::Display_test.Properties.Resources.historybutton;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnHistory.Location = new System.Drawing.Point(878, 353);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(377, 293);
            this.btnHistory.TabIndex = 37;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnSocialMedia_Click);
            // 
            // btnPartners
            // 
            this.btnPartners.AutoSize = true;
            this.btnPartners.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnPartners.BackgroundImage = global::Display_test.Properties.Resources.partnersbutton;
            this.btnPartners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPartners.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPartners.Location = new System.Drawing.Point(495, 353);
            this.btnPartners.Name = "btnPartners";
            this.btnPartners.Size = new System.Drawing.Size(377, 293);
            this.btnPartners.TabIndex = 36;
            this.btnPartners.UseVisualStyleBackColor = false;
            this.btnPartners.Click += new System.EventHandler(this.btnExpBusiness_Click);
            // 
            // btnPrograms
            // 
            this.btnPrograms.AutoSize = true;
            this.btnPrograms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnPrograms.BackgroundImage = global::Display_test.Properties.Resources.programsbutton;
            this.btnPrograms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrograms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPrograms.Location = new System.Drawing.Point(112, 353);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(377, 293);
            this.btnPrograms.TabIndex = 35;
            this.btnPrograms.UseVisualStyleBackColor = false;
            this.btnPrograms.Click += new System.EventHandler(this.btnAlumni_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.picLogo, 2);
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.picLogo.Image = global::Display_test.Properties.Resources.marketinglogo;
            this.picLogo.Location = new System.Drawing.Point(1036, 37);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(334, 157);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 34;
            this.picLogo.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.lblTouch, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(492, 37);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(383, 157);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // lblTouch
            // 
            this.lblTouch.BackColor = System.Drawing.Color.Transparent;
            this.lblTouch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTouch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTouch.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTouch.ForeColor = System.Drawing.Color.Black;
            this.lblTouch.Location = new System.Drawing.Point(0, 0);
            this.lblTouch.Margin = new System.Windows.Forms.Padding(0);
            this.lblTouch.Name = "lblTouch";
            this.lblTouch.Size = new System.Drawing.Size(229, 157);
            this.lblTouch.TabIndex = 30;
            this.lblTouch.Text = "Touch Screen to Interact";
            this.lblTouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Display_test.Properties.Resources.touch;
            this.pictureBox1.Location = new System.Drawing.Point(249, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
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
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(3840, 2160);
            this.MinimumSize = new System.Drawing.Size(960, 171);
            this.Name = "Form1";
            this.Text = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void initBrowser()
        {
            this.chromium = new CefSharp.WinForms.ChromiumWebBrowser();
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
            this.chromium.LifeSpanHandler = new ChromiumLifeSpanHandler();
            this.Controls.Add(this.chromium);
        }

        private CefSharp.WinForms.ChromiumWebBrowser chromium;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Label lblDebug;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblTouch;
        private Button btnHome;
        private PictureBox picLogo;
        private Button btnHistory;
        private Button btnPartners;
        private Button btnPrograms;
        //private PictureBox pictureBox1;
    }
}

