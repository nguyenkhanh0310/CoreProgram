using System.Numerics;

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
            lblSignDoc = new Label();
            txtSignDoc = new RichTextBox();
            lblHashResult = new Label();
            txtHashResult = new RichTextBox();
            lblSignR = new Label();
            txtSignR = new RichTextBox();
            lblSignS = new Label();
            txtSignS = new RichTextBox();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lblSignP = new Label();
            txtSignP = new RichTextBox();
            txtSignQ = new RichTextBox();
            lblSignQ = new Label();
            txtSignG = new RichTextBox();
            lblSignG = new Label();
            lblSignX = new Label();
            btnCreateSign = new Button();
            btnSave = new Button();
            btnUpDocSign = new Button();
            txtSign = new Label();
            txtSignY = new RichTextBox();
            txtSignX = new TextBox();
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
            panelMenu.Size = new Size(145, 146);
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
            exit.Location = new Point(1, 250);
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
            verifySignature.Location = new Point(11, 185);
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
            signText.Location = new Point(30, 120);
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
            generateKey.Location = new Point(36, 55);
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
            panelSideBar.Location = new Point(0, 65);
            panelSideBar.Margin = new Padding(3, 2, 3, 2);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(145, 436);
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
            // lblSignDoc
            // 
            lblSignDoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSignDoc.AutoSize = true;
            lblSignDoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignDoc.Location = new Point(171, 65);
            lblSignDoc.Name = "lblSignDoc";
            lblSignDoc.Size = new Size(90, 15);
            lblSignDoc.TabIndex = 6;
            lblSignDoc.Text = "Văn bản cần ký:";
            // 
            // txtSignDoc
            // 
            txtSignDoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSignDoc.Font = new Font("Segoe UI", 12F);
            txtSignDoc.Location = new Point(175, 92);
            txtSignDoc.Margin = new Padding(3, 2, 3, 2);
            txtSignDoc.Name = "txtSignDoc";
            txtSignDoc.Size = new Size(356, 70);
            txtSignDoc.TabIndex = 7;
            txtSignDoc.Text = "";
            // 
            // lblHashResult
            // 
            lblHashResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHashResult.AutoSize = true;
            lblHashResult.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHashResult.Location = new Point(171, 182);
            lblHashResult.Name = "lblHashResult";
            lblHashResult.Size = new Size(104, 15);
            lblHashResult.TabIndex = 8;
            lblHashResult.Text = "Kết quả hàm băm:";
            // 
            // txtHashResult
            // 
            txtHashResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHashResult.Font = new Font("Segoe UI", 12F);
            txtHashResult.Location = new Point(175, 208);
            txtHashResult.Margin = new Padding(3, 2, 3, 2);
            txtHashResult.Name = "txtHashResult";
            txtHashResult.Size = new Size(356, 70);
            txtHashResult.TabIndex = 9;
            txtHashResult.Text = "";
            // 
            // lblSignR
            // 
            lblSignR.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSignR.AutoSize = true;
            lblSignR.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignR.Location = new Point(175, 323);
            lblSignR.Name = "lblSignR";
            lblSignR.Size = new Size(140, 15);
            lblSignR.TabIndex = 10;
            lblSignR.Text = "Thành phần thứ nhất (R):";
            // 
            // txtSignR
            // 
            txtSignR.Font = new Font("Segoe UI", 12F);
            txtSignR.Location = new Point(175, 341);
            txtSignR.Margin = new Padding(3, 2, 3, 2);
            txtSignR.Name = "txtSignR";
            txtSignR.Size = new Size(167, 52);
            txtSignR.TabIndex = 11;
            txtSignR.Text = "";
            // 
            // lblSignS
            // 
            lblSignS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSignS.AutoSize = true;
            lblSignS.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignS.Location = new Point(373, 323);
            lblSignS.Name = "lblSignS";
            lblSignS.Size = new Size(132, 15);
            lblSignS.TabIndex = 12;
            lblSignS.Text = "Thành phần thứ hai (S):";
            // 
            // txtSignS
            // 
            txtSignS.Font = new Font("Segoe UI", 12F);
            txtSignS.Location = new Point(373, 341);
            txtSignS.Margin = new Padding(3, 2, 3, 2);
            txtSignS.Name = "txtSignS";
            txtSignS.Size = new Size(158, 52);
            txtSignS.TabIndex = 13;
            txtSignS.Text = "";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(549, 16);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 146);
            panel1.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = Color.White;
            label9.Location = new Point(29, 118);
            label9.Name = "label9";
            label9.Size = new Size(170, 16);
            label9.TabIndex = 4;
            label9.Text = "Nhấn \"Lưu\" để lưu chữ ký";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 89);
            label8.Name = "label8";
            label8.Size = new Size(261, 16);
            label8.TabIndex = 3;
            label8.Text = "Nhấn \"Chuyển tiếp\" để xác nhận chữ ký";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 58);
            label7.Name = "label7";
            label7.Size = new Size(218, 16);
            label7.TabIndex = 2;
            label7.Text = "Nhấn \"Tạo chữ ký\" để tạo chữ ký";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 31);
            label6.Name = "label6";
            label6.Size = new Size(141, 16);
            label6.TabIndex = 1;
            label6.Text = "Nhập văn bản cần ký";
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
            // lblSignP
            // 
            lblSignP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSignP.AutoSize = true;
            lblSignP.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSignP.Location = new Point(579, 199);
            lblSignP.Name = "lblSignP";
            lblSignP.Size = new Size(24, 25);
            lblSignP.TabIndex = 15;
            lblSignP.Text = "P";
            // 
            // txtSignP
            // 
            txtSignP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSignP.Font = new Font("Segoe UI", 12F);
            txtSignP.Location = new Point(614, 182);
            txtSignP.Margin = new Padding(3, 2, 3, 2);
            txtSignP.Name = "txtSignP";
            txtSignP.ReadOnly = true;
            txtSignP.Size = new Size(226, 52);
            txtSignP.TabIndex = 16;
            txtSignP.Text = "";
            // 
            // txtSignQ
            // 
            txtSignQ.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSignQ.Font = new Font("Segoe UI", 12F);
            txtSignQ.Location = new Point(614, 242);
            txtSignQ.Margin = new Padding(3, 2, 3, 2);
            txtSignQ.Name = "txtSignQ";
            txtSignQ.ReadOnly = true;
            txtSignQ.Size = new Size(226, 52);
            txtSignQ.TabIndex = 18;
            txtSignQ.Text = "";
            // 
            // lblSignQ
            // 
            lblSignQ.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSignQ.AutoSize = true;
            lblSignQ.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSignQ.Location = new Point(576, 258);
            lblSignQ.Name = "lblSignQ";
            lblSignQ.Size = new Size(26, 25);
            lblSignQ.TabIndex = 17;
            lblSignQ.Text = "Q";
            // 
            // txtSignG
            // 
            txtSignG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSignG.Font = new Font("Segoe UI", 12F);
            txtSignG.Location = new Point(614, 302);
            txtSignG.Margin = new Padding(3, 2, 3, 2);
            txtSignG.Name = "txtSignG";
            txtSignG.ReadOnly = true;
            txtSignG.Size = new Size(226, 52);
            txtSignG.TabIndex = 20;
            txtSignG.Text = "";
            // 
            // lblSignG
            // 
            lblSignG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSignG.AutoSize = true;
            lblSignG.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSignG.Location = new Point(576, 317);
            lblSignG.Name = "lblSignG";
            lblSignG.Size = new Size(26, 25);
            lblSignG.TabIndex = 19;
            lblSignG.Text = "G";
            // 
            // lblSignX
            // 
            lblSignX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSignX.AutoSize = true;
            lblSignX.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSignX.Location = new Point(578, 376);
            lblSignX.Name = "lblSignX";
            lblSignX.Size = new Size(24, 25);
            lblSignX.TabIndex = 21;
            lblSignX.Text = "X";
            // 
            // btnCreateSign
            // 
            btnCreateSign.Anchor = AnchorStyles.Bottom;
            btnCreateSign.BackColor = Color.DarkCyan;
            btnCreateSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreateSign.ForeColor = Color.White;
            btnCreateSign.Location = new Point(314, 422);
            btnCreateSign.Margin = new Padding(3, 2, 3, 2);
            btnCreateSign.Name = "btnCreateSign";
            btnCreateSign.Size = new Size(113, 47);
            btnCreateSign.TabIndex = 25;
            btnCreateSign.Text = "Tạo chữ ký";
            btnCreateSign.UseVisualStyleBackColor = false;
            btnCreateSign.Click += btnCreate_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.BackColor = Color.Goldenrod;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(457, 422);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 47);
            btnSave.TabIndex = 27;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpDocSign
            // 
            btnUpDocSign.Anchor = AnchorStyles.Bottom;
            btnUpDocSign.BackColor = Color.DarkRed;
            btnUpDocSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpDocSign.ForeColor = Color.White;
            btnUpDocSign.Location = new Point(171, 422);
            btnUpDocSign.Margin = new Padding(3, 2, 3, 2);
            btnUpDocSign.Name = "btnUpDocSign";
            btnUpDocSign.Size = new Size(113, 47);
            btnUpDocSign.TabIndex = 28;
            btnUpDocSign.Text = "Tải văn bản";
            btnUpDocSign.UseVisualStyleBackColor = false;
            btnUpDocSign.Click += btnDoc_Click;
            // 
            // txtSign
            // 
            txtSign.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSign.AutoSize = true;
            txtSign.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSign.Location = new Point(175, 291);
            txtSign.Name = "txtSign";
            txtSign.Size = new Size(57, 20);
            txtSign.TabIndex = 29;
            txtSign.Text = "Chữ ký";
            // 
            // txtSignY
            // 
            txtSignY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSignY.Font = new Font("Microsoft Sans Serif", 12F);
            txtSignY.Location = new Point(614, 362);
            txtSignY.Margin = new Padding(3, 2, 3, 2);
            txtSignY.Name = "txtSignY";
            txtSignY.ReadOnly = true;
            txtSignY.Size = new Size(226, 52);
            txtSignY.TabIndex = 30;
            txtSignY.Text = "";
            txtSignY.Visible = false;
            //txtSignY.TextChanged += this.txtSignY_TextChanged;
            // 
            // txtSignX
            // 
            txtSignX.AcceptsReturn = true;
            txtSignX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSignX.Font = new Font("Segoe UI", 12F);
            txtSignX.Location = new Point(614, 362);
            txtSignX.Margin = new Padding(3, 2, 3, 2);
            txtSignX.Multiline = true;
            txtSignX.Name = "txtSignX";
            txtSignX.PasswordChar = '*';
            txtSignX.ReadOnly = true;
            txtSignX.ScrollBars = ScrollBars.Vertical;
            txtSignX.Size = new Size(226, 52);
            txtSignX.TabIndex = 31;
            txtSignX.TextChanged += txtSignX_TextChanged;
            // 
            // SignDoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 501);
            Controls.Add(txtSignX);
            Controls.Add(panelSideBar);
            Controls.Add(txtSignY);
            Controls.Add(txtSign);
            Controls.Add(btnUpDocSign);
            Controls.Add(btnSave);
            Controls.Add(btnCreateSign);
            Controls.Add(lblSignX);
            Controls.Add(txtSignG);
            Controls.Add(lblSignG);
            Controls.Add(txtSignQ);
            Controls.Add(lblSignQ);
            Controls.Add(txtSignP);
            Controls.Add(lblSignP);
            Controls.Add(panel1);
            Controls.Add(txtSignS);
            Controls.Add(lblSignS);
            Controls.Add(txtSignR);
            Controls.Add(lblSignR);
            Controls.Add(txtHashResult);
            Controls.Add(lblHashResult);
            Controls.Add(txtSignDoc);
            Controls.Add(lblSignDoc);
            Controls.Add(genKeyLabel);
            Controls.Add(pictureBox1);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(873, 540);
            Name = "SignDoc";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label lblSignDoc;
        private RichTextBox txtSignDoc;
        private Label lblHashResult;
        private RichTextBox txtHashResult;
        private Label lblSignR;
        private RichTextBox txtSignR;
        private Label lblSignS;
        private RichTextBox txtSignS;
        private Panel panel1;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lblSignP;
        private RichTextBox txtSignP;
        private RichTextBox txtSignQ;
        private Label lblSignQ;
        private RichTextBox txtSignG;
        private Label lblSignG;
        private Label lblSignX;
        private Button btnCreateSign;
        private Button btnSave;
        private Button btnUpDocSign;
        private Label txtSign;
        private RichTextBox txtSignY;
        private TextBox txtSignX;

        public RichTextBox TxtSignP
        {
            get { return txtSignP; }
            set { txtSignP = value; }
        }
        public RichTextBox TxtSignQ
        {
            get { return txtSignQ; }
            set { txtSignQ = value; }
        }
        public RichTextBox TxtSignG
        {
            get { return txtSignG; }
            set { txtSignG = value; }
        }
        public TextBox TxtSignX
        {
            get { return txtSignX; }
            set { txtSignX = value; }
        }
        public RichTextBox TxtSignY
        {
            get { return txtSignY; }
            set { txtSignY = value; }
        }
    }
}