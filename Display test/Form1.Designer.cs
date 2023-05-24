﻿
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDebug = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnSocialMedia = new System.Windows.Forms.Button();
            this.btnExpBusiness = new System.Windows.Forms.Button();
            this.btnAlumni = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblHashtags = new System.Windows.Forms.Label();
            this.tlpTouch = new System.Windows.Forms.TableLayoutPanel();
            this.lblTouch = new System.Windows.Forms.Label();
            this.picTouch = new System.Windows.Forms.PictureBox();
            this.tlpHandles = new System.Windows.Forms.TableLayoutPanel();
            this.picIG = new System.Windows.Forms.PictureBox();
            this.picTwitter = new System.Windows.Forms.PictureBox();
            this.picFB = new System.Windows.Forms.PictureBox();
            this.lblIG = new System.Windows.Forms.Label();
            this.lblTwitter = new System.Windows.Forms.Label();
            this.lblFB = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tlpTouch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTouch)).BeginInit();
            this.tlpHandles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFB)).BeginInit();
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
            this.tlpMain.BackgroundImage = global::Display_test.Properties.Resources.marketing;
            this.tlpMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpMain.ColumnCount = 5;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpMain.Controls.Add(this.btnSocialMedia, 3, 4);
            this.tlpMain.Controls.Add(this.btnExpBusiness, 2, 4);
            this.tlpMain.Controls.Add(this.btnAlumni, 1, 4);
            this.tlpMain.Controls.Add(this.picLogo, 3, 1);
            this.tlpMain.Controls.Add(this.lblHashtags, 0, 5);
            this.tlpMain.Controls.Add(this.tlpTouch, 2, 1);
            this.tlpMain.Controls.Add(this.tlpHandles, 0, 1);
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 7;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1264, 681);
            this.tlpMain.TabIndex = 6;
            // 
            // btnSocialMedia
            // 
            this.btnSocialMedia.AutoSize = true;
            this.btnSocialMedia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSocialMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnSocialMedia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSocialMedia.BackgroundImage")));
            this.btnSocialMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSocialMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSocialMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocialMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnSocialMedia.Location = new System.Drawing.Point(810, 322);
            this.btnSocialMedia.Name = "btnSocialMedia";
            this.btnSocialMedia.Size = new System.Drawing.Size(347, 266);
            this.btnSocialMedia.TabIndex = 37;
            this.btnSocialMedia.UseVisualStyleBackColor = false;
            this.btnSocialMedia.Click += new System.EventHandler(this.btnSocialMedia_Click);
            // 
            // btnExpBusiness
            // 
            this.btnExpBusiness.AutoSize = true;
            this.btnExpBusiness.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExpBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnExpBusiness.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpBusiness.BackgroundImage")));
            this.btnExpBusiness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExpBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpBusiness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnExpBusiness.Location = new System.Drawing.Point(457, 322);
            this.btnExpBusiness.Name = "btnExpBusiness";
            this.btnExpBusiness.Size = new System.Drawing.Size(347, 266);
            this.btnExpBusiness.TabIndex = 36;
            this.btnExpBusiness.UseVisualStyleBackColor = false;
            this.btnExpBusiness.Click += new System.EventHandler(this.btnExpBusiness_Click);
            // 
            // btnAlumni
            // 
            this.btnAlumni.AutoSize = true;
            this.btnAlumni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlumni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnAlumni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlumni.BackgroundImage")));
            this.btnAlumni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlumni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlumni.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAlumni.Location = new System.Drawing.Point(104, 322);
            this.btnAlumni.Name = "btnAlumni";
            this.btnAlumni.Size = new System.Drawing.Size(347, 266);
            this.btnAlumni.TabIndex = 35;
            this.btnAlumni.UseVisualStyleBackColor = false;
            this.btnAlumni.Click += new System.EventHandler(this.btnAlumni_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpMain.SetColumnSpan(this.picLogo, 2);
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.picLogo.Image = global::Display_test.Properties.Resources.marketinglogo;
            this.picLogo.Location = new System.Drawing.Point(930, 34);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(334, 143);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 34;
            this.picLogo.TabStop = false;
            // 
            // lblHashtags
            // 
            this.lblHashtags.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.SetColumnSpan(this.lblHashtags, 5);
            this.lblHashtags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHashtags.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHashtags.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHashtags.Location = new System.Drawing.Point(3, 594);
            this.lblHashtags.Margin = new System.Windows.Forms.Padding(3);
            this.lblHashtags.Name = "lblHashtags";
            this.lblHashtags.Size = new System.Drawing.Size(1258, 41);
            this.lblHashtags.TabIndex = 33;
            this.lblHashtags.Text = "#theuniversityofakron    #zips    #uakronbusiness    #experiencebusiness    #uakr" +
    "onmarketing";
            this.lblHashtags.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tlpTouch
            // 
            this.tlpTouch.BackColor = System.Drawing.Color.Transparent;
            this.tlpTouch.ColumnCount = 2;
            this.tlpTouch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpTouch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpTouch.Controls.Add(this.lblTouch, 0, 0);
            this.tlpTouch.Controls.Add(this.picTouch, 1, 0);
            this.tlpTouch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTouch.Location = new System.Drawing.Point(454, 34);
            this.tlpTouch.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTouch.Name = "tlpTouch";
            this.tlpTouch.RowCount = 1;
            this.tlpTouch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTouch.Size = new System.Drawing.Size(353, 143);
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
            this.lblTouch.Size = new System.Drawing.Size(211, 143);
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
            this.picTouch.Location = new System.Drawing.Point(231, 20);
            this.picTouch.Margin = new System.Windows.Forms.Padding(20);
            this.picTouch.Name = "picTouch";
            this.picTouch.Size = new System.Drawing.Size(102, 103);
            this.picTouch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTouch.TabIndex = 5;
            this.picTouch.TabStop = false;
            // 
            // tlpHandles
            // 
            this.tlpHandles.BackColor = System.Drawing.Color.Transparent;
            this.tlpHandles.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpHandles, 2);
            this.tlpHandles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpHandles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tlpHandles.Controls.Add(this.picIG, 0, 0);
            this.tlpHandles.Controls.Add(this.picTwitter, 0, 1);
            this.tlpHandles.Controls.Add(this.picFB, 0, 2);
            this.tlpHandles.Controls.Add(this.lblIG, 1, 0);
            this.tlpHandles.Controls.Add(this.lblTwitter, 1, 1);
            this.tlpHandles.Controls.Add(this.lblFB, 1, 2);
            this.tlpHandles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHandles.Location = new System.Drawing.Point(0, 34);
            this.tlpHandles.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHandles.Name = "tlpHandles";
            this.tlpHandles.RowCount = 3;
            this.tlpHandles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpHandles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpHandles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpHandles.Size = new System.Drawing.Size(454, 143);
            this.tlpHandles.TabIndex = 27;
            // 
            // picIG
            // 
            this.picIG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIG.Image = global::Display_test.Properties.Resources.instagram;
            this.picIG.Location = new System.Drawing.Point(10, 10);
            this.picIG.Margin = new System.Windows.Forms.Padding(10);
            this.picIG.Name = "picIG";
            this.picIG.Size = new System.Drawing.Size(34, 27);
            this.picIG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIG.TabIndex = 0;
            this.picIG.TabStop = false;
            // 
            // picTwitter
            // 
            this.picTwitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTwitter.Image = global::Display_test.Properties.Resources.twitter;
            this.picTwitter.Location = new System.Drawing.Point(3, 50);
            this.picTwitter.Name = "picTwitter";
            this.picTwitter.Size = new System.Drawing.Size(48, 41);
            this.picTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTwitter.TabIndex = 1;
            this.picTwitter.TabStop = false;
            // 
            // picFB
            // 
            this.picFB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFB.Image = global::Display_test.Properties.Resources.facebook;
            this.picFB.Location = new System.Drawing.Point(10, 104);
            this.picFB.Margin = new System.Windows.Forms.Padding(10);
            this.picFB.Name = "picFB";
            this.picFB.Size = new System.Drawing.Size(34, 29);
            this.picFB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFB.TabIndex = 2;
            this.picFB.TabStop = false;
            // 
            // lblIG
            // 
            this.lblIG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIG.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIG.Location = new System.Drawing.Point(57, 0);
            this.lblIG.Name = "lblIG";
            this.lblIG.Size = new System.Drawing.Size(394, 47);
            this.lblIG.TabIndex = 3;
            this.lblIG.Text = "@uakronmarketing @fishersalesua @uakronama";
            this.lblIG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTwitter
            // 
            this.lblTwitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTwitter.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwitter.Location = new System.Drawing.Point(57, 47);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(394, 47);
            this.lblTwitter.TabIndex = 4;
            this.lblTwitter.Text = "@uakronmarketing @uakronbusiness @TaylorInst";
            this.lblTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFB
            // 
            this.lblFB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFB.Location = new System.Drawing.Point(57, 94);
            this.lblFB.Name = "lblFB";
            this.lblFB.Size = new System.Drawing.Size(394, 49);
            this.lblFB.TabIndex = 5;
            this.lblFB.Text = "@uakronmarketing";
            this.lblFB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tlpTouch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTouch)).EndInit();
            this.tlpHandles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFB)).EndInit();
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
        private TableLayoutPanel tlpHandles;
        private Label lblTouch;
        private Button btnHome;
        private PictureBox picIG;
        private PictureBox picTwitter;
        private PictureBox picFB;
        private Label lblIG;
        private Label lblTwitter;
        private Label lblFB;
        private PictureBox picLogo;
        private Label lblHashtags;
        private Button btnSocialMedia;
        private Button btnExpBusiness;
        private Button btnAlumni;
        private Button btnMove;
        //private PictureBox pictureBox1;
    }
}

