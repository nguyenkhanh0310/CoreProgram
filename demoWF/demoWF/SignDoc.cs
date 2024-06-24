using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

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
            MainFrame mainFrame = new MainFrame();
            verify.TxtConfirmR.Text = txtSignR.Text;
            verify.TxtConfirmS.Text = txtSignS.Text;
            verify.TxtConfirmP.Text = txtSignP.Text;
            verify.TxtConfirmQ.Text = txtSignQ.Text;
            verify.TxtConfirmG.Text = txtSignG.Text;
            verify.TxtConfirmY.Text = txtSignY.Text;
            this.Hide();
            verify.Show();
        }

        private void exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        StringBuilder content = new StringBuilder();
                        while ((line = reader.ReadLine()) != null)
                        {
                            content.AppendLine(line); // Use AppendLine for automatic newline handling
                        }
                        txtSignDoc.Text = content.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtSignDoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa có văn bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Dictionary<BigInteger, BigInteger> signature = new Dictionary<BigInteger, BigInteger>();
                string hashCode = SHA_1.SHA1(txtSignDoc.Text);
                BigInteger hashValue = SHA_1.HexToDecimal(hashCode);
                BigInteger k, r, s;
                BigInteger p = BigInteger.Parse(txtSignP.Text.ToString());
                BigInteger q = BigInteger.Parse(txtSignQ.Text.ToString());
                BigInteger g = BigInteger.Parse(txtSignG.Text.ToString());
                BigInteger x = BigInteger.Parse(txtSignX.Text.ToString());
                do
                {
                    k = utilities.GetRandomNumber(BigInteger.One, q - BigInteger.One);
                    r = BigInteger.ModPow(g, k, p) % q;
                    s = utilities.NghichDao(k, q) * (hashValue + (x * r) % q) % q;
                }
                while (r == BigInteger.Zero || s == BigInteger.Zero);

                signature.Add(r, s);
                txtHashResult.Text = hashCode.ToString();
                txtSignR.Text = r.ToString();
                txtSignS.Text = s.ToString();
                MessageBox.Show(null, "Tạo chữ ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSignR.Text) || string.IsNullOrEmpty(txtSignS.Text))
            {
                MessageBox.Show("Chưa tạo chữ ký", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a SaveFileDialog for choosing the file path
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = "."; // Set default directory
            dialog.DefaultExt = ".txt"; // Set default file extension
            dialog.FileName = "sign.txt"; // Set default file name

            // Display the dialog and get the selected file path
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = dialog.FileName;

                string text = txtSignR.Text + "-" + txtSignS.Text;

                try
                {
                    // Write text to the file
                    File.WriteAllText(fileName, text);
                    MessageBox.Show("Lưu chữ ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException)
                {
                    MessageBox.Show("Lưu chữ ký thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
