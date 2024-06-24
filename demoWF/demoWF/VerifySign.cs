using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Xml.Linq;

namespace demoWF
{
    public partial class VerifySign : Form
    {
        DSA_algorithm d = new DSA_algorithm();
        private MainFrame mainF;
        public VerifySign(MainFrame mainF)
        {
            this.mainF = mainF;
        }
        private void UpdateData()
        {
            txtConfirmY.Text = mainF.TxtGenY.ToString(); // Lấy dữ liệu từ Form1
        }

        //private void SaveData()
        //{
        //    mainF.TxtGenY = txtConfirmY.Text; // Đặt dữ liệu trong Form1
        //}
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

        private void btnUpDocCon_Click(object sender, EventArgs e)
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
                        txtConfirmDoc.Text = content.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpSignCon_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            // Set initial directory (optional)
            // fileDialog.InitialDirectory = ".";

            // Set filter for specific file types (optional)
            // fileDialog.Filter = "Text files (*.txt)|*.txt";

            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;

                try
                {
                    // Read the file content
                    string content = File.ReadAllText(filePath);

                    // Split the content based on "-" delimiter
                    string[] sign = content.Split('-');

                    txtConfirmR.Text = sign[0];
                    txtConfirmS.Text = sign[1];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmDoc.Text))
            {
                MessageBox.Show("Chưa có văn bản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Convert text to hexadecimal strings (assuming hexadecimal input)
                //string pString = txtConfirmP.Text.Trim();
                //string qString = txtConfirmQ.Text.Trim();
                //string gString = txtConfirmG.Text.Trim();
                //string yString = txtConfirmY.Text.Trim();
                //string rString = txtConfirmR.Text.Trim();
                //string sString = txtConfirmS.Text.Trim();

                // Create BigInteger objects
                BigInteger p = BigInteger.Parse(txtConfirmP.Text.ToString());
                BigInteger q = BigInteger.Parse(txtConfirmQ.Text.ToString());
                BigInteger g = BigInteger.Parse(txtConfirmG.Text.ToString());
                BigInteger y = BigInteger.Parse(txtConfirmY.Text.ToString());
                BigInteger r = BigInteger.Parse(txtConfirmR.Text.ToString());
                BigInteger s = BigInteger.Parse(txtConfirmS.Text.ToString());

                // Signature verification
                //if (!r.Equals(d.R))
                //{
                //    MessageBox.Show("Thành phần chữ ký r bị giả mạo ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                //if (!s.Equals(d.S)
                //{
                //    MessageBox.Show("Thành phần chữ ký s bị giả mạo ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                // Calculate hash value (assuming SHA-1)
                string hashCode = SHA_1.SHA1(txtConfirmDoc.Text);
                txtHashConfirmC.Text = hashCode;

                if (d.VerifyingSignature(hashCode, r, s, p, q, g, y))
                {
                    MessageBox.Show("Xác nhận chữ ký thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Văn bản bị giả mạo", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex) // Catch generic exception for now, consider specific ones later
            {
                MessageBox.Show("Xác nhận chữ ký thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
