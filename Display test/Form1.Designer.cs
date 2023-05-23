
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
            this.btnPartnerBack = new System.Windows.Forms.Button();
            this.tlpPartners = new System.Windows.Forms.TableLayoutPanel();
            this.btnPartner9 = new System.Windows.Forms.Button();
            this.btnPartner8 = new System.Windows.Forms.Button();
            this.btnPartner7 = new System.Windows.Forms.Button();
            this.btnPartner6 = new System.Windows.Forms.Button();
            this.btnPartner5 = new System.Windows.Forms.Button();
            this.btnPartner4 = new System.Windows.Forms.Button();
            this.btnPartner3 = new System.Windows.Forms.Button();
            this.btnPartner2 = new System.Windows.Forms.Button();
            this.btnPartner1 = new System.Windows.Forms.Button();
            this.lblPartners = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnPartners = new System.Windows.Forms.Button();
            this.btnPrograms = new System.Windows.Forms.Button();
            this.picFisher = new System.Windows.Forms.PictureBox();
            this.tlpTouch = new System.Windows.Forms.TableLayoutPanel();
            this.lblTouch = new System.Windows.Forms.Label();
            this.picTouch = new System.Windows.Forms.PictureBox();
            this.picCOB = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.tlpPartners.SuspendLayout();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFisher)).BeginInit();
            this.tlpTouch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTouch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCOB)).BeginInit();
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
            // btnPartnerBack
            // 
            this.btnPartnerBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPartnerBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnPartnerBack.BackgroundImage = global::Display_test.Properties.Resources.backbutton;
            this.btnPartnerBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartnerBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartnerBack.Location = new System.Drawing.Point(485, 274);
            this.btnPartnerBack.Name = "btnPartnerBack";
            this.btnPartnerBack.Size = new System.Drawing.Size(400, 200);
            this.btnPartnerBack.TabIndex = 18;
            this.btnPartnerBack.UseVisualStyleBackColor = false;
            this.btnPartnerBack.Click += new System.EventHandler(this.btnPartnerBack_Click);
            // 
            // tlpPartners
            // 
            this.tlpPartners.BackgroundImage = global::Display_test.Properties.Resources.fisherpartnerbg;
            this.tlpPartners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpPartners.ColumnCount = 5;
            this.tlpPartners.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpPartners.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpPartners.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpPartners.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpPartners.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpPartners.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPartners.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPartners.Controls.Add(this.btnPartner9, 3, 3);
            this.tlpPartners.Controls.Add(this.btnPartner8, 2, 3);
            this.tlpPartners.Controls.Add(this.btnPartner7, 1, 3);
            this.tlpPartners.Controls.Add(this.btnPartner6, 3, 2);
            this.tlpPartners.Controls.Add(this.btnPartner5, 2, 2);
            this.tlpPartners.Controls.Add(this.btnPartner4, 1, 2);
            this.tlpPartners.Controls.Add(this.btnPartner3, 3, 1);
            this.tlpPartners.Controls.Add(this.btnPartner2, 2, 1);
            this.tlpPartners.Controls.Add(this.btnPartner1, 1, 1);
            this.tlpPartners.Controls.Add(this.lblPartners, 1, 0);
            this.tlpPartners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPartners.Location = new System.Drawing.Point(0, 0);
            this.tlpPartners.Name = "tlpPartners";
            this.tlpPartners.RowCount = 5;
            this.tlpPartners.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPartners.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPartners.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPartners.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPartners.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpPartners.Size = new System.Drawing.Size(1264, 681);
            this.tlpPartners.TabIndex = 16;
            // 
            // btnPartner9
            // 
            this.btnPartner9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPartner9.BackColor = System.Drawing.Color.White;
            this.btnPartner9.BackgroundImage = global::Display_test.Properties.Resources.penske;
            this.btnPartner9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartner9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPartner9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartner9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPartner9.Location = new System.Drawing.Point(785, 479);
            this.btnPartner9.Name = "btnPartner9";
            this.btnPartner9.Size = new System.Drawing.Size(297, 164);
            this.btnPartner9.TabIndex = 46;
            this.btnPartner9.TabStop = false;
            this.btnPartner9.UseVisualStyleBackColor = false;
            this.btnPartner9.Click += new System.EventHandler(this.btnPartner9_Click);
            // 
            // btnPartner8
            // 
            this.btnPartner8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPartner8.BackColor = System.Drawing.Color.White;
            this.btnPartner8.BackgroundImage = global::Display_test.Properties.Resources.ritehite;
            this.btnPartner8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartner8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPartner8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartner8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPartner8.Location = new System.Drawing.Point(482, 479);
            this.btnPartner8.Name = "btnPartner8";
            this.btnPartner8.Size = new System.Drawing.Size(297, 164);
            this.btnPartner8.TabIndex = 45;
            this.btnPartner8.TabStop = false;
            this.btnPartner8.UseVisualStyleBackColor = false;
            this.btnPartner8.Click += new System.EventHandler(this.btnPartner8_Click);
            // 
            // btnPartner7
            // 
            this.btnPartner7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPartner7.BackColor = System.Drawing.Color.White;
            this.btnPartner7.BackgroundImage = global::Display_test.Properties.Resources.smucker;
            this.btnPartner7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartner7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPartner7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartner7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPartner7.Location = new System.Drawing.Point(179, 479);
            this.btnPartner7.Name = "btnPartner7";
            this.btnPartner7.Size = new System.Drawing.Size(297, 164);
            this.btnPartner7.TabIndex = 44;
            this.btnPartner7.TabStop = false;
            this.btnPartner7.UseVisualStyleBackColor = false;
            this.btnPartner7.Click += new System.EventHandler(this.btnPartner7_Click);
            // 
            // btnPartner6
            // 
            this.btnPartner6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPartner6.BackColor = System.Drawing.Color.White;
            this.btnPartner6.BackgroundImage = global::Display_test.Properties.Resources.aircontrol;
            this.btnPartner6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartner6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPartner6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartner6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPartner6.Location = new System.Drawing.Point(785, 309);
            this.btnPartner6.Name = "btnPartner6";
            this.btnPartner6.Size = new System.Drawing.Size(297, 164);
            this.btnPartner6.TabIndex = 43;
            this.btnPartner6.TabStop = false;
            this.btnPartner6.UseVisualStyleBackColor = false;
            this.btnPartner6.Click += new System.EventHandler(this.btnPartner6_Click);
            // 
            // btnPartner5
            // 
            this.btnPartner5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPartner5.BackColor = System.Drawing.Color.White;
            this.btnPartner5.BackgroundImage = global::Display_test.Properties.Resources.hyland_logo;
            this.btnPartner5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartner5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPartner5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartner5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPartner5.Location = new System.Drawing.Point(482, 309);
            this.btnPartner5.Name = "btnPartner5";
            this.btnPartner5.Size = new System.Drawing.Size(297, 164);
            this.btnPartner5.TabIndex = 42;
            this.btnPartner5.TabStop = false;
            this.btnPartner5.UseVisualStyleBackColor = false;
            this.btnPartner5.Click += new System.EventHandler(this.btnPartner5_Click);
            // 
            // btnPartner4
            // 
            this.btnPartner4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPartner4.BackColor = System.Drawing.Color.White;
            this.btnPartner4.BackgroundImage = global::Display_test.Properties.Resources.mrisoftware;
            this.btnPartner4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartner4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPartner4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartner4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPartner4.Location = new System.Drawing.Point(179, 309);
            this.btnPartner4.Name = "btnPartner4";
            this.btnPartner4.Size = new System.Drawing.Size(297, 164);
            this.btnPartner4.TabIndex = 41;
            this.btnPartner4.TabStop = false;
            this.btnPartner4.UseVisualStyleBackColor = false;
            this.btnPartner4.Click += new System.EventHandler(this.btnPartner4_Click);
            // 
            // btnPartner3
            // 
            this.btnPartner3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPartner3.BackColor = System.Drawing.Color.White;
            this.btnPartner3.BackgroundImage = global::Display_test.Properties.Resources.palmerholland_tp;
            this.btnPartner3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartner3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPartner3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartner3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPartner3.Location = new System.Drawing.Point(785, 139);
            this.btnPartner3.Name = "btnPartner3";
            this.btnPartner3.Size = new System.Drawing.Size(297, 164);
            this.btnPartner3.TabIndex = 40;
            this.btnPartner3.TabStop = false;
            this.btnPartner3.UseVisualStyleBackColor = false;
            this.btnPartner3.Click += new System.EventHandler(this.btnPartner3_Click);
            // 
            // btnPartner2
            // 
            this.btnPartner2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPartner2.BackColor = System.Drawing.Color.White;
            this.btnPartner2.BackgroundImage = global::Display_test.Properties.Resources.parker;
            this.btnPartner2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartner2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPartner2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartner2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPartner2.Location = new System.Drawing.Point(482, 139);
            this.btnPartner2.Name = "btnPartner2";
            this.btnPartner2.Size = new System.Drawing.Size(297, 164);
            this.btnPartner2.TabIndex = 39;
            this.btnPartner2.TabStop = false;
            this.btnPartner2.UseVisualStyleBackColor = false;
            this.btnPartner2.Click += new System.EventHandler(this.btnPartner2_Click);
            // 
            // btnPartner1
            // 
            this.btnPartner1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPartner1.BackColor = System.Drawing.Color.White;
            this.btnPartner1.BackgroundImage = global::Display_test.Properties.Resources.OhioCAT_whiteborder_tp;
            this.btnPartner1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPartner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartner1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPartner1.Location = new System.Drawing.Point(179, 139);
            this.btnPartner1.Name = "btnPartner1";
            this.btnPartner1.Size = new System.Drawing.Size(297, 164);
            this.btnPartner1.TabIndex = 38;
            this.btnPartner1.TabStop = false;
            this.btnPartner1.UseVisualStyleBackColor = false;
            this.btnPartner1.Click += new System.EventHandler(this.btnPartner1_Click);
            // 
            // lblPartners
            // 
            this.lblPartners.BackColor = System.Drawing.Color.Transparent;
            this.tlpPartners.SetColumnSpan(this.lblPartners, 3);
            this.lblPartners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPartners.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.lblPartners.Location = new System.Drawing.Point(179, 0);
            this.lblPartners.Name = "lblPartners";
            this.lblPartners.Size = new System.Drawing.Size(903, 136);
            this.lblPartners.TabIndex = 0;
            this.lblPartners.Text = "Our Premiere Partners";
            this.lblPartners.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.BackgroundImage = global::Display_test.Properties.Resources.fishernewbg;
            this.tlpMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpMain.ColumnCount = 7;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpMain.Controls.Add(this.btnHistory, 5, 1);
            this.tlpMain.Controls.Add(this.btnPartners, 3, 1);
            this.tlpMain.Controls.Add(this.btnPrograms, 1, 1);
            this.tlpMain.Controls.Add(this.picFisher, 1, 2);
            this.tlpMain.Controls.Add(this.tlpTouch, 2, 0);
            this.tlpMain.Controls.Add(this.picCOB, 5, 2);
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tlpMain.Size = new System.Drawing.Size(1264, 681);
            this.tlpMain.TabIndex = 6;
            // 
            // btnHistory
            // 
            this.btnHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnHistory.BackgroundImage = global::Display_test.Properties.Resources.historybutton;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnHistory.Location = new System.Drawing.Point(860, 200);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(297, 280);
            this.btnHistory.TabIndex = 37;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnPartners
            // 
            this.btnPartners.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnPartners.BackgroundImage = global::Display_test.Properties.Resources.partnersbutton;
            this.btnPartners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPartners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPartners.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPartners.Location = new System.Drawing.Point(482, 200);
            this.btnPartners.Name = "btnPartners";
            this.btnPartners.Size = new System.Drawing.Size(297, 280);
            this.btnPartners.TabIndex = 36;
            this.btnPartners.UseVisualStyleBackColor = false;
            this.btnPartners.Click += new System.EventHandler(this.btnPartners_Click);
            // 
            // btnPrograms
            // 
            this.btnPrograms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnPrograms.BackgroundImage = global::Display_test.Properties.Resources.programsbutton;
            this.btnPrograms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrograms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPrograms.Location = new System.Drawing.Point(104, 200);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(297, 280);
            this.btnPrograms.TabIndex = 35;
            this.btnPrograms.UseVisualStyleBackColor = false;
            this.btnPrograms.Click += new System.EventHandler(this.btnPrograms_Click);
            // 
            // picFisher
            // 
            this.picFisher.BackColor = System.Drawing.Color.Transparent;
            this.picFisher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFisher.Image = global::Display_test.Properties.Resources.Fisher2;
            this.picFisher.Location = new System.Drawing.Point(101, 483);
            this.picFisher.Margin = new System.Windows.Forms.Padding(0);
            this.picFisher.Name = "picFisher";
            this.picFisher.Size = new System.Drawing.Size(303, 198);
            this.picFisher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFisher.TabIndex = 34;
            this.picFisher.TabStop = false;
            // 
            // tlpTouch
            // 
            this.tlpTouch.BackColor = System.Drawing.Color.Transparent;
            this.tlpTouch.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpTouch, 3);
            this.tlpTouch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpTouch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpTouch.Controls.Add(this.lblTouch, 0, 0);
            this.tlpTouch.Controls.Add(this.picTouch, 1, 0);
            this.tlpTouch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTouch.Location = new System.Drawing.Point(404, 0);
            this.tlpTouch.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTouch.Name = "tlpTouch";
            this.tlpTouch.RowCount = 1;
            this.tlpTouch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTouch.Size = new System.Drawing.Size(453, 197);
            this.tlpTouch.TabIndex = 7;
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
            this.lblTouch.Size = new System.Drawing.Size(271, 197);
            this.lblTouch.TabIndex = 30;
            this.lblTouch.Text = "Touch Screen to Interact";
            this.lblTouch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picTouch
            // 
            this.picTouch.BackColor = System.Drawing.Color.Transparent;
            this.picTouch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTouch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTouch.Image = global::Display_test.Properties.Resources.touch;
            this.picTouch.Location = new System.Drawing.Point(291, 20);
            this.picTouch.Margin = new System.Windows.Forms.Padding(20);
            this.picTouch.Name = "picTouch";
            this.picTouch.Size = new System.Drawing.Size(142, 157);
            this.picTouch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTouch.TabIndex = 5;
            this.picTouch.TabStop = false;
            // 
            // picCOB
            // 
            this.picCOB.BackColor = System.Drawing.Color.Transparent;
            this.picCOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCOB.Image = global::Display_test.Properties.Resources.CBALogo2;
            this.picCOB.Location = new System.Drawing.Point(860, 486);
            this.picCOB.Name = "picCOB";
            this.picCOB.Size = new System.Drawing.Size(297, 192);
            this.picCOB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCOB.TabIndex = 38;
            this.picCOB.TabStop = false;
            this.picCOB.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btnMove
            // 
            this.btnMove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMove.BackColor = System.Drawing.Color.Silver;
            this.btnMove.BackgroundImage = global::Display_test.Properties.Resources.homebutton;
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tlpPartners);
            this.Controls.Add(this.btnPartnerBack);
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
            this.tlpPartners.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFisher)).EndInit();
            this.tlpTouch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTouch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCOB)).EndInit();
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
        private System.Windows.Forms.PictureBox picTouch;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Label lblDebug;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tlpTouch;
        private Label lblTouch;
        private Button btnHome;
        private PictureBox picFisher;
        private Button btnHistory;
        private Button btnPartners;
        private Button btnPrograms;
        private PictureBox picCOB;
        private TableLayoutPanel tlpPartners;
        private Label lblPartners;
        private Button btnPartner9;
        private Button btnPartner8;
        private Button btnPartner7;
        private Button btnPartner6;
        private Button btnPartner5;
        private Button btnPartner4;
        private Button btnPartner3;
        private Button btnPartner2;
        private Button btnPartner1;
        private Button btnPartnerBack;
        private Button btnMove;
        //private PictureBox pictureBox1;
    }
}

