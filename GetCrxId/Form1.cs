using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;



namespace GetCrxId
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        RSA rsa;

        private void button_get_Click(object sender, EventArgs e)
        {
            rsa = new RSA(textBox_privateKey.Text, true);
            string pubKey = rsa.ToPEM_PKCS8(true).Replace("-----BEGIN PUBLIC KEY-----", "").Replace("-----END PUBLIC KEY-----", "").Trim();
            byte[] b64 = CrxHelper.DecodeBase64(pubKey);
            string str32 = CrxHelper.GetSHA256(b64).Substring(0, 32).Trim();
            string newStr = CrxHelper.EncodeBase16(str32);
            textBox_D.Text = newStr;
        }

        private void textBox_privateKey_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                var filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
                var hz = filenames[0].LastIndexOf('.') + 1;
                var houzhui = filenames[0].Substring(hz);//文件后缀名
                if (houzhui == "pem")
                {
                    e.Effect = DragDropEffects.All;
                }

            }

            
        }

        private void textBox_privateKey_DragDrop(object sender, DragEventArgs e)
        {
            var filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
            using (StreamReader sr = new StreamReader(filenames[0], Encoding.Default))
            {
                textBox_privateKey.Text = sr.ReadToEnd();
            }

           
        }
    }


}
