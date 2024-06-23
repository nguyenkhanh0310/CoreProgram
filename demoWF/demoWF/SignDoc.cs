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
    public partial class SignDoc : Form
    {
        public SignDoc()
        {
            InitializeComponent();
        }

        private void generateKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainFrame mainFrame = new MainFrame();
            this.Hide();
            mainFrame.Show();
        }

        private void signText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Show();
        }

        private void verifySignature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerifySign verify = new VerifySign();
            this.Hide();
            verify.Show();
        }

        private void exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
