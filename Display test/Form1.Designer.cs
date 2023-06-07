
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
            this.btnMove = new System.Windows.Forms.Button();
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
            this.tlpPremiere = new System.Windows.Forms.TableLayoutPanel();
            this.btnPremierePartner9 = new System.Windows.Forms.Button();
            this.btnPremierePartner8 = new System.Windows.Forms.Button();
            this.btnPremierePartner7 = new System.Windows.Forms.Button();
            this.btnPremierePartner6 = new System.Windows.Forms.Button();
            this.btnPremierePartner5 = new System.Windows.Forms.Button();
            this.btnPremierePartner4 = new System.Windows.Forms.Button();
            this.btnPremierePartner3 = new System.Windows.Forms.Button();
            this.btnPremierePartner2 = new System.Windows.Forms.Button();
            this.btnPremierePartner1 = new System.Windows.Forms.Button();
            this.lblPremiere = new System.Windows.Forms.Label();
            this.btnPartnerBack = new System.Windows.Forms.Button();
            this.tlpPartnerMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdvisory = new System.Windows.Forms.Button();
            this.btnPremiere = new System.Windows.Forms.Button();
            this.tlpAdvisory = new System.Windows.Forms.TableLayoutPanel();
            this.lblAdvisory = new System.Windows.Forms.Label();
            this.btnAdvisoryPartner7 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner21 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner14 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner18 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner12 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner11 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner13 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner6 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner5 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner19 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner20 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner4 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner17 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner16 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner15 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner10 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner9 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner8 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner3 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner2 = new System.Windows.Forms.Button();
            this.btnAdvisoryPartner1 = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFisher)).BeginInit();
            this.tlpTouch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTouch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCOB)).BeginInit();
            this.tlpPremiere.SuspendLayout();
            this.tlpPartnerMenu.SuspendLayout();
            this.tlpAdvisory.SuspendLayout();
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
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
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
            // tlpPremiere
            // 
            this.tlpPremiere.BackgroundImage = global::Display_test.Properties.Resources.fisherpartnerbg;
            this.tlpPremiere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpPremiere.ColumnCount = 5;
            this.tlpPremiere.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpPremiere.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpPremiere.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpPremiere.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpPremiere.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpPremiere.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPremiere.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPremiere.Controls.Add(this.btnPremierePartner9, 3, 3);
            this.tlpPremiere.Controls.Add(this.btnPremierePartner8, 2, 3);
            this.tlpPremiere.Controls.Add(this.btnPremierePartner7, 1, 3);
            this.tlpPremiere.Controls.Add(this.btnPremierePartner6, 3, 2);
            this.tlpPremiere.Controls.Add(this.btnPremierePartner5, 2, 2);
            this.tlpPremiere.Controls.Add(this.btnPremierePartner4, 1, 2);
            this.tlpPremiere.Controls.Add(this.btnPremierePartner3, 3, 1);
            this.tlpPremiere.Controls.Add(this.btnPremierePartner2, 2, 1);
            this.tlpPremiere.Controls.Add(this.btnPremierePartner1, 1, 1);
            this.tlpPremiere.Controls.Add(this.lblPremiere, 1, 0);
            this.tlpPremiere.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPremiere.Location = new System.Drawing.Point(0, 0);
            this.tlpPremiere.Name = "tlpPremiere";
            this.tlpPremiere.RowCount = 5;
            this.tlpPremiere.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPremiere.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPremiere.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPremiere.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPremiere.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpPremiere.Size = new System.Drawing.Size(1264, 681);
            this.tlpPremiere.TabIndex = 16;
            // 
            // btnPremierePartner9
            // 
            this.btnPremierePartner9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPremierePartner9.BackColor = System.Drawing.Color.White;
            this.btnPremierePartner9.BackgroundImage = global::Display_test.Properties.Resources.penske;
            this.btnPremierePartner9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPremierePartner9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPremierePartner9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremierePartner9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPremierePartner9.Location = new System.Drawing.Point(785, 479);
            this.btnPremierePartner9.Name = "btnPremierePartner9";
            this.btnPremierePartner9.Size = new System.Drawing.Size(297, 164);
            this.btnPremierePartner9.TabIndex = 46;
            this.btnPremierePartner9.TabStop = false;
            this.btnPremierePartner9.UseVisualStyleBackColor = false;
            this.btnPremierePartner9.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnPremierePartner8
            // 
            this.btnPremierePartner8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPremierePartner8.BackColor = System.Drawing.Color.White;
            this.btnPremierePartner8.BackgroundImage = global::Display_test.Properties.Resources.ritehite;
            this.btnPremierePartner8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPremierePartner8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPremierePartner8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremierePartner8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPremierePartner8.Location = new System.Drawing.Point(482, 479);
            this.btnPremierePartner8.Name = "btnPremierePartner8";
            this.btnPremierePartner8.Size = new System.Drawing.Size(297, 164);
            this.btnPremierePartner8.TabIndex = 45;
            this.btnPremierePartner8.TabStop = false;
            this.btnPremierePartner8.UseVisualStyleBackColor = false;
            this.btnPremierePartner8.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnPremierePartner7
            // 
            this.btnPremierePartner7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPremierePartner7.BackColor = System.Drawing.Color.White;
            this.btnPremierePartner7.BackgroundImage = global::Display_test.Properties.Resources.smucker;
            this.btnPremierePartner7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPremierePartner7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPremierePartner7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremierePartner7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPremierePartner7.Location = new System.Drawing.Point(179, 479);
            this.btnPremierePartner7.Name = "btnPremierePartner7";
            this.btnPremierePartner7.Size = new System.Drawing.Size(297, 164);
            this.btnPremierePartner7.TabIndex = 44;
            this.btnPremierePartner7.TabStop = false;
            this.btnPremierePartner7.UseVisualStyleBackColor = false;
            this.btnPremierePartner7.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnPremierePartner6
            // 
            this.btnPremierePartner6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPremierePartner6.BackColor = System.Drawing.Color.White;
            this.btnPremierePartner6.BackgroundImage = global::Display_test.Properties.Resources.aircontrol;
            this.btnPremierePartner6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPremierePartner6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPremierePartner6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremierePartner6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPremierePartner6.Location = new System.Drawing.Point(785, 309);
            this.btnPremierePartner6.Name = "btnPremierePartner6";
            this.btnPremierePartner6.Size = new System.Drawing.Size(297, 164);
            this.btnPremierePartner6.TabIndex = 43;
            this.btnPremierePartner6.TabStop = false;
            this.btnPremierePartner6.UseVisualStyleBackColor = false;
            this.btnPremierePartner6.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnPremierePartner5
            // 
            this.btnPremierePartner5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPremierePartner5.BackColor = System.Drawing.Color.White;
            this.btnPremierePartner5.BackgroundImage = global::Display_test.Properties.Resources.hyland_logo;
            this.btnPremierePartner5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPremierePartner5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPremierePartner5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremierePartner5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPremierePartner5.Location = new System.Drawing.Point(482, 309);
            this.btnPremierePartner5.Name = "btnPremierePartner5";
            this.btnPremierePartner5.Size = new System.Drawing.Size(297, 164);
            this.btnPremierePartner5.TabIndex = 42;
            this.btnPremierePartner5.TabStop = false;
            this.btnPremierePartner5.UseVisualStyleBackColor = false;
            this.btnPremierePartner5.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnPremierePartner4
            // 
            this.btnPremierePartner4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPremierePartner4.BackColor = System.Drawing.Color.White;
            this.btnPremierePartner4.BackgroundImage = global::Display_test.Properties.Resources.mrisoftware;
            this.btnPremierePartner4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPremierePartner4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPremierePartner4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremierePartner4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPremierePartner4.Location = new System.Drawing.Point(179, 309);
            this.btnPremierePartner4.Name = "btnPremierePartner4";
            this.btnPremierePartner4.Size = new System.Drawing.Size(297, 164);
            this.btnPremierePartner4.TabIndex = 41;
            this.btnPremierePartner4.TabStop = false;
            this.btnPremierePartner4.UseVisualStyleBackColor = false;
            this.btnPremierePartner4.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnPremierePartner3
            // 
            this.btnPremierePartner3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPremierePartner3.BackColor = System.Drawing.Color.White;
            this.btnPremierePartner3.BackgroundImage = global::Display_test.Properties.Resources.palmerholland_tp;
            this.btnPremierePartner3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPremierePartner3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPremierePartner3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremierePartner3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPremierePartner3.Location = new System.Drawing.Point(785, 139);
            this.btnPremierePartner3.Name = "btnPremierePartner3";
            this.btnPremierePartner3.Size = new System.Drawing.Size(297, 164);
            this.btnPremierePartner3.TabIndex = 40;
            this.btnPremierePartner3.TabStop = false;
            this.btnPremierePartner3.UseVisualStyleBackColor = false;
            this.btnPremierePartner3.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnPremierePartner2
            // 
            this.btnPremierePartner2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPremierePartner2.BackColor = System.Drawing.Color.White;
            this.btnPremierePartner2.BackgroundImage = global::Display_test.Properties.Resources.parker;
            this.btnPremierePartner2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPremierePartner2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPremierePartner2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremierePartner2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPremierePartner2.Location = new System.Drawing.Point(482, 139);
            this.btnPremierePartner2.Name = "btnPremierePartner2";
            this.btnPremierePartner2.Size = new System.Drawing.Size(297, 164);
            this.btnPremierePartner2.TabIndex = 39;
            this.btnPremierePartner2.TabStop = false;
            this.btnPremierePartner2.UseVisualStyleBackColor = false;
            this.btnPremierePartner2.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnPremierePartner1
            // 
            this.btnPremierePartner1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPremierePartner1.BackColor = System.Drawing.Color.White;
            this.btnPremierePartner1.BackgroundImage = global::Display_test.Properties.Resources.OhioCAT_whiteborder_tp;
            this.btnPremierePartner1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPremierePartner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPremierePartner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremierePartner1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPremierePartner1.Location = new System.Drawing.Point(179, 139);
            this.btnPremierePartner1.Name = "btnPremierePartner1";
            this.btnPremierePartner1.Size = new System.Drawing.Size(297, 164);
            this.btnPremierePartner1.TabIndex = 38;
            this.btnPremierePartner1.TabStop = false;
            this.btnPremierePartner1.UseVisualStyleBackColor = false;
            this.btnPremierePartner1.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // lblPremiere
            // 
            this.lblPremiere.BackColor = System.Drawing.Color.Transparent;
            this.tlpPremiere.SetColumnSpan(this.lblPremiere, 3);
            this.lblPremiere.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPremiere.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.lblPremiere.Location = new System.Drawing.Point(179, 0);
            this.lblPremiere.Name = "lblPremiere";
            this.lblPremiere.Size = new System.Drawing.Size(903, 136);
            this.lblPremiere.TabIndex = 0;
            this.lblPremiere.Text = "Premiere Corporate Partners";
            this.lblPremiere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tlpPartnerMenu
            // 
            this.tlpPartnerMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpPartnerMenu.BackgroundImage = global::Display_test.Properties.Resources.fishernewbg;
            this.tlpPartnerMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpPartnerMenu.ColumnCount = 5;
            this.tlpPartnerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPartnerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpPartnerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpPartnerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpPartnerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPartnerMenu.Controls.Add(this.btnAdvisory, 3, 1);
            this.tlpPartnerMenu.Controls.Add(this.btnPremiere, 1, 1);
            this.tlpPartnerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPartnerMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpPartnerMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPartnerMenu.Name = "tlpPartnerMenu";
            this.tlpPartnerMenu.RowCount = 3;
            this.tlpPartnerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tlpPartnerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tlpPartnerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tlpPartnerMenu.Size = new System.Drawing.Size(1264, 681);
            this.tlpPartnerMenu.TabIndex = 20;
            // 
            // btnAdvisory
            // 
            this.btnAdvisory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnAdvisory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdvisory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisory.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisory.Location = new System.Drawing.Point(709, 200);
            this.btnAdvisory.Name = "btnAdvisory";
            this.btnAdvisory.Size = new System.Drawing.Size(297, 280);
            this.btnAdvisory.TabIndex = 36;
            this.btnAdvisory.Text = "Advisory Level Corporate Partners";
            this.btnAdvisory.UseVisualStyleBackColor = false;
            this.btnAdvisory.Click += new System.EventHandler(this.btnAdvisory_Click);
            // 
            // btnPremiere
            // 
            this.btnPremiere.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPremiere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(104)))));
            this.btnPremiere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPremiere.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPremiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremiere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnPremiere.Location = new System.Drawing.Point(255, 200);
            this.btnPremiere.Name = "btnPremiere";
            this.btnPremiere.Size = new System.Drawing.Size(297, 280);
            this.btnPremiere.TabIndex = 35;
            this.btnPremiere.Text = "Premiere Partners";
            this.btnPremiere.UseVisualStyleBackColor = false;
            this.btnPremiere.Click += new System.EventHandler(this.btnPremiere_Click);
            // 
            // tlpAdvisory
            // 
            this.tlpAdvisory.BackgroundImage = global::Display_test.Properties.Resources.fisherpartnerbg;
            this.tlpAdvisory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpAdvisory.ColumnCount = 9;
            this.tlpAdvisory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpAdvisory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tlpAdvisory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tlpAdvisory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tlpAdvisory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tlpAdvisory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tlpAdvisory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tlpAdvisory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tlpAdvisory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpAdvisory.Controls.Add(this.lblAdvisory, 2, 0);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner7, 7, 1);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner21, 7, 3);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner14, 7, 2);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner18, 4, 3);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner12, 5, 2);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner11, 4, 2);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner13, 6, 2);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner6, 6, 1);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner5, 5, 1);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner19, 5, 3);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner20, 6, 3);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner4, 4, 1);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner17, 3, 3);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner16, 2, 3);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner15, 1, 3);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner10, 3, 2);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner9, 2, 2);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner8, 1, 2);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner3, 3, 1);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner2, 2, 1);
            this.tlpAdvisory.Controls.Add(this.btnAdvisoryPartner1, 1, 1);
            this.tlpAdvisory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAdvisory.Location = new System.Drawing.Point(0, 0);
            this.tlpAdvisory.Name = "tlpAdvisory";
            this.tlpAdvisory.RowCount = 5;
            this.tlpAdvisory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.41871F));
            this.tlpAdvisory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.0012F));
            this.tlpAdvisory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.0012F));
            this.tlpAdvisory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.0012F));
            this.tlpAdvisory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.577699F));
            this.tlpAdvisory.Size = new System.Drawing.Size(1264, 681);
            this.tlpAdvisory.TabIndex = 21;
            // 
            // lblAdvisory
            // 
            this.lblAdvisory.BackColor = System.Drawing.Color.Transparent;
            this.tlpAdvisory.SetColumnSpan(this.lblAdvisory, 5);
            this.lblAdvisory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdvisory.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.lblAdvisory.Location = new System.Drawing.Point(258, 0);
            this.lblAdvisory.Name = "lblAdvisory";
            this.lblAdvisory.Size = new System.Drawing.Size(744, 145);
            this.lblAdvisory.TabIndex = 59;
            this.lblAdvisory.Text = "Advisory Corporate Partners";
            this.lblAdvisory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdvisoryPartner7
            // 
            this.btnAdvisoryPartner7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner7.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner7.BackgroundImage = global::Display_test.Properties.Resources.hickoryharvest;
            this.btnAdvisoryPartner7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner7.Location = new System.Drawing.Point(1008, 148);
            this.btnAdvisoryPartner7.Name = "btnAdvisoryPartner7";
            this.btnAdvisoryPartner7.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner7.TabIndex = 58;
            this.btnAdvisoryPartner7.TabStop = false;
            this.btnAdvisoryPartner7.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner7.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner21
            // 
            this.btnAdvisoryPartner21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner21.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner21.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner21.Location = new System.Drawing.Point(1008, 460);
            this.btnAdvisoryPartner21.Name = "btnAdvisoryPartner21";
            this.btnAdvisoryPartner21.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner21.TabIndex = 57;
            this.btnAdvisoryPartner21.TabStop = false;
            this.btnAdvisoryPartner21.UseVisualStyleBackColor = false;
            // 
            // btnAdvisoryPartner14
            // 
            this.btnAdvisoryPartner14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner14.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner14.BackgroundImage = global::Display_test.Properties.Resources.sm;
            this.btnAdvisoryPartner14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner14.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner14.Location = new System.Drawing.Point(1008, 304);
            this.btnAdvisoryPartner14.Name = "btnAdvisoryPartner14";
            this.btnAdvisoryPartner14.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner14.TabIndex = 56;
            this.btnAdvisoryPartner14.TabStop = false;
            this.btnAdvisoryPartner14.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner14.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner18
            // 
            this.btnAdvisoryPartner18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner18.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner18.BackgroundImage = global::Display_test.Properties.Resources.svn;
            this.btnAdvisoryPartner18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner18.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner18.Location = new System.Drawing.Point(558, 460);
            this.btnAdvisoryPartner18.Name = "btnAdvisoryPartner18";
            this.btnAdvisoryPartner18.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner18.TabIndex = 55;
            this.btnAdvisoryPartner18.TabStop = false;
            this.btnAdvisoryPartner18.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner18.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner12
            // 
            this.btnAdvisoryPartner12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner12.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner12.BackgroundImage = global::Display_test.Properties.Resources.powergraphics;
            this.btnAdvisoryPartner12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner12.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner12.Location = new System.Drawing.Point(708, 304);
            this.btnAdvisoryPartner12.Name = "btnAdvisoryPartner12";
            this.btnAdvisoryPartner12.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner12.TabIndex = 54;
            this.btnAdvisoryPartner12.TabStop = false;
            this.btnAdvisoryPartner12.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner12.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner11
            // 
            this.btnAdvisoryPartner11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner11.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner11.BackgroundImage = global::Display_test.Properties.Resources.parkplace;
            this.btnAdvisoryPartner11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner11.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner11.Location = new System.Drawing.Point(558, 304);
            this.btnAdvisoryPartner11.Name = "btnAdvisoryPartner11";
            this.btnAdvisoryPartner11.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner11.TabIndex = 53;
            this.btnAdvisoryPartner11.TabStop = false;
            this.btnAdvisoryPartner11.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner11.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner13
            // 
            this.btnAdvisoryPartner13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner13.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner13.BackgroundImage = global::Display_test.Properties.Resources.rocket;
            this.btnAdvisoryPartner13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner13.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner13.Location = new System.Drawing.Point(858, 304);
            this.btnAdvisoryPartner13.Name = "btnAdvisoryPartner13";
            this.btnAdvisoryPartner13.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner13.TabIndex = 52;
            this.btnAdvisoryPartner13.TabStop = false;
            this.btnAdvisoryPartner13.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner13.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner6
            // 
            this.btnAdvisoryPartner6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner6.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner6.BackgroundImage = global::Display_test.Properties.Resources.gms;
            this.btnAdvisoryPartner6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner6.Location = new System.Drawing.Point(858, 148);
            this.btnAdvisoryPartner6.Name = "btnAdvisoryPartner6";
            this.btnAdvisoryPartner6.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner6.TabIndex = 51;
            this.btnAdvisoryPartner6.TabStop = false;
            this.btnAdvisoryPartner6.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner6.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner5
            // 
            this.btnAdvisoryPartner5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner5.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner5.BackgroundImage = global::Display_test.Properties.Resources.fedex;
            this.btnAdvisoryPartner5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner5.Location = new System.Drawing.Point(708, 148);
            this.btnAdvisoryPartner5.Name = "btnAdvisoryPartner5";
            this.btnAdvisoryPartner5.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner5.TabIndex = 50;
            this.btnAdvisoryPartner5.TabStop = false;
            this.btnAdvisoryPartner5.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner5.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner19
            // 
            this.btnAdvisoryPartner19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner19.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner19.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner19.Location = new System.Drawing.Point(708, 460);
            this.btnAdvisoryPartner19.Name = "btnAdvisoryPartner19";
            this.btnAdvisoryPartner19.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner19.TabIndex = 49;
            this.btnAdvisoryPartner19.TabStop = false;
            this.btnAdvisoryPartner19.UseVisualStyleBackColor = false;
            // 
            // btnAdvisoryPartner20
            // 
            this.btnAdvisoryPartner20.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner20.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner20.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner20.Location = new System.Drawing.Point(858, 460);
            this.btnAdvisoryPartner20.Name = "btnAdvisoryPartner20";
            this.btnAdvisoryPartner20.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner20.TabIndex = 48;
            this.btnAdvisoryPartner20.TabStop = false;
            this.btnAdvisoryPartner20.UseVisualStyleBackColor = false;
            // 
            // btnAdvisoryPartner4
            // 
            this.btnAdvisoryPartner4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner4.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner4.BackgroundImage = global::Display_test.Properties.Resources.dearing;
            this.btnAdvisoryPartner4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner4.Location = new System.Drawing.Point(558, 148);
            this.btnAdvisoryPartner4.Name = "btnAdvisoryPartner4";
            this.btnAdvisoryPartner4.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner4.TabIndex = 47;
            this.btnAdvisoryPartner4.TabStop = false;
            this.btnAdvisoryPartner4.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner4.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner17
            // 
            this.btnAdvisoryPartner17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner17.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner17.BackgroundImage = global::Display_test.Properties.Resources.trexon;
            this.btnAdvisoryPartner17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner17.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner17.Location = new System.Drawing.Point(408, 460);
            this.btnAdvisoryPartner17.Name = "btnAdvisoryPartner17";
            this.btnAdvisoryPartner17.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner17.TabIndex = 46;
            this.btnAdvisoryPartner17.TabStop = false;
            this.btnAdvisoryPartner17.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner17.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner16
            // 
            this.btnAdvisoryPartner16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner16.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner16.BackgroundImage = global::Display_test.Properties.Resources.gbs;
            this.btnAdvisoryPartner16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner16.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner16.Location = new System.Drawing.Point(258, 460);
            this.btnAdvisoryPartner16.Name = "btnAdvisoryPartner16";
            this.btnAdvisoryPartner16.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner16.TabIndex = 45;
            this.btnAdvisoryPartner16.TabStop = false;
            this.btnAdvisoryPartner16.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner16.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner15
            // 
            this.btnAdvisoryPartner15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner15.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner15.BackgroundImage = global::Display_test.Properties.Resources.suntrol;
            this.btnAdvisoryPartner15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner15.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner15.Location = new System.Drawing.Point(108, 460);
            this.btnAdvisoryPartner15.Name = "btnAdvisoryPartner15";
            this.btnAdvisoryPartner15.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner15.TabIndex = 44;
            this.btnAdvisoryPartner15.TabStop = false;
            this.btnAdvisoryPartner15.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner15.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner10
            // 
            this.btnAdvisoryPartner10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner10.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner10.BackgroundImage = global::Display_test.Properties.Resources.oec;
            this.btnAdvisoryPartner10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner10.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner10.Location = new System.Drawing.Point(408, 304);
            this.btnAdvisoryPartner10.Name = "btnAdvisoryPartner10";
            this.btnAdvisoryPartner10.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner10.TabIndex = 43;
            this.btnAdvisoryPartner10.TabStop = false;
            this.btnAdvisoryPartner10.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner10.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner9
            // 
            this.btnAdvisoryPartner9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner9.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner9.BackgroundImage = global::Display_test.Properties.Resources.merlo;
            this.btnAdvisoryPartner9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner9.Location = new System.Drawing.Point(258, 304);
            this.btnAdvisoryPartner9.Name = "btnAdvisoryPartner9";
            this.btnAdvisoryPartner9.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner9.TabIndex = 42;
            this.btnAdvisoryPartner9.TabStop = false;
            this.btnAdvisoryPartner9.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner9.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner8
            // 
            this.btnAdvisoryPartner8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner8.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner8.BackgroundImage = global::Display_test.Properties.Resources.hillcrest;
            this.btnAdvisoryPartner8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner8.Location = new System.Drawing.Point(108, 304);
            this.btnAdvisoryPartner8.Name = "btnAdvisoryPartner8";
            this.btnAdvisoryPartner8.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner8.TabIndex = 41;
            this.btnAdvisoryPartner8.TabStop = false;
            this.btnAdvisoryPartner8.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner8.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner3
            // 
            this.btnAdvisoryPartner3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner3.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner3.BackgroundImage = global::Display_test.Properties.Resources.ced;
            this.btnAdvisoryPartner3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner3.Location = new System.Drawing.Point(408, 148);
            this.btnAdvisoryPartner3.Name = "btnAdvisoryPartner3";
            this.btnAdvisoryPartner3.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner3.TabIndex = 40;
            this.btnAdvisoryPartner3.TabStop = false;
            this.btnAdvisoryPartner3.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner3.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner2
            // 
            this.btnAdvisoryPartner2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner2.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner2.BackgroundImage = global::Display_test.Properties.Resources.cintas;
            this.btnAdvisoryPartner2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner2.Location = new System.Drawing.Point(258, 148);
            this.btnAdvisoryPartner2.Name = "btnAdvisoryPartner2";
            this.btnAdvisoryPartner2.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner2.TabIndex = 39;
            this.btnAdvisoryPartner2.TabStop = false;
            this.btnAdvisoryPartner2.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner2.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // btnAdvisoryPartner1
            // 
            this.btnAdvisoryPartner1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdvisoryPartner1.BackColor = System.Drawing.Color.White;
            this.btnAdvisoryPartner1.BackgroundImage = global::Display_test.Properties.Resources.accurategroup;
            this.btnAdvisoryPartner1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvisoryPartner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdvisoryPartner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvisoryPartner1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.btnAdvisoryPartner1.Location = new System.Drawing.Point(108, 148);
            this.btnAdvisoryPartner1.Name = "btnAdvisoryPartner1";
            this.btnAdvisoryPartner1.Size = new System.Drawing.Size(144, 150);
            this.btnAdvisoryPartner1.TabIndex = 38;
            this.btnAdvisoryPartner1.TabStop = false;
            this.btnAdvisoryPartner1.UseVisualStyleBackColor = false;
            this.btnAdvisoryPartner1.Click += new System.EventHandler(this.partnerButton_Click);
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
            this.Controls.Add(this.btnPartnerBack);
            this.Controls.Add(this.tlpPartnerMenu);
            this.Controls.Add(this.tlpAdvisory);
            this.Controls.Add(this.tlpPremiere);
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
            this.tlpPremiere.ResumeLayout(false);
            this.tlpPartnerMenu.ResumeLayout(false);
            this.tlpAdvisory.ResumeLayout(false);
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
        private TableLayoutPanel tlpPremiere;
        private Label lblPremiere;
        private Button btnPremierePartner9;
        private Button btnPremierePartner8;
        private Button btnPremierePartner7;
        private Button btnPremierePartner6;
        private Button btnPremierePartner5;
        private Button btnPremierePartner4;
        private Button btnPremierePartner3;
        private Button btnPremierePartner2;
        private Button btnPremierePartner1;
        private Button btnPartnerBack;
        private Button btnMove;
        private TableLayoutPanel tlpPartnerMenu;
        private Button btnAdvisory;
        private Button btnPremiere;
        private TableLayoutPanel tlpAdvisory;
        private Button btnAdvisoryPartner17;
        private Button btnAdvisoryPartner16;
        private Button btnAdvisoryPartner15;
        private Button btnAdvisoryPartner10;
        private Button btnAdvisoryPartner9;
        private Button btnAdvisoryPartner8;
        private Button btnAdvisoryPartner3;
        private Button btnAdvisoryPartner2;
        private Button btnAdvisoryPartner1;
        private Button btnAdvisoryPartner7;
        private Button btnAdvisoryPartner21;
        private Button btnAdvisoryPartner14;
        private Button btnAdvisoryPartner18;
        private Button btnAdvisoryPartner12;
        private Button btnAdvisoryPartner11;
        private Button btnAdvisoryPartner13;
        private Button btnAdvisoryPartner6;
        private Button btnAdvisoryPartner5;
        private Button btnAdvisoryPartner19;
        private Button btnAdvisoryPartner20;
        private Button btnAdvisoryPartner4;
        private Label lblAdvisory;
        //private PictureBox pictureBox1;
    }
}

