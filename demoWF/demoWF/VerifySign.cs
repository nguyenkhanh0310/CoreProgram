using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoWF
{
    public partial class VerifySign : Form
    {
        public VerifySign()
        {
            InitializeComponent();
        }

        private void exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void generateKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainFrame mainFrame = new MainFrame();
            this.Hide();
            mainFrame.Show();
        }

        private void signText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignDoc signDoc = new SignDoc();
            this.Hide();
            signDoc.Show();
        }

        private void verifySignature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerifySign verifySign = new VerifySign();
            this.Hide();
            verifySign.Show();
        }

        //private void panelSideBar_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
