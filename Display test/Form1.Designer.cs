
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
            this.tlpMain.Size = new System.Drawing.Size(1370, 749);
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
            this.btnHistory.Location = new System.Drawing.Point(932, 220);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(322, 308);
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
            this.btnPartners.Location = new System.Drawing.Point(522, 220);
            this.btnPartners.Name = "btnPartners";
            this.btnPartners.Size = new System.Drawing.Size(322, 308);
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
            this.btnPrograms.Location = new System.Drawing.Point(112, 220);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(322, 308);
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
            this.picFisher.Location = new System.Drawing.Point(109, 531);
            this.picFisher.Margin = new System.Windows.Forms.Padding(0);
            this.picFisher.Name = "picFisher";
            this.picFisher.Size = new System.Drawing.Size(328, 218);
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
            this.tlpTouch.Location = new System.Drawing.Point(437, 0);
            this.tlpTouch.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTouch.Name = "tlpTouch";
            this.tlpTouch.RowCount = 1;
            this.tlpTouch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTouch.Size = new System.Drawing.Size(492, 217);
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
            this.lblTouch.Size = new System.Drawing.Size(295, 217);
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
            this.picTouch.Location = new System.Drawing.Point(315, 20);
            this.picTouch.Margin = new System.Windows.Forms.Padding(20);
            this.picTouch.Name = "picTouch";
            this.picTouch.Size = new System.Drawing.Size(157, 177);
            this.picTouch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTouch.TabIndex = 5;
            this.picTouch.TabStop = false;
            // 
            // picCOB
            // 
            this.picCOB.BackColor = System.Drawing.Color.Transparent;
            this.picCOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCOB.Image = global::Display_test.Properties.Resources.CBALogo2;
            this.picCOB.Location = new System.Drawing.Point(932, 534);
            this.picCOB.Name = "picCOB";
            this.picCOB.Size = new System.Drawing.Size(322, 212);
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
        //private PictureBox pictureBox1;
    }
}

