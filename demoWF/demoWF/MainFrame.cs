using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace demoWF
{
    public partial class MainFrame : Form
    {
        VerifySign v = new VerifySign();
        DSA_algorithm d = new DSA_algorithm();
        public MainFrame()
        {
            InitializeComponent();
        }

        private void signText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignDoc signDoc = new SignDoc();
            this.Hide();
            signDoc.TxtSignP.Text = txtGenP.Text;
            signDoc.TxtSignQ.Text = txtGenQ.Text;
            signDoc.TxtSignG.Text = txtGenG.Text;
            signDoc.TxtSignX.Text = txtGenX.Text;
            signDoc.TxtSignY.Text = txtGenY.Text;
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

        private void btnRandomKey_Click_1(object sender, EventArgs e)
        {
            d.generateKeyDSA();
            txtGenP.Text = d.P.ToString();
            txtGenQ.Text = d.Q.ToString();
            txtGenX.Text = d.X.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtGenP.Text = "";
            txtGenQ.Text = "";
            txtGenG.Text = "";
            txtGenX.Text = "";
            txtGenY.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger p = BigInteger.Parse(txtGenP.Text.ToString());
                BigInteger q = BigInteger.Parse(txtGenQ.Text.ToString());
                BigInteger x = BigInteger.Parse(txtGenX.Text.ToString());
                BigInteger g;
                BigInteger h;
                BigInteger y;

                if (!utilities.IsPrime(p, 20))
                {
                    MessageBox.Show("Số p nhập vào không là số nguyên tố", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!utilities.IsPrime(q, 20))
                {
                    MessageBox.Show("Số q nhập vào không là số nguyên tố", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!((BigInteger.Subtract(p, BigInteger.One) % q).Equals(BigInteger.Zero)))
                {
                    MessageBox.Show("Tham số p-1 không chia hết cho q", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!(x.CompareTo(BigInteger.One) == 1 && x.CompareTo(BigInteger.Subtract(q, BigInteger.One)) == -1))
                {
                    MessageBox.Show("x không nằm trong khoảng từ 1 đến q-1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                h = utilities.GetRandomNumber(2, p - 2);
                g = new BigInteger();
                do
                {
                    g = BigInteger.ModPow(h, (p - BigInteger.One) / q, p);
                } while (g == BigInteger.One);
                y = BigInteger.ModPow(g, x, p);
                d.P = p;
                d.Q = q;
                d.G = g;
                d.H = h;
                d.X = x;
                d.Y = y;
                // Ghi vào ô phần tạo khóa
                txtGenP.Text = p.ToString();
                txtGenQ.Text = q.ToString();
                txtGenG.Text = g.ToString();
                txtGenX.Text = x.ToString();
                txtGenY.Text = y.ToString();
                // Ghi vào ô phần sinh chữ ký

                // Ghi vào ô phần xác nhận chữ ký
                v.TxtConfirmP.Text = p.ToString();
                v.TxtConfirmQ.Text = q.ToString();
                v.TxtConfirmG.Text = g.ToString();
                v.TxtConfirmY.Text = y.ToString();
                MessageBox.Show("Xác nhận khóa thành công, đã chuyển dữ liệu khóa sang những tab khác",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                txtGenP.ResetText();
                txtGenQ.ResetText();
                txtGenX.ResetText();
                MessageBox.Show("P, Q, X không hợp lệ",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
