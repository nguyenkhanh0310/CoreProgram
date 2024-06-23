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
            PKey = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPKey = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            btnConfirm = new Button();
            btnRandomKey = new Button();
            button1 = new Button();
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
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(168, 85);
            panelMenu.TabIndex = 0;
            // 
            // logoDSA
            // 
            logoDSA.Image = (Image)resources.GetObject("logoDSA.Image");
            logoDSA.Location = new Point(32, 0);
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
            panelSideBar.Location = new Point(2, 91);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(166, 442);
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
            exit.Location = new Point(-4, 335);
            exit.Name = "exit";
            exit.Size = new Size(175, 21);
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
            verifySignature.Location = new Point(5, 248);
            verifySignature.Name = "verifySignature";
            verifySignature.Size = new Size(151, 21);
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
            signText.Location = new Point(29, 158);
            signText.Name = "signText";
            signText.Size = new Size(105, 21);
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
            generateKey.Location = new Point(36, 73);
            generateKey.Name = "generateKey";
            generateKey.Size = new Size(88, 21);
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
            genKeyLabel.Location = new Point(220, 24);
            genKeyLabel.Name = "genKeyLabel";
            genKeyLabel.Size = new Size(162, 38);
            genKeyLabel.TabIndex = 2;
            genKeyLabel.Text = "TẠO KHÓA";
            // 
            // logoKey
            // 
            logoKey.Image = (Image)resources.GetObject("logoKey.Image");
            logoKey.Location = new Point(184, 24);
            logoKey.Name = "logoKey";
            logoKey.Size = new Size(39, 38);
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
            instruction.Location = new Point(175, 89);
            instruction.Name = "instruction";
            instruction.Size = new Size(654, 149);
            instruction.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(91, 110);
            label3.Name = "label3";
            label3.Size = new Size(498, 18);
            label3.TabIndex = 3;
            label3.Text = "Nhấn \"Tạo ngẫu nhiên\" để tạo các giá trị ngẫu nhiên cho tham số đầu vào";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(91, 78);
            label2.Name = "label2";
            label2.Size = new Size(204, 18);
            label2.TabIndex = 2;
            label2.Text = "Nhấn \"Xác nhận\" để tạo khóa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(91, 45);
            label1.Name = "label1";
            label1.Size = new Size(241, 18);
            label1.TabIndex = 1;
            label1.Text = "Nhập các tham số đầu vào P, Q, G";
            // 
            // txtIns1
            // 
            txtIns1.AutoSize = true;
            txtIns1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtIns1.ForeColor = SystemColors.ButtonHighlight;
            txtIns1.Location = new Point(9, 12);
            txtIns1.Name = "txtIns1";
            txtIns1.Size = new Size(90, 21);
            txtIns1.TabIndex = 0;
            txtIns1.Text = "Hướng dẫn";
            // 
            // PKey
            // 
            PKey.AutoSize = true;
            PKey.Location = new Point(175, 271);
            PKey.Name = "PKey";
            PKey.Size = new Size(80, 20);
            PKey.TabIndex = 5;
            PKey.Text = "Tham số P:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 271);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 6;
            label4.Text = "Tham số Q:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(653, 271);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 7;
            label5.Text = "Tham số G:";
            // 
            // txtPKey
            // 
            txtPKey.AcceptsReturn = true;
            txtPKey.Location = new Point(175, 304);
            txtPKey.Multiline = true;
            txtPKey.Name = "txtPKey";
            txtPKey.ScrollBars = ScrollBars.Vertical;
            txtPKey.Size = new Size(159, 27);
            txtPKey.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.Location = new Point(410, 304);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.AcceptsReturn = true;
            textBox2.Location = new Point(653, 304);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(159, 27);
            textBox2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 387);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 11;
            label6.Text = "Giá trị X:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(410, 387);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 12;
            label7.Text = "Giá trị Y:";
            // 
            // txtX
            // 
            txtX.AcceptsReturn = true;
            txtX.Location = new Point(175, 426);
            txtX.Multiline = true;
            txtX.Name = "txtX";
            txtX.ScrollBars = ScrollBars.Vertical;
            txtX.Size = new Size(159, 27);
            txtX.TabIndex = 13;
            // 
            // txtY
            // 
            txtY.AcceptsReturn = true;
            txtY.Location = new Point(410, 426);
            txtY.Multiline = true;
            txtY.Name = "txtY";
            txtY.ScrollBars = ScrollBars.Vertical;
            txtY.Size = new Size(159, 27);
            txtY.TabIndex = 14;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirm.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = SystemColors.ButtonHighlight;
            btnConfirm.Location = new Point(252, 475);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(119, 38);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnRandomKey
            // 
            btnRandomKey.BackColor = Color.DarkSlateBlue;
            btnRandomKey.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRandomKey.ForeColor = SystemColors.ButtonHighlight;
            btnRandomKey.Location = new Point(433, 475);
            btnRandomKey.Name = "btnRandomKey";
            btnRandomKey.Size = new Size(136, 38);
            btnRandomKey.TabIndex = 16;
            btnRandomKey.Text = "Tạo ngẫu nhiên";
            btnRandomKey.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(628, 475);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 17;
            button1.Text = "Xóa tất cả";
            button1.UseVisualStyleBackColor = false;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 534);
            Controls.Add(button1);
            Controls.Add(btnRandomKey);
            Controls.Add(btnConfirm);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtPKey);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(PKey);
            Controls.Add(instruction);
            Controls.Add(genKeyLabel);
            Controls.Add(panelSideBar);
            Controls.Add(panelMenu);
            Controls.Add(logoKey);
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
        private Label PKey;
        private Label label4;
        private Label label5;
        private TextBox txtPKey;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private TextBox txtX;
        private TextBox txtY;
        private Button btnConfirm;
        private Button btnRandomKey;
        private Button button1;
    }
}