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
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void signText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignDoc signDoc = new SignDoc();
            this.Hide();
            signDoc.Show();
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

        private void generateKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Show();
        }


        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{

        //}
    }
}
