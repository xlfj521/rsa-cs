namespace RSA
{
    partial class frmRSA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRSA));
            this.btnGenP = new System.Windows.Forms.Button();
            this.nudP = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.rtxP = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.rtxQ = new System.Windows.Forms.RichTextBox();
            this.btnGenQ = new System.Windows.Forms.Button();
            this.nudQ = new System.Windows.Forms.NumericUpDown();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.rtxN = new System.Windows.Forms.RichTextBox();
            this.btnCheckN = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.rtxPhi = new System.Windows.Forms.RichTextBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.rtxE = new System.Windows.Forms.RichTextBox();
            this.btnCheckE = new System.Windows.Forms.Button();
            this.btnGenE = new System.Windows.Forms.Button();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.rtxD = new System.Windows.Forms.RichTextBox();
            this.btnCheckD = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.btnSavePrivateKey = new System.Windows.Forms.Button();
            this.btnSavePublicKey = new System.Windows.Forms.Button();
            this.btnOpenPrivateKey = new System.Windows.Forms.Button();
            this.btnOpenPublicKey = new System.Windows.Forms.Button();
            this.btnShowPrivateKey = new System.Windows.Forms.Button();
            this.btnShowPublicKey = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.rtxSource = new System.Windows.Forms.RichTextBox();
            this.btnOpenSource = new System.Windows.Forms.Button();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.rtxEncrypt = new System.Windows.Forms.RichTextBox();
            this.btnOpenEncrypt = new System.Windows.Forms.Button();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.rtxDecrypt = new System.Windows.Forms.RichTextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQ)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenP
            // 
            this.btnGenP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenP.Location = new System.Drawing.Point(229, 1);
            this.btnGenP.Name = "btnGenP";
            this.btnGenP.Size = new System.Drawing.Size(70, 23);
            this.btnGenP.TabIndex = 3;
            this.btnGenP.Text = "Sinh";
            this.btnGenP.UseVisualStyleBackColor = true;
            this.btnGenP.Click += new System.EventHandler(this.btnGenP_Click);
            // 
            // nudP
            // 
            this.nudP.Location = new System.Drawing.Point(1, 1);
            this.nudP.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudP.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudP.Name = "nudP";
            this.nudP.Size = new System.Drawing.Size(70, 23);
            this.nudP.TabIndex = 2;
            this.nudP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudP.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 611);
            this.splitContainer1.SplitterDistance = 604;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(604, 611);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.rtxP);
            this.splitContainer4.Panel1.Controls.Add(this.btnGenP);
            this.splitContainer4.Panel1.Controls.Add(this.nudP);
            this.splitContainer4.Panel1.Controls.Add(this.linkLabel1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.rtxQ);
            this.splitContainer4.Panel2.Controls.Add(this.btnGenQ);
            this.splitContainer4.Panel2.Controls.Add(this.nudQ);
            this.splitContainer4.Panel2.Controls.Add(this.linkLabel2);
            this.splitContainer4.Size = new System.Drawing.Size(604, 200);
            this.splitContainer4.SplitterDistance = 300;
            this.splitContainer4.SplitterWidth = 2;
            this.splitContainer4.TabIndex = 0;
            // 
            // rtxP
            // 
            this.rtxP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxP.Location = new System.Drawing.Point(0, 25);
            this.rtxP.Name = "rtxP";
            this.rtxP.Size = new System.Drawing.Size(298, 173);
            this.rtxP.TabIndex = 4;
            this.rtxP.Text = "3";
            this.toolTip1.SetToolTip(this.rtxP, "Nhập số nguyên tố p");
            this.rtxP.TextChanged += new System.EventHandler(this.rtxP_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.Honeydew;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(298, 25);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Khóa bí mật p";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxQ
            // 
            this.rtxQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxQ.Location = new System.Drawing.Point(0, 25);
            this.rtxQ.Name = "rtxQ";
            this.rtxQ.Size = new System.Drawing.Size(300, 173);
            this.rtxQ.TabIndex = 6;
            this.rtxQ.Text = "3";
            this.toolTip1.SetToolTip(this.rtxQ, "Nhập số nguyên tố q");
            this.rtxQ.TextChanged += new System.EventHandler(this.rtxQ_TextChanged);
            // 
            // btnGenQ
            // 
            this.btnGenQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenQ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenQ.Location = new System.Drawing.Point(231, 1);
            this.btnGenQ.Name = "btnGenQ";
            this.btnGenQ.Size = new System.Drawing.Size(70, 23);
            this.btnGenQ.TabIndex = 5;
            this.btnGenQ.Text = "Sinh";
            this.btnGenQ.UseVisualStyleBackColor = true;
            this.btnGenQ.Click += new System.EventHandler(this.btnGenQ_Click);
            // 
            // nudQ
            // 
            this.nudQ.Location = new System.Drawing.Point(0, 1);
            this.nudQ.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudQ.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudQ.Name = "nudQ";
            this.nudQ.Size = new System.Drawing.Size(75, 23);
            this.nudQ.TabIndex = 4;
            this.nudQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQ.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // linkLabel2
            // 
            this.linkLabel2.BackColor = System.Drawing.Color.Honeydew;
            this.linkLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.Location = new System.Drawing.Point(0, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(300, 25);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Khóa bí mật q";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer6);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer3.Size = new System.Drawing.Size(604, 409);
            this.splitContainer3.SplitterDistance = 200;
            this.splitContainer3.SplitterWidth = 2;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer6
            // 
            this.splitContainer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.rtxN);
            this.splitContainer6.Panel1.Controls.Add(this.btnCheckN);
            this.splitContainer6.Panel1.Controls.Add(this.btnN);
            this.splitContainer6.Panel1.Controls.Add(this.linkLabel3);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.rtxPhi);
            this.splitContainer6.Panel2.Controls.Add(this.linkLabel6);
            this.splitContainer6.Size = new System.Drawing.Size(604, 200);
            this.splitContainer6.SplitterDistance = 300;
            this.splitContainer6.SplitterWidth = 2;
            this.splitContainer6.TabIndex = 0;
            // 
            // rtxN
            // 
            this.rtxN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxN.Location = new System.Drawing.Point(0, 25);
            this.rtxN.Name = "rtxN";
            this.rtxN.Size = new System.Drawing.Size(298, 173);
            this.rtxN.TabIndex = 9;
            this.rtxN.Text = "9";
            this.toolTip1.SetToolTip(this.rtxN, "Nhập khóa công khai n");
            this.rtxN.TextChanged += new System.EventHandler(this.rtxN_TextChanged);
            // 
            // btnCheckN
            // 
            this.btnCheckN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheckN.Location = new System.Drawing.Point(-1, 1);
            this.btnCheckN.Name = "btnCheckN";
            this.btnCheckN.Size = new System.Drawing.Size(70, 23);
            this.btnCheckN.TabIndex = 3;
            this.btnCheckN.Text = "Kiểm tra";
            this.btnCheckN.UseVisualStyleBackColor = true;
            this.btnCheckN.Click += new System.EventHandler(this.btnCheckN_Click);
            // 
            // btnN
            // 
            this.btnN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnN.Location = new System.Drawing.Point(229, 1);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(70, 23);
            this.btnN.TabIndex = 3;
            this.btnN.Text = "Tính";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.BackColor = System.Drawing.Color.Honeydew;
            this.linkLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel3.Location = new System.Drawing.Point(0, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(298, 25);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Khóa công khai n=p*q";
            this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxPhi
            // 
            this.rtxPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxPhi.Location = new System.Drawing.Point(0, 25);
            this.rtxPhi.Name = "rtxPhi";
            this.rtxPhi.ReadOnly = true;
            this.rtxPhi.Size = new System.Drawing.Size(300, 173);
            this.rtxPhi.TabIndex = 12;
            this.rtxPhi.Text = "4";
            this.rtxPhi.TextChanged += new System.EventHandler(this.rtxPhi_TextChanged);
            // 
            // linkLabel6
            // 
            this.linkLabel6.BackColor = System.Drawing.Color.Honeydew;
            this.linkLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel6.Location = new System.Drawing.Point(0, 0);
            this.linkLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(300, 25);
            this.linkLabel6.TabIndex = 10;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "phi(n) = (p-1)*(q-1)";
            this.linkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer5
            // 
            this.splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.rtxE);
            this.splitContainer5.Panel1.Controls.Add(this.btnCheckE);
            this.splitContainer5.Panel1.Controls.Add(this.btnGenE);
            this.splitContainer5.Panel1.Controls.Add(this.linkLabel4);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.rtxD);
            this.splitContainer5.Panel2.Controls.Add(this.btnCheckD);
            this.splitContainer5.Panel2.Controls.Add(this.btnD);
            this.splitContainer5.Panel2.Controls.Add(this.linkLabel5);
            this.splitContainer5.Size = new System.Drawing.Size(604, 207);
            this.splitContainer5.SplitterDistance = 300;
            this.splitContainer5.SplitterWidth = 2;
            this.splitContainer5.TabIndex = 0;
            // 
            // rtxE
            // 
            this.rtxE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxE.Location = new System.Drawing.Point(0, 25);
            this.rtxE.Name = "rtxE";
            this.rtxE.Size = new System.Drawing.Size(298, 180);
            this.rtxE.TabIndex = 16;
            this.rtxE.Text = "3";
            this.toolTip1.SetToolTip(this.rtxE, "Nhập khóa công khai e");
            this.rtxE.TextChanged += new System.EventHandler(this.rtxE_TextChanged);
            // 
            // btnCheckE
            // 
            this.btnCheckE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheckE.Location = new System.Drawing.Point(-1, 1);
            this.btnCheckE.Name = "btnCheckE";
            this.btnCheckE.Size = new System.Drawing.Size(70, 23);
            this.btnCheckE.TabIndex = 3;
            this.btnCheckE.Text = "Kiểm tra";
            this.btnCheckE.UseVisualStyleBackColor = true;
            this.btnCheckE.Click += new System.EventHandler(this.btnCheckE_Click);
            // 
            // btnGenE
            // 
            this.btnGenE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenE.Location = new System.Drawing.Point(229, 1);
            this.btnGenE.Name = "btnGenE";
            this.btnGenE.Size = new System.Drawing.Size(70, 23);
            this.btnGenE.TabIndex = 15;
            this.btnGenE.Text = "Sinh";
            this.btnGenE.UseVisualStyleBackColor = true;
            this.btnGenE.Click += new System.EventHandler(this.btnGenE_Click);
            // 
            // linkLabel4
            // 
            this.linkLabel4.BackColor = System.Drawing.Color.Honeydew;
            this.linkLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel4.Location = new System.Drawing.Point(0, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(298, 25);
            this.linkLabel4.TabIndex = 14;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Khóa công khai e";
            this.linkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxD
            // 
            this.rtxD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxD.Location = new System.Drawing.Point(0, 25);
            this.rtxD.Name = "rtxD";
            this.rtxD.Size = new System.Drawing.Size(300, 180);
            this.rtxD.TabIndex = 19;
            this.rtxD.Text = "3";
            this.toolTip1.SetToolTip(this.rtxD, "\"Nhập khóa bí mật d\"");
            this.rtxD.TextChanged += new System.EventHandler(this.rtxD_TextChanged);
            // 
            // btnCheckD
            // 
            this.btnCheckD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheckD.Location = new System.Drawing.Point(-1, 1);
            this.btnCheckD.Name = "btnCheckD";
            this.btnCheckD.Size = new System.Drawing.Size(70, 23);
            this.btnCheckD.TabIndex = 3;
            this.btnCheckD.Text = "Kiểm tra";
            this.btnCheckD.UseVisualStyleBackColor = true;
            this.btnCheckD.Click += new System.EventHandler(this.btnCheckD_Click);
            // 
            // btnD
            // 
            this.btnD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnD.Location = new System.Drawing.Point(231, 1);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(70, 23);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "Tính";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // linkLabel5
            // 
            this.linkLabel5.BackColor = System.Drawing.Color.Honeydew;
            this.linkLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel5.Location = new System.Drawing.Point(0, 0);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(300, 25);
            this.linkLabel5.TabIndex = 17;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Khóa bí mật d";
            this.linkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer7
            // 
            this.splitContainer7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.IsSplitterFixed = true;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.btnSavePrivateKey);
            this.splitContainer7.Panel1.Controls.Add(this.btnSavePublicKey);
            this.splitContainer7.Panel1.Controls.Add(this.btnOpenPrivateKey);
            this.splitContainer7.Panel1.Controls.Add(this.btnOpenPublicKey);
            this.splitContainer7.Panel1.Controls.Add(this.btnShowPrivateKey);
            this.splitContainer7.Panel1.Controls.Add(this.btnShowPublicKey);
            this.splitContainer7.Panel1.Controls.Add(this.btnVer);
            this.splitContainer7.Panel1.Controls.Add(this.btnSign);
            this.splitContainer7.Panel1.Controls.Add(this.btnDecrypt);
            this.splitContainer7.Panel1.Controls.Add(this.btnEncrypt);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.splitContainer8);
            this.splitContainer7.Size = new System.Drawing.Size(402, 611);
            this.splitContainer7.SplitterDistance = 100;
            this.splitContainer7.SplitterWidth = 2;
            this.splitContainer7.TabIndex = 0;
            // 
            // btnSavePrivateKey
            // 
            this.btnSavePrivateKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavePrivateKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSavePrivateKey.Location = new System.Drawing.Point(9, 391);
            this.btnSavePrivateKey.Name = "btnSavePrivateKey";
            this.btnSavePrivateKey.Size = new System.Drawing.Size(80, 38);
            this.btnSavePrivateKey.TabIndex = 5;
            this.btnSavePrivateKey.Text = "Lưu khóa bí mật";
            this.btnSavePrivateKey.UseVisualStyleBackColor = true;
            // 
            // btnSavePublicKey
            // 
            this.btnSavePublicKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavePublicKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSavePublicKey.Location = new System.Drawing.Point(9, 346);
            this.btnSavePublicKey.Name = "btnSavePublicKey";
            this.btnSavePublicKey.Size = new System.Drawing.Size(80, 38);
            this.btnSavePublicKey.TabIndex = 5;
            this.btnSavePublicKey.Text = "Lưu khóa công khai";
            this.btnSavePublicKey.UseVisualStyleBackColor = true;
            // 
            // btnOpenPrivateKey
            // 
            this.btnOpenPrivateKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenPrivateKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenPrivateKey.Location = new System.Drawing.Point(9, 302);
            this.btnOpenPrivateKey.Name = "btnOpenPrivateKey";
            this.btnOpenPrivateKey.Size = new System.Drawing.Size(80, 38);
            this.btnOpenPrivateKey.TabIndex = 5;
            this.btnOpenPrivateKey.Text = "Mở khóa bí mật";
            this.btnOpenPrivateKey.UseVisualStyleBackColor = true;
            // 
            // btnOpenPublicKey
            // 
            this.btnOpenPublicKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenPublicKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenPublicKey.Location = new System.Drawing.Point(9, 258);
            this.btnOpenPublicKey.Name = "btnOpenPublicKey";
            this.btnOpenPublicKey.Size = new System.Drawing.Size(80, 38);
            this.btnOpenPublicKey.TabIndex = 5;
            this.btnOpenPublicKey.Text = "Mở khóa công khai";
            this.btnOpenPublicKey.UseVisualStyleBackColor = true;
            this.btnOpenPublicKey.Click += new System.EventHandler(this.btnOpenPublicKey_Click);
            // 
            // btnShowPrivateKey
            // 
            this.btnShowPrivateKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowPrivateKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowPrivateKey.Location = new System.Drawing.Point(9, 214);
            this.btnShowPrivateKey.Name = "btnShowPrivateKey";
            this.btnShowPrivateKey.Size = new System.Drawing.Size(80, 38);
            this.btnShowPrivateKey.TabIndex = 5;
            this.btnShowPrivateKey.Text = "Xem khóa bí mật";
            this.btnShowPrivateKey.UseVisualStyleBackColor = true;
            this.btnShowPrivateKey.Click += new System.EventHandler(this.btnShowPrivateKey_Click);
            // 
            // btnShowPublicKey
            // 
            this.btnShowPublicKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowPublicKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowPublicKey.Location = new System.Drawing.Point(9, 170);
            this.btnShowPublicKey.Name = "btnShowPublicKey";
            this.btnShowPublicKey.Size = new System.Drawing.Size(80, 38);
            this.btnShowPublicKey.TabIndex = 5;
            this.btnShowPublicKey.Text = "Xem khóa công khai";
            this.btnShowPublicKey.UseVisualStyleBackColor = true;
            this.btnShowPublicKey.Click += new System.EventHandler(this.btnShowPublicKey_Click);
            // 
            // btnVer
            // 
            this.btnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVer.Location = new System.Drawing.Point(9, 141);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(80, 23);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Xác thực";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnSign
            // 
            this.btnSign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSign.Location = new System.Drawing.Point(9, 112);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(80, 23);
            this.btnSign.TabIndex = 5;
            this.btnSign.Text = "Ký";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDecrypt.Location = new System.Drawing.Point(9, 83);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(80, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEncrypt.Location = new System.Drawing.Point(9, 54);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(80, 23);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Mã hóa";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // splitContainer8
            // 
            this.splitContainer8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.IsSplitterFixed = true;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.rtxSource);
            this.splitContainer8.Panel1.Controls.Add(this.btnOpenSource);
            this.splitContainer8.Panel1.Controls.Add(this.linkLabel7);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.splitContainer9);
            this.splitContainer8.Size = new System.Drawing.Size(300, 611);
            this.splitContainer8.SplitterDistance = 200;
            this.splitContainer8.SplitterWidth = 2;
            this.splitContainer8.TabIndex = 25;
            // 
            // rtxSource
            // 
            this.rtxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxSource.Location = new System.Drawing.Point(0, 25);
            this.rtxSource.Name = "rtxSource";
            this.rtxSource.Size = new System.Drawing.Size(298, 173);
            this.rtxSource.TabIndex = 8;
            this.rtxSource.Text = "3";
            this.toolTip1.SetToolTip(this.rtxSource, "Nhập bản rõ");
            // 
            // btnOpenSource
            // 
            this.btnOpenSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSource.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenSource.Location = new System.Drawing.Point(239, 1);
            this.btnOpenSource.Name = "btnOpenSource";
            this.btnOpenSource.Size = new System.Drawing.Size(60, 23);
            this.btnOpenSource.TabIndex = 5;
            this.btnOpenSource.Text = "Mở...";
            this.btnOpenSource.UseVisualStyleBackColor = true;
            this.btnOpenSource.Click += new System.EventHandler(this.btnOpenSource_Click);
            // 
            // linkLabel7
            // 
            this.linkLabel7.BackColor = System.Drawing.Color.Honeydew;
            this.linkLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel7.Location = new System.Drawing.Point(0, 0);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(298, 25);
            this.linkLabel7.TabIndex = 7;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Bản rõ";
            this.linkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer9
            // 
            this.splitContainer9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.IsSplitterFixed = true;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.rtxEncrypt);
            this.splitContainer9.Panel1.Controls.Add(this.btnOpenEncrypt);
            this.splitContainer9.Panel1.Controls.Add(this.linkLabel8);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.rtxDecrypt);
            this.splitContainer9.Panel2.Controls.Add(this.btnCompare);
            this.splitContainer9.Panel2.Controls.Add(this.linkLabel9);
            this.splitContainer9.Size = new System.Drawing.Size(300, 409);
            this.splitContainer9.SplitterDistance = 200;
            this.splitContainer9.SplitterWidth = 2;
            this.splitContainer9.TabIndex = 0;
            // 
            // rtxEncrypt
            // 
            this.rtxEncrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxEncrypt.Location = new System.Drawing.Point(0, 25);
            this.rtxEncrypt.Name = "rtxEncrypt";
            this.rtxEncrypt.Size = new System.Drawing.Size(298, 173);
            this.rtxEncrypt.TabIndex = 8;
            this.rtxEncrypt.Text = "3";
            this.toolTip1.SetToolTip(this.rtxEncrypt, "Nhập bản mã");
            // 
            // btnOpenEncrypt
            // 
            this.btnOpenEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenEncrypt.Location = new System.Drawing.Point(239, 1);
            this.btnOpenEncrypt.Name = "btnOpenEncrypt";
            this.btnOpenEncrypt.Size = new System.Drawing.Size(60, 23);
            this.btnOpenEncrypt.TabIndex = 5;
            this.btnOpenEncrypt.Text = "Mở...";
            this.btnOpenEncrypt.UseVisualStyleBackColor = true;
            this.btnOpenEncrypt.Click += new System.EventHandler(this.btnOpenEncrypt_Click);
            // 
            // linkLabel8
            // 
            this.linkLabel8.BackColor = System.Drawing.Color.Honeydew;
            this.linkLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel8.Location = new System.Drawing.Point(0, 0);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(298, 25);
            this.linkLabel8.TabIndex = 7;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Bản mã";
            this.linkLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxDecrypt
            // 
            this.rtxDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxDecrypt.Location = new System.Drawing.Point(0, 25);
            this.rtxDecrypt.Name = "rtxDecrypt";
            this.rtxDecrypt.ReadOnly = true;
            this.rtxDecrypt.Size = new System.Drawing.Size(298, 180);
            this.rtxDecrypt.TabIndex = 8;
            this.rtxDecrypt.Text = "3";
            this.toolTip1.SetToolTip(this.rtxDecrypt, "Bản giải mã");
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCompare.Location = new System.Drawing.Point(239, 1);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(60, 23);
            this.btnCompare.TabIndex = 5;
            this.btnCompare.Text = "So sánh";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // linkLabel9
            // 
            this.linkLabel9.BackColor = System.Drawing.Color.Honeydew;
            this.linkLabel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel9.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel9.Location = new System.Drawing.Point(0, 0);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(298, 25);
            this.linkLabel9.TabIndex = 7;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "Bản giải mã";
            this.linkLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            this.toolTip1.AutoPopDelay = 1250;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 50;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1008, 611);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.frmRSA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQ)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            this.splitContainer8.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            this.splitContainer9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenP;
        private System.Windows.Forms.NumericUpDown nudP;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Button btnGenQ;
        private System.Windows.Forms.NumericUpDown nudQ;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Button btnGenE;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox rtxPhi;
        private System.Windows.Forms.RichTextBox rtxP;
        private System.Windows.Forms.RichTextBox rtxQ;
        private System.Windows.Forms.RichTextBox rtxN;
        private System.Windows.Forms.RichTextBox rtxE;
        private System.Windows.Forms.RichTextBox rtxD;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnCheckE;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnCheckD;
        private System.Windows.Forms.Button btnCheckN;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.RichTextBox rtxSource;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.RichTextBox rtxEncrypt;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.RichTextBox rtxDecrypt;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnOpenPublicKey;
        private System.Windows.Forms.Button btnShowPrivateKey;
        private System.Windows.Forms.Button btnShowPublicKey;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnOpenPrivateKey;
        private System.Windows.Forms.Button btnSavePrivateKey;
        private System.Windows.Forms.Button btnSavePublicKey;
        private System.Windows.Forms.Button btnOpenSource;
        private System.Windows.Forms.Button btnOpenEncrypt;
        private System.Windows.Forms.Button btnCompare;
    }
}