namespace demoWF
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            panelMenu = new Panel();
            logoDSA = new PictureBox();
            panelSideBar = new Panel();
            exit = new LinkLabel();
            verifySignature = new LinkLabel();
            signText = new LinkLabel();
            generateKey = new LinkLabel();
            genKeyLabel = new Label();
            logoKey = new PictureBox();
            instruction = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtIns1 = new Label();
            lblGenP = new Label();
            lblGenQ = new Label();
            lblGenG = new Label();
            txtGenP = new TextBox();
            txtGenQ = new TextBox();
            txtGenG = new TextBox();
            lblGenX = new Label();
            lblGenY = new Label();
            txtGenX = new TextBox();
            txtGenY = new TextBox();
            btnRandomKey = new Button();
            btnDelete = new Button();
            lblPrivateKey = new Label();
            lblPublicKey = new Label();
            btnConfirm = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoDSA).BeginInit();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoKey).BeginInit();
            instruction.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(26, 33, 48);
            panelMenu.Controls.Add(logoDSA);
            panelMenu.Location = new Point(1, 2);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(147, 64);
            panelMenu.TabIndex = 0;
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
            // panelSideBar
            // 
            panelSideBar.BackColor = Color.FromArgb(26, 33, 48);
            panelSideBar.Controls.Add(exit);
            panelSideBar.Controls.Add(verifySignature);
            panelSideBar.Controls.Add(signText);
            panelSideBar.Controls.Add(generateKey);
            panelSideBar.Location = new Point(2, 68);
            panelSideBar.Margin = new Padding(3, 2, 3, 2);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(145, 354);
            panelSideBar.TabIndex = 1;
            // 
            // exit
            // 
            exit.ActiveLinkColor = Color.Silver;
            exit.AutoSize = true;
            exit.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = SystemColors.ButtonHighlight;
            exit.LinkBehavior = LinkBehavior.NeverUnderline;
            exit.LinkColor = Color.White;
            exit.Location = new Point(-4, 251);
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
            verifySignature.Location = new Point(4, 186);
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
            signText.Location = new Point(25, 118);
            signText.Name = "signText";
            signText.Size = new Size(85, 17);
            signText.TabIndex = 4;
            signText.TabStop = true;
            signText.Text = "Ký văn bản";
            signText.TextAlign = ContentAlignment.TopCenter;
            signText.LinkClicked += signText_LinkClicked;
            // 
            // generateKey
            // 
            generateKey.ActiveLinkColor = Color.Silver;
            generateKey.AutoSize = true;
            generateKey.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            generateKey.ForeColor = SystemColors.ButtonHighlight;
            generateKey.LinkBehavior = LinkBehavior.NeverUnderline;
            generateKey.LinkColor = SystemColors.Control;
            generateKey.Location = new Point(32, 55);
            generateKey.Name = "generateKey";
            generateKey.Size = new Size(72, 17);
            generateKey.TabIndex = 2;
            generateKey.TabStop = true;
            generateKey.Text = "Tạo khóa";
            generateKey.TextAlign = ContentAlignment.TopCenter;
            generateKey.LinkClicked += generateKey_LinkClicked;
            // 
            // genKeyLabel
            // 
            genKeyLabel.AutoSize = true;
            genKeyLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genKeyLabel.Location = new Point(192, 18);
            genKeyLabel.Name = "genKeyLabel";
            genKeyLabel.Size = new Size(127, 30);
            genKeyLabel.TabIndex = 2;
            genKeyLabel.Text = "TẠO KHÓA";
            // 
            // logoKey
            // 
            logoKey.Image = (Image)resources.GetObject("logoKey.Image");
            logoKey.Location = new Point(161, 18);
            logoKey.Margin = new Padding(3, 2, 3, 2);
            logoKey.Name = "logoKey";
            logoKey.Size = new Size(34, 28);
            logoKey.SizeMode = PictureBoxSizeMode.StretchImage;
            logoKey.TabIndex = 3;
            logoKey.TabStop = false;
            // 
            // instruction
            // 
            instruction.BackColor = Color.FromArgb(90, 114, 160);
            instruction.Controls.Add(label3);
            instruction.Controls.Add(label2);
            instruction.Controls.Add(label1);
            instruction.Controls.Add(txtIns1);
            instruction.Location = new Point(153, 67);
            instruction.Margin = new Padding(3, 2, 3, 2);
            instruction.Name = "instruction";
            instruction.Size = new Size(572, 112);
            instruction.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(80, 59);
            label3.Name = "label3";
            label3.Size = new Size(415, 14);
            label3.TabIndex = 3;
            label3.Text = "Nhấn \"Tạo ngẫu nhiên\" để tạo các giá trị ngẫu nhiên cho tham số đầu vào";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(80, 84);
            label2.Name = "label2";
            label2.Size = new Size(169, 14);
            label2.TabIndex = 2;
            label2.Text = "Nhấn \"Xác nhận\" để tạo khóa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(80, 34);
            label1.Name = "label1";
            label1.Size = new Size(196, 14);
            label1.TabIndex = 1;
            label1.Text = "Nhập các tham số đầu vào P, Q, G";
            // 
            // txtIns1
            // 
            txtIns1.AutoSize = true;
            txtIns1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtIns1.ForeColor = SystemColors.ButtonHighlight;
            txtIns1.Location = new Point(8, 9);
            txtIns1.Name = "txtIns1";
            txtIns1.Size = new Size(77, 17);
            txtIns1.TabIndex = 0;
            txtIns1.Text = "Hướng dẫn";
            // 
            // lblGenP
            // 
            lblGenP.AutoSize = true;
            lblGenP.Location = new Point(153, 203);
            lblGenP.Name = "lblGenP";
            lblGenP.Size = new Size(65, 15);
            lblGenP.TabIndex = 5;
            lblGenP.Text = "Tham số P:";
            // 
            // lblGenQ
            // 
            lblGenQ.AutoSize = true;
            lblGenQ.Location = new Point(359, 203);
            lblGenQ.Name = "lblGenQ";
            lblGenQ.Size = new Size(67, 15);
            lblGenQ.TabIndex = 6;
            lblGenQ.Text = "Tham số Q:";
            // 
            // lblGenG
            // 
            lblGenG.AutoSize = true;
            lblGenG.Location = new Point(571, 203);
            lblGenG.Name = "lblGenG";
            lblGenG.Size = new Size(66, 15);
            lblGenG.TabIndex = 7;
            lblGenG.Text = "Tham số G:";
            // 
            // txtGenP
            // 
            txtGenP.AcceptsReturn = true;
            txtGenP.Location = new Point(153, 228);
            txtGenP.Margin = new Padding(3, 2, 3, 2);
            txtGenP.Multiline = true;
            txtGenP.Name = "txtGenP";
            txtGenP.ScrollBars = ScrollBars.Vertical;
            txtGenP.Size = new Size(140, 21);
            txtGenP.TabIndex = 8;
            // 
            // txtGenQ
            // 
            txtGenQ.AcceptsReturn = true;
            txtGenQ.Location = new Point(359, 228);
            txtGenQ.Margin = new Padding(3, 2, 3, 2);
            txtGenQ.Multiline = true;
            txtGenQ.Name = "txtGenQ";
            txtGenQ.ScrollBars = ScrollBars.Vertical;
            txtGenQ.Size = new Size(140, 21);
            txtGenQ.TabIndex = 9;
            // 
            // txtGenG
            // 
            txtGenG.AcceptsReturn = true;
            txtGenG.Location = new Point(571, 228);
            txtGenG.Margin = new Padding(3, 2, 3, 2);
            txtGenG.Multiline = true;
            txtGenG.Name = "txtGenG";
            txtGenG.ScrollBars = ScrollBars.Vertical;
            txtGenG.Size = new Size(140, 21);
            txtGenG.TabIndex = 10;
            // 
            // lblGenX
            // 
            lblGenX.AutoSize = true;
            lblGenX.Location = new Point(257, 305);
            lblGenX.Name = "lblGenX";
            lblGenX.Size = new Size(51, 15);
            lblGenX.TabIndex = 11;
            lblGenX.Text = "Giá trị X:";
            // 
            // lblGenY
            // 
            lblGenY.AutoSize = true;
            lblGenY.Location = new Point(463, 305);
            lblGenY.Name = "lblGenY";
            lblGenY.Size = new Size(51, 15);
            lblGenY.TabIndex = 12;
            lblGenY.Text = "Giá trị Y:";
            // 
            // txtGenX
            // 
            txtGenX.AcceptsReturn = true;
            txtGenX.Location = new Point(257, 331);
            txtGenX.Margin = new Padding(3, 2, 3, 2);
            txtGenX.Multiline = true;
            txtGenX.Name = "txtGenX";
            txtGenX.ScrollBars = ScrollBars.Vertical;
            txtGenX.Size = new Size(140, 21);
            txtGenX.TabIndex = 13;
            // 
            // txtGenY
            // 
            txtGenY.AcceptsReturn = true;
            txtGenY.Location = new Point(463, 331);
            txtGenY.Margin = new Padding(3, 2, 3, 2);
            txtGenY.Multiline = true;
            txtGenY.Name = "txtGenY";
            txtGenY.ScrollBars = ScrollBars.Vertical;
            txtGenY.Size = new Size(140, 21);
            txtGenY.TabIndex = 14;
            // 
            // btnRandomKey
            // 
            btnRandomKey.BackColor = Color.DarkSlateBlue;
            btnRandomKey.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRandomKey.ForeColor = SystemColors.ButtonHighlight;
            btnRandomKey.Location = new Point(212, 371);
            btnRandomKey.Margin = new Padding(3, 2, 3, 2);
            btnRandomKey.Name = "btnRandomKey";
            btnRandomKey.Size = new Size(119, 28);
            btnRandomKey.TabIndex = 16;
            btnRandomKey.Text = "Tạo ngẫu nhiên";
            btnRandomKey.UseVisualStyleBackColor = false;
            btnRandomKey.Click += btnRandomKey_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(551, 371);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 28);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa tất cả";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblPrivateKey
            // 
            lblPrivateKey.AutoSize = true;
            lblPrivateKey.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrivateKey.Location = new Point(257, 275);
            lblPrivateKey.Name = "lblPrivateKey";
            lblPrivateKey.Size = new Size(102, 21);
            lblPrivateKey.TabIndex = 18;
            lblPrivateKey.Text = "Khóa bí mật";
            // 
            // lblPublicKey
            // 
            lblPublicKey.AutoSize = true;
            lblPublicKey.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublicKey.Location = new Point(463, 275);
            lblPublicKey.Name = "lblPublicKey";
            lblPublicKey.Size = new Size(128, 21);
            lblPublicKey.TabIndex = 19;
            lblPublicKey.Text = "Khóa công khai";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirm.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = SystemColors.ButtonHighlight;
            btnConfirm.Location = new Point(380, 371);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(119, 28);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 421);
            Controls.Add(lblPublicKey);
            Controls.Add(lblPrivateKey);
            Controls.Add(btnDelete);
            Controls.Add(btnRandomKey);
            Controls.Add(btnConfirm);
            Controls.Add(txtGenY);
            Controls.Add(txtGenX);
            Controls.Add(lblGenY);
            Controls.Add(lblGenX);
            Controls.Add(txtGenG);
            Controls.Add(txtGenQ);
            Controls.Add(txtGenP);
            Controls.Add(lblGenG);
            Controls.Add(lblGenQ);
            Controls.Add(lblGenP);
            Controls.Add(instruction);
            Controls.Add(genKeyLabel);
            Controls.Add(panelSideBar);
            Controls.Add(panelMenu);
            Controls.Add(logoKey);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainFrame";
            Text = "DSA";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoDSA).EndInit();
            panelSideBar.ResumeLayout(false);
            panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoKey).EndInit();
            instruction.ResumeLayout(false);
            instruction.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private PictureBox logoDSA;
        private Panel panelSideBar;
        private LinkLabel generateKey;
        private Font largerFont;
        private Font boldFont;
        private LinkLabel verifySignature;
        private LinkLabel signText;
        private LinkLabel exit;
        private Label genKeyLabel;
        private PictureBox logoKey;
        private Panel instruction;
        private Label label2;
        private Label label1;
        private Label txtIns1;
        private Label label3;
        private Label lblGenP;
        private Label lblGenQ;
        private Label lblGenG;
        private TextBox txtGenP;
        private TextBox txtGenQ;
        private TextBox txtGenG;
        private Label lblGenX;
        private Label lblGenY;
        private TextBox txtGenX;
        private TextBox txtGenY;
        private Button btnRandomKey;
        private Button btnDelete;
        private Label lblPrivateKey;
        private Label lblPublicKey;
        private Button btnConfirm;
        public TextBox TxtGenY
        {
            get { return txtGenY; }
            set { txtGenY = value; }
        }
    }
}