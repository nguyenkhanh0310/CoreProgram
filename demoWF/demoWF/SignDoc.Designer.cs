namespace demoWF
{
    partial class SignDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignDoc));
            logoDSA = new PictureBox();
            panelMenu = new Panel();
            exit = new LinkLabel();
            verifySignature = new LinkLabel();
            signText = new LinkLabel();
            generateKey = new LinkLabel();
            panelSideBar = new Panel();
            pictureBox1 = new PictureBox();
            genKeyLabel = new Label();
            label1 = new Label();
            txtSignDoc = new RichTextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            firstEle = new RichTextBox();
            label4 = new Label();
            richTextBox2 = new RichTextBox();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label10 = new Label();
            txtP = new RichTextBox();
            txtQ = new RichTextBox();
            label11 = new Label();
            txtG = new RichTextBox();
            label12 = new Label();
            txtX = new RichTextBox();
            label13 = new Label();
            txtY = new RichTextBox();
            label14 = new Label();
            btnCreate = new Button();
            btnTrans = new Button();
            btnSave = new Button();
            btnDoc = new Button();
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
            panelMenu.BackColor = Color.FromArgb(26, 33, 48);
            panelMenu.Controls.Add(logoDSA);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(145, 64);
            panelMenu.TabIndex = 2;
            // 
            // exit
            // 
            exit.ActiveLinkColor = Color.Silver;
            exit.AutoSize = true;
            exit.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = SystemColors.ButtonHighlight;
            exit.LinkBehavior = LinkBehavior.NeverUnderline;
            exit.LinkColor = Color.White;
            exit.Location = new Point(-7, 250);
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
            verifySignature.Location = new Point(1, 184);
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
            signText.Location = new Point(22, 117);
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
            generateKey.Location = new Point(28, 53);
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
            panelSideBar.BackColor = Color.FromArgb(26, 33, 48);
            panelSideBar.Controls.Add(exit);
            panelSideBar.Controls.Add(verifySignature);
            panelSideBar.Controls.Add(signText);
            panelSideBar.Controls.Add(generateKey);
            panelSideBar.Location = new Point(0, 65);
            panelSideBar.Margin = new Padding(3, 2, 3, 2);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(145, 332);
            panelSideBar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(171, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // genKeyLabel
            // 
            genKeyLabel.AutoSize = true;
            genKeyLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genKeyLabel.Location = new Point(212, 18);
            genKeyLabel.Name = "genKeyLabel";
            genKeyLabel.Size = new Size(144, 30);
            genKeyLabel.TabIndex = 5;
            genKeyLabel.Text = "KÝ VĂN BẢN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 65);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 6;
            label1.Text = "Văn bản cần ký:";
            // 
            // txtSignDoc
            // 
            txtSignDoc.Location = new Point(175, 92);
            txtSignDoc.Margin = new Padding(3, 2, 3, 2);
            txtSignDoc.Name = "txtSignDoc";
            txtSignDoc.Size = new Size(356, 70);
            txtSignDoc.TabIndex = 7;
            txtSignDoc.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 182);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 8;
            label2.Text = "Kết quả hàm băm:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(175, 208);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(356, 70);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(175, 302);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 10;
            label3.Text = "Thành phần thứ nhất (R):";
            // 
            // firstEle
            // 
            firstEle.Location = new Point(175, 320);
            firstEle.Margin = new Padding(3, 2, 3, 2);
            firstEle.Name = "firstEle";
            firstEle.Size = new Size(167, 28);
            firstEle.TabIndex = 11;
            firstEle.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(373, 302);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 12;
            label4.Text = "Thành phần thứ hai (S):";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(373, 320);
            richTextBox2.Margin = new Padding(3, 2, 3, 2);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(158, 28);
            richTextBox2.TabIndex = 13;
            richTextBox2.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(549, 16);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 145);
            panel1.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = Color.White;
            label9.Location = new Point(29, 118);
            label9.Name = "label9";
            label9.Size = new Size(150, 13);
            label9.TabIndex = 4;
            label9.Text = "Nhấn \"Lưu\" để lưu chữ ký";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 89);
            label8.Name = "label8";
            label8.Size = new Size(229, 13);
            label8.TabIndex = 3;
            label8.Text = "Nhấn \"Chuyển tiếp\" để xác nhận chữ ký";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 58);
            label7.Name = "label7";
            label7.Size = new Size(192, 13);
            label7.TabIndex = 2;
            label7.Text = "Nhấn \"Tạo chữ ký\" để tạo chữ ký";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 31);
            label6.Name = "label6";
            label6.Size = new Size(123, 13);
            label6.TabIndex = 1;
            label6.Text = "Nhập văn bản cần ký";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(71, 13);
            label5.TabIndex = 0;
            label5.Text = "Hướng dẫn:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(549, 190);
            label10.Name = "label10";
            label10.Size = new Size(18, 20);
            label10.TabIndex = 15;
            label10.Text = "P";
            // 
            // txtP
            // 
            txtP.Location = new Point(588, 182);
            txtP.Margin = new Padding(3, 2, 3, 2);
            txtP.Name = "txtP";
            txtP.Size = new Size(226, 28);
            txtP.TabIndex = 16;
            txtP.Text = "";
            // 
            // txtQ
            // 
            txtQ.Location = new Point(588, 214);
            txtQ.Margin = new Padding(3, 2, 3, 2);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(226, 28);
            txtQ.TabIndex = 18;
            txtQ.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(549, 222);
            label11.Name = "label11";
            label11.Size = new Size(20, 20);
            label11.TabIndex = 17;
            label11.Text = "Q";
            // 
            // txtG
            // 
            txtG.Location = new Point(588, 248);
            txtG.Margin = new Padding(3, 2, 3, 2);
            txtG.Name = "txtG";
            txtG.Size = new Size(226, 28);
            txtG.TabIndex = 20;
            txtG.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(551, 256);
            label12.Name = "label12";
            label12.Size = new Size(20, 20);
            label12.TabIndex = 19;
            label12.Text = "G";
            // 
            // txtX
            // 
            txtX.Location = new Point(588, 283);
            txtX.Margin = new Padding(3, 2, 3, 2);
            txtX.Name = "txtX";
            txtX.Size = new Size(226, 28);
            txtX.TabIndex = 22;
            txtX.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(549, 291);
            label13.Name = "label13";
            label13.Size = new Size(19, 20);
            label13.TabIndex = 21;
            label13.Text = "X";
            // 
            // txtY
            // 
            txtY.Location = new Point(588, 322);
            txtY.Margin = new Padding(3, 2, 3, 2);
            txtY.Name = "txtY";
            txtY.Size = new Size(226, 28);
            txtY.TabIndex = 24;
            txtY.Text = "";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(551, 330);
            label14.Name = "label14";
            label14.Size = new Size(18, 20);
            label14.TabIndex = 23;
            label14.Text = "Y";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DarkCyan;
            btnCreate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(316, 356);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(102, 31);
            btnCreate.TabIndex = 25;
            btnCreate.Text = "Tạo chữ ký";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnTrans
            // 
            btnTrans.BackColor = Color.OliveDrab;
            btnTrans.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrans.ForeColor = Color.White;
            btnTrans.Location = new Point(456, 356);
            btnTrans.Margin = new Padding(3, 2, 3, 2);
            btnTrans.Name = "btnTrans";
            btnTrans.Size = new Size(102, 31);
            btnTrans.TabIndex = 26;
            btnTrans.Text = "Chuyển tiếp";
            btnTrans.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Goldenrod;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(600, 356);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 31);
            btnSave.TabIndex = 27;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDoc
            // 
            btnDoc.BackColor = Color.DarkRed;
            btnDoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoc.ForeColor = Color.White;
            btnDoc.Location = new Point(175, 356);
            btnDoc.Margin = new Padding(3, 2, 3, 2);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(102, 31);
            btnDoc.TabIndex = 28;
            btnDoc.Text = "Tải văn bản";
            btnDoc.UseVisualStyleBackColor = false;
            btnDoc.Click += btnDoc_Click;
            // 
            // SignDoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 398);
            Controls.Add(btnDoc);
            Controls.Add(btnSave);
            Controls.Add(btnTrans);
            Controls.Add(btnCreate);
            Controls.Add(txtY);
            Controls.Add(label14);
            Controls.Add(txtX);
            Controls.Add(label13);
            Controls.Add(txtG);
            Controls.Add(label12);
            Controls.Add(txtQ);
            Controls.Add(label11);
            Controls.Add(txtP);
            Controls.Add(label10);
            Controls.Add(panel1);
            Controls.Add(richTextBox2);
            Controls.Add(label4);
            Controls.Add(firstEle);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(txtSignDoc);
            Controls.Add(label1);
            Controls.Add(genKeyLabel);
            Controls.Add(pictureBox1);
            Controls.Add(panelMenu);
            Controls.Add(panelSideBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignDoc";
            Text = "SignDoc";
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
        private LinkLabel exit;
        private LinkLabel verifySignature;
        private LinkLabel signText;
        private LinkLabel generateKey;
        private Panel panelSideBar;
        private PictureBox pictureBox1;
        private Label genKeyLabel;
        private Label label1;
        private RichTextBox txtSignDoc;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label3;
        private RichTextBox firstEle;
        private Label label4;
        private RichTextBox richTextBox2;
        private Panel panel1;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label10;
        private RichTextBox txtP;
        private RichTextBox txtQ;
        private Label label11;
        private RichTextBox txtG;
        private Label label12;
        private RichTextBox txtX;
        private Label label13;
        private RichTextBox txtY;
        private Label label14;
        private Button btnCreate;
        private Button btnTrans;
        private Button btnSave;
        private Button btnDoc;
    }
}