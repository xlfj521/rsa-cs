using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RSA
{
    public partial class frmRSA : Form
    {
        #region Khai báo dữ liệu
        BigInteger
            p = new BigInteger(3),
            q = new BigInteger(5),
            n = new BigInteger(15),
            phi = new BigInteger(8),
            e = new BigInteger(3),
            d = new BigInteger(3),
            m = new BigInteger(3),
            c = new BigInteger(12);
        int radix = 10;//Cơ số 10 - hệ thập phân
        #endregion
        #region Khởi tạo Form và khai báo các sự kiện thêm
        public frmRSA()
        {
            InitializeComponent();
            rtxP.LostFocus += new EventHandler(rtxP_LostFocus);
            rtxQ.LostFocus += new EventHandler(rtxQ_LostFocus);
            rtxE.LostFocus += new EventHandler(rtxE_LostFocus);
            rtxN.LostFocus += new EventHandler(rtxN_LostFocus);
            rtxD.LostFocus += new EventHandler(rtxD_LostFocus);
            rtxSource.LostFocus += new EventHandler(rtxSource_LostFocus);
            rtxEncrypt.LostFocus += new EventHandler(rtxEncrypt_LostFocus);
        }
        #endregion
        #region Các sự kiện LostFocus
        void rtxD_LostFocus(object sender, EventArgs e)
        {
            if (checkBase(rtxD.Text) == false)
                setErrorToolTip(rtxD, "d phải là một số nguyên dương, vui lòng nhập lại!");
            else
                setSuccessToolTip(ref d, rtxD, "Nhập khóa bí mật d");
        }

        void rtxN_LostFocus(object sender, EventArgs e)
        {
            if (checkBase(rtxN.Text) == false)
                setErrorToolTip(rtxN, "n phải là một số nguyên dương, vui lòng nhập lại!");
            else
                setSuccessToolTip(ref n, rtxN, "Nhập khóa công khai n");
        }

        void rtxEncrypt_LostFocus(object sender, EventArgs e)
        {
            if (checkBase(rtxEncrypt.Text) == false)
                setErrorToolTip(rtxEncrypt, "Bản mã phải là một số nguyên dương, vui lòng nhập lại!");
            else
                setSuccessToolTip(ref c, rtxEncrypt, "Nhập bản mã");
        }

        void rtxSource_LostFocus(object sender, EventArgs e)
        {
            if (checkBase(rtxSource.Text) == false)
                setErrorToolTip(rtxSource, "Bản rõ phải là một số nguyên dương, vui lòng nhập lại!");
            else
                setSuccessToolTip(ref m, rtxSource, "Nhập bản rõ");
        }

        void rtxE_LostFocus(object sender, EventArgs e1)
        {
            if (checkBase(rtxE.Text) == false)
                setErrorToolTip(rtxE, "e phải là một số nguyên dương, vui lòng nhập lại!");
            else
                setSuccessToolTip(ref e, rtxE, "Nhập khóa công khai e");
        }

        void rtxQ_LostFocus(object sender, EventArgs e)
        {
            if (checkBase(rtxQ.Text) == false)
                setErrorToolTip(rtxQ, "q phải là một số nguyên dương, vui lòng nhập lại!");
            else
            {
                BigInteger k = new BigInteger(rtxQ.Text, radix);
                if (k.isProbablePrime())
                {
                    q = k;
                    setPhi();
                    setSuccessToolTip(rtxQ, "Nhập số nguyên tố q");
                }
                else
                {
                    setErrorToolTip(rtxQ, "q không phải là số nguyên tố, vui lòng nhập lại!");
                }
            }
        }

        void rtxP_LostFocus(object sender, EventArgs e)
        {
            if (checkBase(rtxP.Text) == false)
                setErrorToolTip(rtxP, "p phải là một số nguyên dương, vui lòng nhập lại!");
            else
            {
                BigInteger k = new BigInteger(rtxP.Text, radix);
                if (k.isProbablePrime())
                {
                    p = k;
                    setPhi();
                    setSuccessToolTip(rtxP, "Nhập số nguyên tố p");
                }
                else
                {
                    setErrorToolTip(rtxP, "p không phải là số nguyên tố, vui lòng nhập lại!");
                }
            }
        }
        #endregion
        #region Các sự kiện Click
        #region Các nút sinh
        private void btnGenP_Click(object sender, EventArgs e)
        {
            int k = (int)nudP.Value;
            p = BigInteger.genPseudoPrime(k, GetConfidence(k), new Random());
            rtxP.Text = p.ToString();
            n = p * q;
            setSuccessToolTip(rtxP, "Nhập số nguyên tố p");
            rtxP_LostFocus(sender, e);
        }

        private void btnGenQ_Click(object sender, EventArgs e)
        {
            int k = (int)nudQ.Value;
            q = BigInteger.genPseudoPrime(k, GetConfidence(k), new Random());
            rtxQ.Text = q.ToString();
            n = p * q;
            setSuccessToolTip(rtxQ, "Nhập số nguyên tố q");
            rtxQ_LostFocus(sender, e);
        }

        private void btnGenE_Click(object sender, EventArgs e)
        {
            if (rtxPhi.Text != "")
            {
                Random r = new Random();
                int k = r.Next(2, phi.bitCount());
                rtxE.Text = phi.genCoPrime(k, new Random()).ToString();
                setSuccessToolTip(rtxE, "Nhập khóa công khai e");
                rtxE_LostFocus(sender, e);
            }
        }
        #endregion
        #region Các nút tính
        private void btnN_Click(object sender, EventArgs e)
        {
            n = p * q;
            rtxN.Text = n.ToString();
            setSuccessToolTip(rtxN, "Nhập khóa công khai n");
        }

        private void btnD_Click(object sender, EventArgs e1)
        {
            if (checkE())
            {
                d = e.modInverse(phi);
                rtxD.Text = d.ToString();
                setSuccessToolTip(rtxD, "Nhập khóa bí mật d");
            }
            else
            {
                MessageBox.Show("e không phải là số nguyên tố cùng nhau với phi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Các nút kiểm tra
        private void btnCheckE_Click(object sender, EventArgs e1)
        {
            if (checkE())
            {
                MessageBox.Show("e là số nguyên tố cùng nhau với phi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("e không phải là số nguyên tố cùng nhau với phi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCheckD_Click(object sender, EventArgs e1)
        {
            if (checkE())
            {
                BigInteger k = e.modInverse(phi);
                if (k == d)
                {
                    setSuccessToolTip(rtxD, "Nhập khóa bí mật d");
                    MessageBox.Show("d là phần tử ngược của e", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setSuccessToolTip(rtxD, "d không phải phần tử ngược của e");
                    MessageBox.Show("d không phải là phần tử ngược của e!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("e không phải là số nguyên tố cùng nhau với phi!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCheckN_Click(object sender, EventArgs e)
        {
            BigInteger k = new BigInteger(rtxN.Text, radix);
            if (k == n)
            {
                setSuccessToolTip(rtxN, "Nhập khóa công khai n");
                MessageBox.Show("n bằng p*q", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                setSuccessToolTip(rtxN, "n khác p*q");
                MessageBox.Show("n khác p*q", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Các nút mã hóa và giải mã
        private void btnEncrypt_Click(object sender, EventArgs e1)
        {
            m = new BigInteger(rtxSource.Text, radix);
            if (m >= n)
            {
                MessageBox.Show("Bản rõ phải nhỏ hơn n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (e >= n)
            {
                MessageBox.Show("e phải nhỏ hơn n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            m = m.modPow(e, n);
            rtxEncrypt.Text = m.ToString();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            c = new BigInteger(rtxEncrypt.Text, radix);
            if (c >= n)
            {
                MessageBox.Show("Bản mã phải nhỏ hơn n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (d >= n)
            {
                MessageBox.Show("d phải nhỏ hơn n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            c = c.modPow(d, n);
            rtxDecrypt.Text = c.ToString();
        }
        #endregion
        #region Các nút ký và xác thực chữ ký
        private void btnSign_Click(object sender, EventArgs e)
        {
            m = new BigInteger(rtxSource.Text, radix);
            if (m >= n)
            {
                MessageBox.Show("Bản rõ phải nhỏ hơn n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (d >= n)
            {
                MessageBox.Show("d phải nhỏ hơn n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            m = m.modPow(d, n);
            rtxEncrypt.Text = m.ToString();
        }

        private void btnVer_Click(object sender, EventArgs e1)
        {
            c = new BigInteger(rtxEncrypt.Text, radix);
            if (c >= n)
            {
                MessageBox.Show("Bản mã phải nhỏ hơn n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (e >= n)
            {
                MessageBox.Show("e phải nhỏ hơn n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            c = c.modPow(e, n);
            rtxDecrypt.Text = c.ToString();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (rtxSource.Text == rtxDecrypt.Text)
            {
                MessageBox.Show("Bản giải mã và bản rõ giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bản giải mã và bản rõ không giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Các nút xem khóa
        private void btnShowPublicKey_Click(object sender, EventArgs e1)
        {
            string s = "";
            s += "e = " + e.ToString() + "\n";
            s += "n = " + n.ToString();
            MessageBox.Show(s, "Khóa công khai", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShowPrivateKey_Click(object sender, EventArgs e)
        {
            string s = "";
            s += "d = " + d.ToString() + "\n";
            s += "p = " + p.ToString() + "\n";
            s += "q = " + q.ToString();
            MessageBox.Show(s, "Khóa bí mật", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region Các nút mở têp tin
        private void btnOpenSource_Click(object sender, EventArgs e)
        {
            OpenFile(rtxSource, "Source Files|*.src", "Mở bản rõ");
        }

        private void btnOpenEncrypt_Click(object sender, EventArgs e)
        {
            OpenFile(rtxEncrypt, "Encrypt Files|*.enc", "Mở bản mã");
        }

        private void btnOpenPublicKey_Click(object sender, EventArgs e1)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = false;
            op.Filter = "Public Key Files|*.puk";
            op.Title = "Mở khóa công khai";
            if (op.ShowDialog() == DialogResult.OK)
            {
                FileStream fsr = new FileStream(op.FileName, FileMode.Open, FileAccess.Read);
                StreamReader str = new StreamReader(fsr, Encoding.ASCII);
                String s = str.ReadToEnd();
                String[] st = s.Split('|');
                if (st.Length != 2)
                {
                    MessageBox.Show("Định dạng dữ liệu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!checkBase(st[0]) || !checkBase(st[1]))
                    {
                        MessageBox.Show("Định dạng dữ liệu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        rtxE.Text = st[0];
                        rtxN.Text = st[1];
                        setSuccessToolTip(ref n, rtxN, "Nhập khóa công khai n");
                        setSuccessToolTip(ref e, rtxE, "Nhập khóa công khai e");
                    }
                }
                fsr.Dispose();
                str.Dispose();
            }
        }

        private void btnOpenPrivateKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = false;
            op.Filter = "Private Key Files|*.prk";
            op.Title = "Mở khóa bí mật";
            if (op.ShowDialog() == DialogResult.OK)
            {
                FileStream fsr = new FileStream(op.FileName, FileMode.Open, FileAccess.Read);
                StreamReader str = new StreamReader(fsr, Encoding.ASCII);
                String s = str.ReadToEnd();
                String[] st = s.Split('|');
                if (st.Length != 3)
                {
                    MessageBox.Show("Định dạng dữ liệu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!checkBase(st[0]) || !checkBase(st[1]) || !checkBase(st[2]))
                    {
                        MessageBox.Show("Định dạng dữ liệu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        rtxD.Text = st[0];
                        setSuccessToolTip(ref d, rtxD, "Nhập khóa bí mật d");
                        BigInteger k = new BigInteger(st[1], radix);
                        if (k.isProbablePrime())
                        {
                            p = k;
                            rtxP.Text = st[1];
                            setPhi();
                            setSuccessToolTip(rtxP, "Nhập số nguyên tố p");
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu p không phải là số nguyên tố!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        k = new BigInteger(st[2], radix);
                        if (k.isProbablePrime())
                        {
                            q = k;
                            rtxQ.Text = st[2];
                            setPhi();
                            setSuccessToolTip(rtxQ, "Nhập số nguyên tố q");
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu q không phải là số nguyên tố!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                fsr.Dispose();
                str.Dispose();
            }
        }
        #endregion
        #region Các nút lưu tệp tin
        private void btnSavePublicKey_Click(object sender, EventArgs e)
        {
            String data = rtxE.Text + "|" + rtxN.Text;
            SaveFile(data, "Public Key Files|*.puk", "Lưu khóa công khai");
        }

        private void btnSavePrivateKey_Click(object sender, EventArgs e)
        {
            String data = rtxD.Text + "|" + rtxP.Text + "|" + rtxQ.Text;
            SaveFile(data, "Private Key Files|*.prk", "Lưu khóa bí mật");
        }

        private void btnSaveSource_Click(object sender, EventArgs e)
        {
            SaveFile(rtxSource.Text, "Source Files|*.src", "Lưu bản rõ");
        }

        private void btnSaveDecrypt_Click(object sender, EventArgs e)
        {
            SaveFile(rtxDecrypt.Text, "Decrypt Files|*.dec", "Lưu bản giải mã");
        }

        private void btnSaveEncrypt_Click(object sender, EventArgs e)
        {
            SaveFile(rtxEncrypt.Text, "Encrypt Files|*.enc", "Lưu bản mã");
        }
        #endregion
        #region Các nút nhãn liên kết
        private void llblP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnOpenPrivateKey.PerformClick();
        }

        private void llblN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnOpenPublicKey.PerformClick();
        }

        private void llblSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnOpenSource.PerformClick();
        }

        private void llblEncrypt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnOpenEncrypt.PerformClick();
        }

        private void llblDecrypt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnSaveDecrypt.PerformClick();
        }
        #endregion
        #endregion
        #region Các hàm và phương thức hỗ trợ
        #region Hàm
        private int GetConfidence(int bitcount)
        {
            if (bitcount < 64) return 5;
            return 5 * (bitcount / 64);
        }

        private bool checkE()
        {
            BigInteger k = new BigInteger(rtxE.Text, radix);
            if (k < phi && k.GCD(phi) == 1)
            {
                e = k;
                setSuccessToolTip(rtxE, "Nhập khóa công khai e");
                return true;
            }
            setSuccessToolTip(rtxE, "e không phải là số nguyên tố cùng nhau với Phi, vui lòng nhập lại!");
            return false;
        }

        private bool checkBase(String s)
        {
            int j;
            if (s == "") return false;
            String b = "0123456789";
            for (int i = 0; i < s.Length; ++i)
            {
                for (j = 0; j < b.Length; ++j)
                {
                    if (s[i] == b[j])
                    {
                        break;
                    }
                }
                if (j == b.Length) return false;
            }

            return true;
        }
        #endregion
        #region Phương thức
        private void setPhi()
        {
            phi = (p - 1) * (q - 1);
            rtxPhi.Text = phi.ToString();
        }

        private void setErrorToolTip(RichTextBox control, string caption)
        {
            try
            {
                toolTip1.SetToolTip(control, caption);
                control.Focus();
                control.SelectAll();
            }
            catch { }
        }

        private void setSuccessToolTip(RichTextBox control, string caption)
        {
            try
            {
                toolTip1.SetToolTip(control, caption);
            }
            catch { }
        }

        private void setSuccessToolTip(ref BigInteger b, RichTextBox control, string caption)
        {
            try
            {
                toolTip1.SetToolTip(control, caption);
            }
            catch { }
            b = new BigInteger(control.Text, radix);
        }

        private void OpenFile(RichTextBox rtx, String filter, String title)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Multiselect = false;
            f.Filter = filter;
            f.Title = title;
            if (f.ShowDialog() == DialogResult.OK)
            {
                FileStream fsr = new FileStream(f.FileName, FileMode.Open, FileAccess.Read);
                StreamReader str = new StreamReader(fsr, Encoding.ASCII);
                rtx.Text = str.ReadToEnd();
                rtx.Focus();
                fsr.Dispose();
                str.Dispose();
            }
        }

        private void SaveFile(String data, String filter, String title)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = filter;
            sv.Title = title;
            if (sv.ShowDialog() == DialogResult.OK)
            {
                FileStream fsr = new FileStream(sv.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter str = new StreamWriter(fsr, Encoding.ASCII);
                str.Write(data);
                fsr.Dispose();
                str.Dispose();
            }
        }
        #endregion
        #endregion 
    }
}
