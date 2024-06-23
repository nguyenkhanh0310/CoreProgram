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
            label1 = new Label();
            veriDoc = new RichTextBox();
            label2 = new Label();
            resultSHA = new RichTextBox();
            txtP = new RichTextBox();
            label10 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            label4 = new Label();
            richTextBox3 = new RichTextBox();
            label9 = new Label();
            richTextBox4 = new RichTextBox();
            label11 = new Label();
            richTextBox5 = new RichTextBox();
            label12 = new Label();
            richTextBox6 = new RichTextBox();
            label13 = new Label();
            btnCheck = new Button();
            btnUpDoc = new Button();
            btnUpSign = new Button();
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
            panelMenu.Size = new Size(155, 64);
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
            generateKey.Location = new Point(38, 51);
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
            panelSideBar.Location = new Point(0, 66);
            panelSideBar.Margin = new Padding(3, 2, 3, 2);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(155, 359);
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
            exit.Location = new Point(-1, 246);
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
            verifySignature.Location = new Point(7, 182);
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
            signText.Location = new Point(28, 114);
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
            panel1.Size = new Size(283, 116);
            panel1.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 89);
            label8.Name = "label8";
            label8.Size = new Size(237, 13);
            label8.TabIndex = 3;
            label8.Text = "Nhấn \"Tải văn bản\" để tải văn bản có sẵn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 58);
            label7.Name = "label7";
            label7.Size = new Size(214, 13);
            label7.TabIndex = 2;
            label7.Text = "Nhấn \"Kiểm tra\" để kiểm tra văn bản";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 31);
            label6.Name = "label6";
            label6.Size = new Size(160, 13);
            label6.TabIndex = 1;
            label6.Text = "Nhập văn bản cần xác nhận";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(489, 64);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 16;
            label1.Text = "Văn bản cần xác nhận:";
            // 
            // veriDoc
            // 
            veriDoc.Location = new Point(489, 86);
            veriDoc.Margin = new Padding(3, 2, 3, 2);
            veriDoc.Name = "veriDoc";
            veriDoc.Size = new Size(282, 98);
            veriDoc.TabIndex = 17;
            veriDoc.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(489, 204);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 18;
            label2.Text = "Kết quả hàm băm:";
            // 
            // resultSHA
            // 
            resultSHA.Location = new Point(489, 221);
            resultSHA.Margin = new Padding(3, 2, 3, 2);
            resultSHA.Name = "resultSHA";
            resultSHA.Size = new Size(282, 65);
            resultSHA.TabIndex = 19;
            resultSHA.Text = "";
            // 
            // txtP
            // 
            txtP.Location = new Point(215, 192);
            txtP.Margin = new Padding(3, 2, 3, 2);
            txtP.Name = "txtP";
            txtP.Size = new Size(226, 28);
            txtP.TabIndex = 21;
            txtP.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(176, 200);
            label10.Name = "label10";
            label10.Size = new Size(18, 20);
            label10.TabIndex = 20;
            label10.Text = "P";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(216, 224);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(226, 28);
            richTextBox1.TabIndex = 23;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(177, 232);
            label3.Name = "label3";
            label3.Size = new Size(20, 20);
            label3.TabIndex = 22;
            label3.Text = "Q";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(215, 255);
            richTextBox2.Margin = new Padding(3, 2, 3, 2);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(226, 28);
            richTextBox2.TabIndex = 25;
            richTextBox2.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(176, 263);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 24;
            label4.Text = "G";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(231, 312);
            richTextBox3.Margin = new Padding(3, 2, 3, 2);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(226, 28);
            richTextBox3.TabIndex = 27;
            richTextBox3.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(192, 320);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 26;
            label9.Text = "W";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(231, 344);
            richTextBox4.Margin = new Padding(3, 2, 3, 2);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(226, 28);
            richTextBox4.TabIndex = 29;
            richTextBox4.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(192, 352);
            label11.Name = "label11";
            label11.Size = new Size(19, 20);
            label11.TabIndex = 28;
            label11.Text = "V";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(520, 310);
            richTextBox5.Margin = new Padding(3, 2, 3, 2);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(226, 28);
            richTextBox5.TabIndex = 31;
            richTextBox5.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(480, 319);
            label12.Name = "label12";
            label12.Size = new Size(29, 20);
            label12.TabIndex = 30;
            label12.Text = "U1";
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(520, 344);
            richTextBox6.Margin = new Padding(3, 2, 3, 2);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(226, 28);
            richTextBox6.TabIndex = 33;
            richTextBox6.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(480, 352);
            label13.Name = "label13";
            label13.Size = new Size(29, 20);
            label13.TabIndex = 32;
            label13.Text = "U2";
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.Firebrick;
            btnCheck.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(253, 384);
            btnCheck.Margin = new Padding(3, 2, 3, 2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(82, 28);
            btnCheck.TabIndex = 34;
            btnCheck.Text = "Kiểm tra";
            btnCheck.UseVisualStyleBackColor = false;
            // 
            // btnUpDoc
            // 
            btnUpDoc.BackColor = Color.DarkOliveGreen;
            btnUpDoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpDoc.ForeColor = Color.White;
            btnUpDoc.Location = new Point(413, 384);
            btnUpDoc.Margin = new Padding(3, 2, 3, 2);
            btnUpDoc.Name = "btnUpDoc";
            btnUpDoc.Size = new Size(96, 28);
            btnUpDoc.TabIndex = 35;
            btnUpDoc.Text = "Tải văn bản";
            btnUpDoc.UseVisualStyleBackColor = false;
            // 
            // btnUpSign
            // 
            btnUpSign.BackColor = Color.DarkOrange;
            btnUpSign.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpSign.ForeColor = Color.White;
            btnUpSign.Location = new Point(582, 384);
            btnUpSign.Margin = new Padding(3, 2, 3, 2);
            btnUpSign.Name = "btnUpSign";
            btnUpSign.Size = new Size(96, 28);
            btnUpSign.TabIndex = 36;
            btnUpSign.Text = "Tải chữ ký";
            btnUpSign.UseVisualStyleBackColor = false;
            // 
            // VerifySign
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 422);
            Controls.Add(btnUpSign);
            Controls.Add(btnUpDoc);
            Controls.Add(btnCheck);
            Controls.Add(richTextBox6);
            Controls.Add(label13);
            Controls.Add(richTextBox5);
            Controls.Add(label12);
            Controls.Add(richTextBox4);
            Controls.Add(label11);
            Controls.Add(richTextBox3);
            Controls.Add(label9);
            Controls.Add(richTextBox2);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(txtP);
            Controls.Add(label10);
            Controls.Add(resultSHA);
            Controls.Add(label2);
            Controls.Add(veriDoc);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(genKeyLabel);
            Controls.Add(panelMenu);
            Controls.Add(panelSideBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VerifySign";
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
        private Label label1;
        private RichTextBox veriDoc;
        private Label label2;
        private RichTextBox resultSHA;
        private RichTextBox txtP;
        private Label label10;
        private RichTextBox richTextBox1;
        private Label label3;
        private RichTextBox richTextBox2;
        private Label label4;
        private RichTextBox richTextBox3;
        private Label label9;
        private RichTextBox richTextBox4;
        private Label label11;
        private RichTextBox richTextBox5;
        private Label label12;
        private RichTextBox richTextBox6;
        private Label label13;
        private Button btnCheck;
        private Button btnUpDoc;
        private Button btnUpSign;
    }
}