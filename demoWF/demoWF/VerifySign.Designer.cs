namespace demoWF
{
    partial class VerifySign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifySign));
            logoDSA = new PictureBox();
            panelMenu = new Panel();
            generateKey = new LinkLabel();
            panelSideBar = new Panel();
            exit = new LinkLabel();
            verifySignature = new LinkLabel();
            signText = new LinkLabel();
            genKeyLabel = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lblConfirmDoc = new Label();
            txtConfirmDoc = new RichTextBox();
            lblHashResultC = new Label();
            txtHashConfirmC = new RichTextBox();
            txtConfirmP = new RichTextBox();
            lblConfirmP = new Label();
            txtConfirmQ = new RichTextBox();
            lblConfirmQ = new Label();
            txtConfirmG = new RichTextBox();
            lblConfirmG = new Label();
            txtConfirmY = new RichTextBox();
            lblConfirmY = new Label();
            btnCheck = new Button();
            btnUpDocCon = new Button();
            btnUpSignCon = new Button();
            txtSignC = new Label();
            txtConfirmS = new RichTextBox();
            lblConfirmS = new Label();
            txtConfirmR = new RichTextBox();
            lblConfirmR = new Label();
            ((System.ComponentModel.ISupportInitialize)logoDSA).BeginInit();
            panelMenu.SuspendLayout();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // logoDSA
            // 
            logoDSA.Image = (Image)resources.GetObject("logoDSA.Image");
            logoDSA.Location = new Point(28, 0);
            logoDSA.Margin = new Padding(3, 2, 3, 2);
            logoDSA.Name = "logoDSA";
            logoDSA.Size = new Size(100, 100);
            logoDSA.SizeMode = PictureBoxSizeMode.AutoSize;
            logoDSA.TabIndex = 1;
            logoDSA.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelMenu.BackColor = Color.FromArgb(26, 33, 48);
            panelMenu.Controls.Add(logoDSA);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(155, 265);
            panelMenu.TabIndex = 4;
            // 
            // generateKey
            // 
            generateKey.ActiveLinkColor = Color.Silver;
            generateKey.AutoSize = true;
            generateKey.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            generateKey.ForeColor = SystemColors.ButtonHighlight;
            generateKey.LinkBehavior = LinkBehavior.NeverUnderline;
            generateKey.LinkColor = Color.White;
            generateKey.Location = new Point(44, 51);
            generateKey.Name = "generateKey";
            generateKey.Size = new Size(72, 17);
            generateKey.TabIndex = 2;
            generateKey.TabStop = true;
            generateKey.Text = "Tạo khóa";
            generateKey.TextAlign = ContentAlignment.TopCenter;
            generateKey.LinkClicked += generateKey_LinkClicked;
            // 
            // panelSideBar
            // 
            panelSideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelSideBar.BackColor = Color.FromArgb(26, 33, 48);
            panelSideBar.Controls.Add(exit);
            panelSideBar.Controls.Add(verifySignature);
            panelSideBar.Controls.Add(signText);
            panelSideBar.Controls.Add(generateKey);
            panelSideBar.Location = new Point(0, 66);
            panelSideBar.Margin = new Padding(3, 2, 3, 2);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(155, 472);
            panelSideBar.TabIndex = 5;
            // 
            // exit
            // 
            exit.ActiveLinkColor = Color.Silver;
            exit.AutoSize = true;
            exit.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = SystemColors.ButtonHighlight;
            exit.LinkBehavior = LinkBehavior.NeverUnderline;
            exit.LinkColor = Color.White;
            exit.Location = new Point(9, 246);
            exit.Name = "exit";
            exit.Size = new Size(143, 17);
            exit.TabIndex = 7;
            exit.TabStop = true;
            exit.Text = "Thoát chương trình";
            exit.TextAlign = ContentAlignment.TopCenter;
            exit.LinkClicked += exit_LinkClicked;
            // 
            // verifySignature
            // 
            verifySignature.ActiveLinkColor = Color.Silver;
            verifySignature.AutoSize = true;
            verifySignature.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verifySignature.ForeColor = SystemColors.ButtonHighlight;
            verifySignature.LinkBehavior = LinkBehavior.NeverUnderline;
            verifySignature.LinkColor = Color.White;
            verifySignature.Location = new Point(19, 181);
            verifySignature.Name = "verifySignature";
            verifySignature.Size = new Size(122, 17);
            verifySignature.TabIndex = 5;
            verifySignature.TabStop = true;
            verifySignature.Text = "Xác nhận chữ ký";
            verifySignature.TextAlign = ContentAlignment.TopCenter;
            verifySignature.LinkClicked += verifySignature_LinkClicked;
            // 
            // signText
            // 
            signText.ActiveLinkColor = Color.Silver;
            signText.AutoSize = true;
            signText.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signText.ForeColor = SystemColors.ButtonHighlight;
            signText.LinkBehavior = LinkBehavior.NeverUnderline;
            signText.LinkColor = Color.White;
            signText.Location = new Point(38, 116);
            signText.Name = "signText";
            signText.Size = new Size(85, 17);
            signText.TabIndex = 4;
            signText.TabStop = true;
            signText.Text = "Ký văn bản";
            signText.TextAlign = ContentAlignment.TopCenter;
            signText.LinkClicked += signText_LinkClicked;
            // 
            // genKeyLabel
            // 
            genKeyLabel.AutoSize = true;
            genKeyLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genKeyLabel.Location = new Point(215, 20);
            genKeyLabel.Name = "genKeyLabel";
            genKeyLabel.Size = new Size(215, 30);
            genKeyLabel.TabIndex = 6;
            genKeyLabel.Text = "XÁC NHẬN CHỮ KÝ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 20);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(174, 66);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 131);
            panel1.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.White;
            label8.Location = new Point(19, 99);
            label8.Name = "label8";
            label8.Size = new Size(309, 18);
            label8.TabIndex = 3;
            label8.Text = "Nhấn \"Tải văn bản\" để tải văn bản có sẵn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.White;
            label7.Location = new Point(19, 68);
            label7.Name = "label7";
            label7.Size = new Size(278, 18);
            label7.TabIndex = 2;
            label7.Text = "Nhấn \"Kiểm tra\" để kiểm tra văn bản";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.White;
            label6.Location = new Point(19, 41);
            label6.Name = "label6";
            label6.Size = new Size(209, 18);
            label6.TabIndex = 1;
            label6.Text = "Nhập văn bản cần xác nhận";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(103, 19);
            label5.TabIndex = 0;
            label5.Text = "Hướng dẫn:";
            // 
            // lblConfirmDoc
            // 
            lblConfirmDoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblConfirmDoc.AutoSize = true;
            lblConfirmDoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmDoc.Location = new Point(527, 61);
            lblConfirmDoc.Name = "lblConfirmDoc";
            lblConfirmDoc.Size = new Size(126, 15);
            lblConfirmDoc.TabIndex = 16;
            lblConfirmDoc.Text = "Văn bản cần xác nhận:";
            // 
            // txtConfirmDoc
            // 
            txtConfirmDoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmDoc.Font = new Font("Segoe UI", 12F);
            txtConfirmDoc.Location = new Point(527, 83);
            txtConfirmDoc.Margin = new Padding(3, 2, 3, 2);
            txtConfirmDoc.Name = "txtConfirmDoc";
            txtConfirmDoc.Size = new Size(306, 98);
            txtConfirmDoc.TabIndex = 17;
            txtConfirmDoc.Text = "";
            // 
            // lblHashResultC
            // 
            lblHashResultC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHashResultC.AutoSize = true;
            lblHashResultC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHashResultC.Location = new Point(527, 201);
            lblHashResultC.Name = "lblHashResultC";
            lblHashResultC.Size = new Size(104, 15);
            lblHashResultC.TabIndex = 18;
            lblHashResultC.Text = "Kết quả hàm băm:";
            // 
            // txtHashConfirmC
            // 
            txtHashConfirmC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHashConfirmC.Font = new Font("Segoe UI", 12F);
            txtHashConfirmC.Location = new Point(527, 218);
            txtHashConfirmC.Margin = new Padding(3, 2, 3, 2);
            txtHashConfirmC.Name = "txtHashConfirmC";
            txtHashConfirmC.Size = new Size(306, 65);
            txtHashConfirmC.TabIndex = 19;
            txtHashConfirmC.Text = "";
            // 
            // txtConfirmP
            // 
            txtConfirmP.Font = new Font("Segoe UI", 12F);
            txtConfirmP.Location = new Point(204, 216);
            txtConfirmP.Margin = new Padding(3, 2, 3, 2);
            txtConfirmP.Name = "txtConfirmP";
            txtConfirmP.ReadOnly = true;
            txtConfirmP.Size = new Size(226, 51);
            txtConfirmP.TabIndex = 21;
            txtConfirmP.Text = "";
            // 
            // lblConfirmP
            // 
            lblConfirmP.AutoSize = true;
            lblConfirmP.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblConfirmP.Location = new Point(172, 224);
            lblConfirmP.Name = "lblConfirmP";
            lblConfirmP.Size = new Size(26, 30);
            lblConfirmP.TabIndex = 20;
            lblConfirmP.Text = "P";
            // 
            // txtConfirmQ
            // 
            txtConfirmQ.Font = new Font("Segoe UI", 12F);
            txtConfirmQ.Location = new Point(204, 285);
            txtConfirmQ.Margin = new Padding(3, 2, 3, 2);
            txtConfirmQ.Name = "txtConfirmQ";
            txtConfirmQ.ReadOnly = true;
            txtConfirmQ.Size = new Size(226, 51);
            txtConfirmQ.TabIndex = 23;
            txtConfirmQ.Text = "";
            // 
            // lblConfirmQ
            // 
            lblConfirmQ.AutoSize = true;
            lblConfirmQ.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblConfirmQ.Location = new Point(171, 292);
            lblConfirmQ.Name = "lblConfirmQ";
            lblConfirmQ.Size = new Size(29, 30);
            lblConfirmQ.TabIndex = 22;
            lblConfirmQ.Text = "Q";
            // 
            // txtConfirmG
            // 
            txtConfirmG.Font = new Font("Segoe UI", 12F);
            txtConfirmG.Location = new Point(204, 354);
            txtConfirmG.Margin = new Padding(3, 2, 3, 2);
            txtConfirmG.Name = "txtConfirmG";
            txtConfirmG.ReadOnly = true;
            txtConfirmG.Size = new Size(226, 51);
            txtConfirmG.TabIndex = 25;
            txtConfirmG.Text = "";
            // 
            // lblConfirmG
            // 
            lblConfirmG.AutoSize = true;
            lblConfirmG.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblConfirmG.Location = new Point(171, 360);
            lblConfirmG.Name = "lblConfirmG";
            lblConfirmG.Size = new Size(28, 30);
            lblConfirmG.TabIndex = 24;
            lblConfirmG.Text = "G";
            // 
            // txtConfirmY
            // 
            txtConfirmY.Font = new Font("Segoe UI", 12F);
            txtConfirmY.Location = new Point(204, 423);
            txtConfirmY.Margin = new Padding(3, 2, 3, 2);
            txtConfirmY.Name = "txtConfirmY";
            txtConfirmY.ReadOnly = true;
            txtConfirmY.Size = new Size(226, 51);
            txtConfirmY.TabIndex = 27;
            txtConfirmY.Text = "";
            // 
            // lblConfirmY
            // 
            lblConfirmY.AutoSize = true;
            lblConfirmY.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblConfirmY.Location = new Point(172, 428);
            lblConfirmY.Name = "lblConfirmY";
            lblConfirmY.Size = new Size(26, 30);
            lblConfirmY.TabIndex = 26;
            lblConfirmY.Text = "Y";
            // 
            // btnCheck
            // 
            btnCheck.Anchor = AnchorStyles.Bottom;
            btnCheck.BackColor = Color.Firebrick;
            btnCheck.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(278, 488);
            btnCheck.Margin = new Padding(3, 2, 3, 2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(124, 41);
            btnCheck.TabIndex = 34;
            btnCheck.Text = "Kiểm tra";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnUpDocCon
            // 
            btnUpDocCon.Anchor = AnchorStyles.Bottom;
            btnUpDocCon.BackColor = Color.DarkOliveGreen;
            btnUpDocCon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpDocCon.ForeColor = Color.White;
            btnUpDocCon.Location = new Point(442, 488);
            btnUpDocCon.Margin = new Padding(3, 2, 3, 2);
            btnUpDocCon.Name = "btnUpDocCon";
            btnUpDocCon.Size = new Size(124, 41);
            btnUpDocCon.TabIndex = 35;
            btnUpDocCon.Text = "Tải văn bản";
            btnUpDocCon.UseVisualStyleBackColor = false;
            btnUpDocCon.Click += btnUpDocCon_Click;
            // 
            // btnUpSignCon
            // 
            btnUpSignCon.Anchor = AnchorStyles.Bottom;
            btnUpSignCon.BackColor = Color.DarkOrange;
            btnUpSignCon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpSignCon.ForeColor = Color.White;
            btnUpSignCon.Location = new Point(606, 488);
            btnUpSignCon.Margin = new Padding(3, 2, 3, 2);
            btnUpSignCon.Name = "btnUpSignCon";
            btnUpSignCon.Size = new Size(124, 41);
            btnUpSignCon.TabIndex = 36;
            btnUpSignCon.Text = "Tải chữ ký";
            btnUpSignCon.UseVisualStyleBackColor = false;
            btnUpSignCon.Click += btnUpSignCon_Click;
            // 
            // txtSignC
            // 
            txtSignC.AutoSize = true;
            txtSignC.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSignC.Location = new Point(477, 316);
            txtSignC.Name = "txtSignC";
            txtSignC.Size = new Size(57, 20);
            txtSignC.TabIndex = 41;
            txtSignC.Text = "Chữ ký";
            // 
            // txtConfirmS
            // 
            txtConfirmS.Font = new Font("Segoe UI", 12F);
            txtConfirmS.Location = new Point(675, 354);
            txtConfirmS.Margin = new Padding(3, 2, 3, 2);
            txtConfirmS.Name = "txtConfirmS";
            txtConfirmS.Size = new Size(158, 51);
            txtConfirmS.TabIndex = 40;
            txtConfirmS.Text = "";
            // 
            // lblConfirmS
            // 
            lblConfirmS.AutoSize = true;
            lblConfirmS.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmS.Location = new Point(675, 336);
            lblConfirmS.Name = "lblConfirmS";
            lblConfirmS.Size = new Size(132, 15);
            lblConfirmS.TabIndex = 39;
            lblConfirmS.Text = "Thành phần thứ hai (S):";
            // 
            // txtConfirmR
            // 
            txtConfirmR.Font = new Font("Segoe UI", 12F);
            txtConfirmR.Location = new Point(477, 354);
            txtConfirmR.Margin = new Padding(3, 2, 3, 2);
            txtConfirmR.Name = "txtConfirmR";
            txtConfirmR.Size = new Size(167, 51);
            txtConfirmR.TabIndex = 38;
            txtConfirmR.Text = "";
            // 
            // lblConfirmR
            // 
            lblConfirmR.AutoSize = true;
            lblConfirmR.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmR.Location = new Point(477, 336);
            lblConfirmR.Name = "lblConfirmR";
            lblConfirmR.Size = new Size(140, 15);
            lblConfirmR.TabIndex = 37;
            lblConfirmR.Text = "Thành phần thứ nhất (R):";
            // 
            // VerifySign
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 540);
            Controls.Add(txtSignC);
            Controls.Add(txtConfirmS);
            Controls.Add(lblConfirmS);
            Controls.Add(txtConfirmR);
            Controls.Add(lblConfirmR);
            Controls.Add(btnUpSignCon);
            Controls.Add(btnUpDocCon);
            Controls.Add(btnCheck);
            Controls.Add(txtConfirmY);
            Controls.Add(lblConfirmY);
            Controls.Add(txtConfirmG);
            Controls.Add(lblConfirmG);
            Controls.Add(txtConfirmQ);
            Controls.Add(lblConfirmQ);
            Controls.Add(txtConfirmP);
            Controls.Add(lblConfirmP);
            Controls.Add(txtHashConfirmC);
            Controls.Add(lblHashResultC);
            Controls.Add(txtConfirmDoc);
            Controls.Add(lblConfirmDoc);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(genKeyLabel);
            Controls.Add(panelSideBar);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(880, 579);
            Name = "VerifySign";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerifySign";
            ((System.ComponentModel.ISupportInitialize)logoDSA).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelSideBar.ResumeLayout(false);
            panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoDSA;
        private Panel panelMenu;
        private LinkLabel generateKey;
        private Panel panelSideBar;
        private LinkLabel exit;
        private LinkLabel verifySignature;
        private LinkLabel signText;
        private Label genKeyLabel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblConfirmDoc;
        private RichTextBox txtConfirmDoc;
        private Label lblHashResultC;
        private RichTextBox txtHashConfirmC;
        private RichTextBox txtConfirmP;
        private Label lblConfirmP;
        private RichTextBox txtConfirmQ;
        private Label lblConfirmQ;
        private RichTextBox txtConfirmG;
        private Label lblConfirmG;
        private RichTextBox txtConfirmY;
        private Label lblConfirmY;
        private Button btnCheck;
        private Button btnUpDocCon;
        private Button btnUpSignCon;
        private Label txtSignC;
        private RichTextBox txtConfirmS;
        private Label lblConfirmS;
        private RichTextBox txtConfirmR;
        private Label lblConfirmR;
        public RichTextBox TxtConfirmP
        {
            get { return txtConfirmP; }
            set { txtConfirmP = value; }
        }
        public RichTextBox TxtConfirmQ
        {
            get { return txtConfirmQ; }
            set { txtConfirmQ = value; }
        }
        public RichTextBox TxtConfirmG
        {
            get { return txtConfirmG; }
            set { txtConfirmG = value; }
        }
        public RichTextBox TxtConfirmY
        {
            get { return txtConfirmY; }
            set { txtConfirmY = value; }
        }
        public RichTextBox TxtConfirmR
        {
            get { return txtConfirmR; }
            set { txtConfirmR = value; }
        }
        public RichTextBox TxtConfirmS
        {
            get { return txtConfirmS; }
            set { txtConfirmS = value; }
        }
    }
}