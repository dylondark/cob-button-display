
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
            this.chromium = new CefSharp.WinForms.ChromiumWebBrowser();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDebug = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bg4 = new System.Windows.Forms.PictureBox();
            this.bg3 = new System.Windows.Forms.PictureBox();
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTouch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bgAlumni = new System.Windows.Forms.Panel();
            this.btnAlumni = new System.Windows.Forms.Button();
            this.bgExpBusiness = new System.Windows.Forms.Panel();
            this.btnExpBusiness = new System.Windows.Forms.Button();
            this.bgSocialMedia = new System.Windows.Forms.Panel();
            this.btnSocialMedia = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bgAlumni.SuspendLayout();
            this.bgExpBusiness.SuspendLayout();
            this.bgSocialMedia.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImage = global::Display_test.Properties.Resources.polsky;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.bg4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.bg3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bg2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pnLogo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bgAlumni, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.bgExpBusiness, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.bgSocialMedia, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bg1, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 749);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // bg4
            // 
            this.bg4.BackColor = System.Drawing.Color.Transparent;
            this.bg4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg4.Image = global::Display_test.Properties.Resources.semitransparent;
            this.bg4.Location = new System.Drawing.Point(1258, 350);
            this.bg4.Margin = new System.Windows.Forms.Padding(0);
            this.bg4.Name = "bg4";
            this.bg4.Size = new System.Drawing.Size(112, 299);
            this.bg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg4.TabIndex = 31;
            this.bg4.TabStop = false;
            // 
            // bg3
            // 
            this.bg3.BackColor = System.Drawing.Color.Transparent;
            this.bg3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg3.Image = global::Display_test.Properties.Resources.semitransparent;
            this.bg3.Location = new System.Drawing.Point(0, 350);
            this.bg3.Margin = new System.Windows.Forms.Padding(0);
            this.bg3.Name = "bg3";
            this.bg3.Size = new System.Drawing.Size(109, 299);
            this.bg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg3.TabIndex = 30;
            this.bg3.TabStop = false;
            // 
            // bg2
            // 
            this.bg2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.bg2, 5);
            this.bg2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg2.Image = global::Display_test.Properties.Resources.semitransparent;
            this.bg2.Location = new System.Drawing.Point(0, 649);
            this.bg2.Margin = new System.Windows.Forms.Padding(0);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(1370, 37);
            this.bg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg2.TabIndex = 29;
            this.bg2.TabStop = false;
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnLogo.BackgroundImage = global::Display_test.Properties.Resources.semitransparent;
            this.tableLayoutPanel1.SetColumnSpan(this.pnLogo, 2);
            this.pnLogo.Controls.Add(this.picLogo);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLogo.Location = new System.Drawing.Point(875, 37);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(495, 157);
            this.pnLogo.TabIndex = 26;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.picLogo.Image = global::Display_test.Properties.Resources.CBALogo2;
            this.picLogo.Location = new System.Drawing.Point(161, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.MaximumSize = new System.Drawing.Size(900, 287);
            this.picLogo.MinimumSize = new System.Drawing.Size(157, 48);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(334, 157);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 25;
            this.picLogo.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.BackgroundImage = global::Display_test.Properties.Resources.semitransparent;
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
            // bgAlumni
            // 
            this.bgAlumni.BackColor = System.Drawing.Color.Transparent;
            this.bgAlumni.BackgroundImage = global::Display_test.Properties.Resources.semitransparent;
            this.bgAlumni.Controls.Add(this.btnAlumni);
            this.bgAlumni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgAlumni.Location = new System.Drawing.Point(109, 350);
            this.bgAlumni.Margin = new System.Windows.Forms.Padding(0);
            this.bgAlumni.Name = "bgAlumni";
            this.bgAlumni.Padding = new System.Windows.Forms.Padding(2);
            this.bgAlumni.Size = new System.Drawing.Size(383, 299);
            this.bgAlumni.TabIndex = 20;
            // 
            // btnAlumni
            // 
            this.btnAlumni.AutoSize = true;
            this.btnAlumni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlumni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnAlumni.BackgroundImage = global::Display_test.Properties.Resources.alumni_spotlight;
            this.btnAlumni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlumni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlumni.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAlumni.Location = new System.Drawing.Point(2, 2);
            this.btnAlumni.Name = "btnAlumni";
            this.btnAlumni.Size = new System.Drawing.Size(379, 295);
            this.btnAlumni.TabIndex = 1;
            this.btnAlumni.UseVisualStyleBackColor = false;
            this.btnAlumni.Click += new System.EventHandler(this.btnAlumni_Click);
            // 
            // bgExpBusiness
            // 
            this.bgExpBusiness.BackColor = System.Drawing.Color.Transparent;
            this.bgExpBusiness.BackgroundImage = global::Display_test.Properties.Resources.semitransparent;
            this.bgExpBusiness.Controls.Add(this.btnExpBusiness);
            this.bgExpBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgExpBusiness.Location = new System.Drawing.Point(492, 350);
            this.bgExpBusiness.Margin = new System.Windows.Forms.Padding(0);
            this.bgExpBusiness.Name = "bgExpBusiness";
            this.bgExpBusiness.Padding = new System.Windows.Forms.Padding(2);
            this.bgExpBusiness.Size = new System.Drawing.Size(383, 299);
            this.bgExpBusiness.TabIndex = 21;
            // 
            // btnExpBusiness
            // 
            this.btnExpBusiness.AutoSize = true;
            this.btnExpBusiness.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExpBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnExpBusiness.BackgroundImage = global::Display_test.Properties.Resources.experience_business;
            this.btnExpBusiness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExpBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpBusiness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnExpBusiness.Location = new System.Drawing.Point(2, 2);
            this.btnExpBusiness.Name = "btnExpBusiness";
            this.btnExpBusiness.Size = new System.Drawing.Size(379, 295);
            this.btnExpBusiness.TabIndex = 2;
            this.btnExpBusiness.UseVisualStyleBackColor = false;
            this.btnExpBusiness.Click += new System.EventHandler(this.btnExpBusiness_Click);
            // 
            // bgSocialMedia
            // 
            this.bgSocialMedia.BackColor = System.Drawing.Color.Transparent;
            this.bgSocialMedia.BackgroundImage = global::Display_test.Properties.Resources.semitransparent;
            this.bgSocialMedia.Controls.Add(this.btnSocialMedia);
            this.bgSocialMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgSocialMedia.Location = new System.Drawing.Point(875, 350);
            this.bgSocialMedia.Margin = new System.Windows.Forms.Padding(0);
            this.bgSocialMedia.Name = "bgSocialMedia";
            this.bgSocialMedia.Padding = new System.Windows.Forms.Padding(2);
            this.bgSocialMedia.Size = new System.Drawing.Size(383, 299);
            this.bgSocialMedia.TabIndex = 22;
            // 
            // btnSocialMedia
            // 
            this.btnSocialMedia.AutoSize = true;
            this.btnSocialMedia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSocialMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnSocialMedia.BackgroundImage = global::Display_test.Properties.Resources.social_media;
            this.btnSocialMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSocialMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSocialMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocialMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnSocialMedia.Location = new System.Drawing.Point(2, 2);
            this.btnSocialMedia.Name = "btnSocialMedia";
            this.btnSocialMedia.Size = new System.Drawing.Size(379, 295);
            this.btnSocialMedia.TabIndex = 3;
            this.btnSocialMedia.UseVisualStyleBackColor = false;
            this.btnSocialMedia.Click += new System.EventHandler(this.btnSocialMedia_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.BackgroundImage = global::Display_test.Properties.Resources.semitransparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.lblWelcome, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(492, 157);
            this.tableLayoutPanel4.TabIndex = 27;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(196, 157);
            this.lblWelcome.TabIndex = 29;
            this.lblWelcome.Text = "Welcome to the Marketing Department\r\n";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bg1
            // 
            this.bg1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.bg1, 5);
            this.bg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg1.Image = global::Display_test.Properties.Resources.semitransparent;
            this.bg1.Location = new System.Drawing.Point(0, 313);
            this.bg1.Margin = new System.Windows.Forms.Padding(0);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(1370, 37);
            this.bg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg1.TabIndex = 28;
            this.bg1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(1250, 630);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 100);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chromium);
            this.Controls.Add(this.pictureBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.bg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bgAlumni.ResumeLayout(false);
            this.bgAlumni.PerformLayout();
            this.bgExpBusiness.ResumeLayout(false);
            this.bgExpBusiness.PerformLayout();
            this.bgSocialMedia.ResumeLayout(false);
            this.bgSocialMedia.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser chromium;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Label lblDebug;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel bgAlumni;
        private Button btnAlumni;
        private Panel bgExpBusiness;
        private Button btnExpBusiness;
        private Panel bgSocialMedia;
        private Button btnSocialMedia;
        private Panel pnLogo;
        private PictureBox picLogo;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblWelcome;
        private Label lblTouch;
        private PictureBox bg4;
        private PictureBox bg3;
        private PictureBox bg2;
        private PictureBox bg1;
        //private PictureBox pictureBox1;
    }
}

