
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnProfDev = new System.Windows.Forms.Button();
            this.btnCentersInstitutes = new System.Windows.Forms.Button();
            this.btnExecEd = new System.Windows.Forms.Button();
            this.btnUndergrad = new System.Windows.Forms.Button();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.btnGrad = new System.Windows.Forms.Button();
            this.tlpTouch = new System.Windows.Forms.TableLayoutPanel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picTouch = new System.Windows.Forms.PictureBox();
            this.picCOB = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblDebug = new System.Windows.Forms.Label();
            this.tlpDirectory = new System.Windows.Forms.TableLayoutPanel();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDirectoryBack = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpTouch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTouch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCOB)).BeginInit();
            this.tlpDirectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.BackgroundImage = global::Display_test.Properties.Resources.Untitled_design__1_;
            this.tlpMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpMain.ColumnCount = 5;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.Controls.Add(this.btnProfDev, 2, 2);
            this.tlpMain.Controls.Add(this.btnCentersInstitutes, 1, 2);
            this.tlpMain.Controls.Add(this.btnExecEd, 3, 2);
            this.tlpMain.Controls.Add(this.btnUndergrad, 2, 1);
            this.tlpMain.Controls.Add(this.btnDirectory, 1, 1);
            this.tlpMain.Controls.Add(this.btnGrad, 3, 1);
            this.tlpMain.Controls.Add(this.tlpTouch, 2, 3);
            this.tlpMain.Controls.Add(this.picCOB, 2, 0);
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1264, 681);
            this.tlpMain.TabIndex = 6;
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
            this.btnProfDev.Location = new System.Drawing.Point(444, 308);
            this.btnProfDev.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfDev.Name = "btnProfDev";
            this.btnProfDev.Size = new System.Drawing.Size(375, 234);
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
            this.btnCentersInstitutes.Location = new System.Drawing.Point(66, 309);
            this.btnCentersInstitutes.Name = "btnCentersInstitutes";
            this.btnCentersInstitutes.Size = new System.Drawing.Size(373, 232);
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
            this.btnExecEd.Location = new System.Drawing.Point(823, 308);
            this.btnExecEd.Margin = new System.Windows.Forms.Padding(2);
            this.btnExecEd.Name = "btnExecEd";
            this.btnExecEd.Size = new System.Drawing.Size(375, 234);
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
            this.btnUndergrad.Location = new System.Drawing.Point(444, 70);
            this.btnUndergrad.Margin = new System.Windows.Forms.Padding(2);
            this.btnUndergrad.Name = "btnUndergrad";
            this.btnUndergrad.Size = new System.Drawing.Size(375, 234);
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
            this.btnDirectory.Location = new System.Drawing.Point(66, 71);
            this.btnDirectory.MaximumSize = new System.Drawing.Size(1300, 1250);
            this.btnDirectory.MinimumSize = new System.Drawing.Size(325, 200);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(373, 232);
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
            this.btnGrad.Location = new System.Drawing.Point(823, 70);
            this.btnGrad.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrad.Name = "btnGrad";
            this.btnGrad.Size = new System.Drawing.Size(375, 234);
            this.btnGrad.TabIndex = 10;
            this.btnGrad.UseVisualStyleBackColor = false;
            this.btnGrad.Click += new System.EventHandler(this.Grad_Click);
            this.btnGrad.Resize += new System.EventHandler(this.gridbuttonResize);
            // 
            // tlpTouch
            // 
            this.tlpTouch.ColumnCount = 2;
            this.tlpTouch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpTouch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpTouch.Controls.Add(this.lblWelcome, 0, 0);
            this.tlpTouch.Controls.Add(this.picTouch, 1, 0);
            this.tlpTouch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTouch.Location = new System.Drawing.Point(445, 547);
            this.tlpTouch.Name = "tlpTouch";
            this.tlpTouch.RowCount = 1;
            this.tlpTouch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTouch.Size = new System.Drawing.Size(373, 131);
            this.tlpTouch.TabIndex = 15;
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
            this.lblWelcome.Size = new System.Drawing.Size(217, 131);
            this.lblWelcome.TabIndex = 14;
            this.lblWelcome.Text = "Touch Screen to Interact";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picTouch
            // 
            this.picTouch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picTouch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTouch.Image = ((System.Drawing.Image)(resources.GetObject("picTouch.Image")));
            this.picTouch.Location = new System.Drawing.Point(243, 20);
            this.picTouch.Margin = new System.Windows.Forms.Padding(20);
            this.picTouch.Name = "picTouch";
            this.picTouch.Size = new System.Drawing.Size(110, 91);
            this.picTouch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTouch.TabIndex = 15;
            this.picTouch.TabStop = false;
            // 
            // picCOB
            // 
            this.picCOB.BackColor = System.Drawing.Color.Transparent;
            this.picCOB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCOB.Image = global::Display_test.Properties.Resources.re_sized;
            this.picCOB.Location = new System.Drawing.Point(445, 3);
            this.picCOB.MaximumSize = new System.Drawing.Size(900, 287);
            this.picCOB.MinimumSize = new System.Drawing.Size(157, 48);
            this.picCOB.Name = "picCOB";
            this.picCOB.Size = new System.Drawing.Size(373, 62);
            this.picCOB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCOB.TabIndex = 6;
            this.picCOB.TabStop = false;
            this.picCOB.Click += new System.EventHandler(this.pictureBox3_Click);
            this.picCOB.DoubleClick += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.BackgroundImage = global::Display_test.Properties.Resources.backbutton;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1130, 550);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 100);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.BackColor = System.Drawing.Color.Silver;
            this.btnHome.BackgroundImage = global::Display_test.Properties.Resources.homebutton;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1030, 550);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 100);
            this.btnHome.TabIndex = 15;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            // tlpDirectory
            // 
            this.tlpDirectory.BackgroundImage = global::Display_test.Properties.Resources.Untitled_design__1_;
            this.tlpDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpDirectory.ColumnCount = 7;
            this.tlpDirectory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.tlpDirectory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpDirectory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.5F));
            this.tlpDirectory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpDirectory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.5F));
            this.tlpDirectory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpDirectory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.tlpDirectory.Controls.Add(this.btnStaff, 1, 1);
            this.tlpDirectory.Controls.Add(this.btnFaculty, 3, 1);
            this.tlpDirectory.Controls.Add(this.btnSearch, 5, 1);
            this.tlpDirectory.Controls.Add(this.pictureBox2, 0, 3);
            this.tlpDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDirectory.Location = new System.Drawing.Point(0, 0);
            this.tlpDirectory.Name = "tlpDirectory";
            this.tlpDirectory.RowCount = 4;
            this.tlpDirectory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDirectory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDirectory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpDirectory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpDirectory.Size = new System.Drawing.Size(1264, 681);
            this.tlpDirectory.TabIndex = 16;
            this.tlpDirectory.Click += new System.EventHandler(this.directoryActivity);
            // 
            // btnStaff
            // 
            this.btnStaff.BackgroundImage = global::Display_test.Properties.Resources._1;
            this.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Location = new System.Drawing.Point(85, 173);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(347, 334);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnFaculty
            // 
            this.btnFaculty.BackgroundImage = global::Display_test.Properties.Resources._2;
            this.btnFaculty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaculty.Location = new System.Drawing.Point(456, 173);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(347, 334);
            this.btnFaculty.TabIndex = 1;
            this.btnFaculty.UseVisualStyleBackColor = true;
            this.btnFaculty.Click += new System.EventHandler(this.btnFaculty_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Display_test.Properties.Resources._3;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(827, 173);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(347, 334);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tlpDirectory.SetColumnSpan(this.pictureBox2, 2);
            this.pictureBox2.Image = global::Display_test.Properties.Resources.re_sized;
            this.pictureBox2.Location = new System.Drawing.Point(3, 581);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(429, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnDirectoryBack
            // 
            this.btnDirectoryBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirectoryBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnDirectoryBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectoryBack.Location = new System.Drawing.Point(379, 206);
            this.btnDirectoryBack.MinimumSize = new System.Drawing.Size(400, 200);
            this.btnDirectoryBack.Name = "btnDirectoryBack";
            this.btnDirectoryBack.Size = new System.Drawing.Size(400, 200);
            this.btnDirectoryBack.TabIndex = 17;
            this.btnDirectoryBack.Text = "Back";
            this.btnDirectoryBack.UseVisualStyleBackColor = false;
            this.btnDirectoryBack.Click += new System.EventHandler(this.btnDirectoryBack_Click);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMove.BackColor = System.Drawing.Color.Silver;
            this.btnMove.BackgroundImage = global::Display_test.Properties.Resources.leftarrow;
            this.btnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Location = new System.Drawing.Point(1180, 500);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(50, 50);
            this.btnMove.TabIndex = 19;
            this.btnMove.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.btnDirectoryBack);
            this.Controls.Add(this.tlpDirectory);
            this.MaximumSize = new System.Drawing.Size(3840, 2160);
            this.MinimumSize = new System.Drawing.Size(960, 171);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.activity_event_activated);
            this.Deactivate += new System.EventHandler(this.activity_event_deactivated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.activity_event);
            this.ResizeEnd += new System.EventHandler(this.autoScale);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.activity_event);
            this.Click += new System.EventHandler(this.activity_event);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.activity_event);
            this.MouseHover += new System.EventHandler(this.activity_event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.activity_event);
            this.Resize += new System.EventHandler(this.autoScale);
            this.ImeModeChanged += new System.EventHandler(this.activity_event);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpTouch.ResumeLayout(false);
            this.tlpTouch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTouch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCOB)).EndInit();
            this.tlpDirectory.ResumeLayout(false);
            this.tlpDirectory.PerformLayout();
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExecEd;
        private System.Windows.Forms.Button btnGrad;
        private System.Windows.Forms.Button btnUndergrad;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Button btnCentersInstitutes;
        private System.Windows.Forms.Button btnProfDev;
        private System.Windows.Forms.PictureBox picCOB;
        private System.Windows.Forms.PictureBox picTouch;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Label lblDebug;
        private TableLayoutPanel tlpTouch;
        private Label lblWelcome;
        private TableLayoutPanel tlpDirectory;
        private Button btnStaff;
        private Button btnFaculty;
        private Button btnSearch;
        private PictureBox pictureBox2;
        private Button btnDirectoryBack;
        private Button btnMove;
    }
}

