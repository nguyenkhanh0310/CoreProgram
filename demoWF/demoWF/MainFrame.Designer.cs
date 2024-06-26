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
            resources.ApplyResources(panelMenu, "panelMenu");
            panelMenu.BackColor = Color.FromArgb(26, 33, 48);
            panelMenu.Controls.Add(logoDSA);
            panelMenu.Name = "panelMenu";
            // 
            // logoDSA
            // 
            resources.ApplyResources(logoDSA, "logoDSA");
            logoDSA.Name = "logoDSA";
            logoDSA.TabStop = false;
            // 
            // panelSideBar
            // 
            resources.ApplyResources(panelSideBar, "panelSideBar");
            panelSideBar.BackColor = Color.FromArgb(26, 33, 48);
            panelSideBar.Controls.Add(exit);
            panelSideBar.Controls.Add(verifySignature);
            panelSideBar.Controls.Add(signText);
            panelSideBar.Controls.Add(generateKey);
            panelSideBar.Name = "panelSideBar";
            // 
            // exit
            // 
            exit.ActiveLinkColor = Color.Silver;
            resources.ApplyResources(exit, "exit");
            exit.ForeColor = SystemColors.ButtonHighlight;
            exit.LinkBehavior = LinkBehavior.NeverUnderline;
            exit.LinkColor = Color.White;
            exit.Name = "exit";
            exit.TabStop = true;
            exit.LinkClicked += exit_LinkClicked;
            // 
            // verifySignature
            // 
            verifySignature.ActiveLinkColor = Color.Silver;
            resources.ApplyResources(verifySignature, "verifySignature");
            verifySignature.ForeColor = SystemColors.ButtonHighlight;
            verifySignature.LinkBehavior = LinkBehavior.NeverUnderline;
            verifySignature.LinkColor = Color.White;
            verifySignature.Name = "verifySignature";
            verifySignature.TabStop = true;
            verifySignature.LinkClicked += verifySignature_LinkClicked;
            // 
            // signText
            // 
            signText.ActiveLinkColor = Color.Silver;
            resources.ApplyResources(signText, "signText");
            signText.ForeColor = SystemColors.ButtonHighlight;
            signText.LinkBehavior = LinkBehavior.NeverUnderline;
            signText.LinkColor = Color.White;
            signText.Name = "signText";
            signText.TabStop = true;
            signText.LinkClicked += signText_LinkClicked;
            // 
            // generateKey
            // 
            generateKey.ActiveLinkColor = Color.Silver;
            resources.ApplyResources(generateKey, "generateKey");
            generateKey.ForeColor = SystemColors.ButtonHighlight;
            generateKey.LinkBehavior = LinkBehavior.NeverUnderline;
            generateKey.LinkColor = SystemColors.Control;
            generateKey.Name = "generateKey";
            generateKey.TabStop = true;
            generateKey.LinkClicked += generateKey_LinkClicked;
            // 
            // genKeyLabel
            // 
            resources.ApplyResources(genKeyLabel, "genKeyLabel");
            genKeyLabel.Name = "genKeyLabel";
            // 
            // logoKey
            // 
            resources.ApplyResources(logoKey, "logoKey");
            logoKey.Name = "logoKey";
            logoKey.TabStop = false;
            // 
            // instruction
            // 
            resources.ApplyResources(instruction, "instruction");
            instruction.BackColor = Color.FromArgb(90, 114, 160);
            instruction.Controls.Add(label3);
            instruction.Controls.Add(label2);
            instruction.Controls.Add(label1);
            instruction.Controls.Add(txtIns1);
            instruction.Name = "instruction";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";
            // 
            // txtIns1
            // 
            resources.ApplyResources(txtIns1, "txtIns1");
            txtIns1.ForeColor = SystemColors.ButtonHighlight;
            txtIns1.Name = "txtIns1";
            // 
            // lblGenP
            // 
            resources.ApplyResources(lblGenP, "lblGenP");
            lblGenP.Name = "lblGenP";
            // 
            // lblGenQ
            // 
            resources.ApplyResources(lblGenQ, "lblGenQ");
            lblGenQ.Name = "lblGenQ";
            // 
            // lblGenG
            // 
            resources.ApplyResources(lblGenG, "lblGenG");
            lblGenG.Name = "lblGenG";
            // 
            // txtGenP
            // 
            txtGenP.AcceptsReturn = true;
            resources.ApplyResources(txtGenP, "txtGenP");
            txtGenP.Name = "txtGenP";
            // 
            // txtGenQ
            // 
            txtGenQ.AcceptsReturn = true;
            resources.ApplyResources(txtGenQ, "txtGenQ");
            txtGenQ.Name = "txtGenQ";
            // 
            // txtGenG
            // 
            txtGenG.AcceptsReturn = true;
            resources.ApplyResources(txtGenG, "txtGenG");
            txtGenG.Name = "txtGenG";
            txtGenG.ReadOnly = true;
            // 
            // lblGenX
            // 
            resources.ApplyResources(lblGenX, "lblGenX");
            lblGenX.Name = "lblGenX";
            // 
            // lblGenY
            // 
            resources.ApplyResources(lblGenY, "lblGenY");
            lblGenY.Name = "lblGenY";
            // 
            // txtGenX
            // 
            txtGenX.AcceptsReturn = true;
            resources.ApplyResources(txtGenX, "txtGenX");
            txtGenX.Name = "txtGenX";
            // 
            // txtGenY
            // 
            txtGenY.AcceptsReturn = true;
            resources.ApplyResources(txtGenY, "txtGenY");
            txtGenY.Name = "txtGenY";
            txtGenY.ReadOnly = true;
            // 
            // btnRandomKey
            // 
            resources.ApplyResources(btnRandomKey, "btnRandomKey");
            btnRandomKey.BackColor = Color.DarkSlateBlue;
            btnRandomKey.ForeColor = SystemColors.ButtonHighlight;
            btnRandomKey.Name = "btnRandomKey";
            btnRandomKey.UseVisualStyleBackColor = false;
            btnRandomKey.Click += btnRandomKey_Click_1;
            // 
            // btnDelete
            // 
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Name = "btnDelete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblPrivateKey
            // 
            resources.ApplyResources(lblPrivateKey, "lblPrivateKey");
            lblPrivateKey.Name = "lblPrivateKey";
            // 
            // lblPublicKey
            // 
            resources.ApplyResources(lblPublicKey, "lblPublicKey");
            lblPublicKey.Name = "lblPublicKey";
            // 
            // btnConfirm
            // 
            resources.ApplyResources(btnConfirm, "btnConfirm");
            btnConfirm.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirm.ForeColor = SystemColors.ButtonHighlight;
            btnConfirm.Name = "btnConfirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // MainFrame
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "MainFrame";
            Load += MainFrame_Load;
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
        public TextBox TxtGenP
        {
            get { return txtGenP; }
            set { txtGenP = value; }
        }
        public TextBox TxtGenQ
        {
            get { return txtGenQ; }
            set { txtGenQ = value; }
        }
        public TextBox TxtGenG
        {
            get { return txtGenG; }
            set { txtGenG = value; }
        }
        public TextBox TxtGenX
        {
            get { return txtGenX; }
            set { txtGenX = value; }
        }
        public TextBox TxtGenY
        {
            get { return txtGenY; }
            set { txtGenY = value; }
        }
    }
}