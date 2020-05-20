using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace MainFrom
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        Thread th = null;
        private bool flas = false;
        private string guid = "94B4442D900F49CCA3F72D1AF5BF836D";//Guid.NewGuid().ToString().Replace("-", "");

        private void btn_verification_Click(object sender, EventArgs e)
        {
            GoogleAuthenticator authenticator = new GoogleAuthenticator(30, guid);
            string googlecode = authenticator.GenerateCode();
            if (googlecode.ToUpper() == txtcode.Text.Trim().ToUpper())
            {
                if (!flas)
                {
                    flas = true;
                    th = new Thread(() =>
                    {
                        while (flas)
                        {
                            if (lab_code.InvokeRequired)
                            {
                                lab_code.Invoke(new Action(() => { lab_code.Text = authenticator.GenerateCode(); lab_time.Text = authenticator.EXPIRE_SECONDS.ToString(); }));
                            }
                            else
                            {
                                lab_code.Text = authenticator.GenerateCode();
                                lab_time.Text = authenticator.EXPIRE_SECONDS.ToString();
                            }
                            Thread.Sleep(1000);
                        }
                    });
                    th.Start();
                }
                MessageBox.Show("验证成功");

            }
            else MessageBox.Show("验证失败");
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            CreateQrCode();
        }

        #region 生成二维码
        private void CreateQrCode()
        {
            string websitetitle = UrlEncode("MIMU86");
            QRCodeCreate qcc = new QRCodeCreate();
            // guid = Guid.NewGuid().ToString().Replace("-", "");
            string gcode = Base32.ToString(Encoding.UTF8.GetBytes(guid)).Replace("=", "");
            string content = string.Format("otpauth://totp/{0}?secret={1}&issuer=", websitetitle, gcode);
            picBox_qrcode.Image = qcc.CreateQRCode(content, QRCodeEncoder.ENCODE_MODE.BYTE, QRCodeEncoder.ERROR_CORRECTION.M, 0, 5, 0, 0);
        }
        #endregion

        #region Url编码
        public static string UrlEncode(string str)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes(str); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }

            return (sb.ToString());
        }
        #endregion


        private void MainFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            flas = false;
        }

    }
}
