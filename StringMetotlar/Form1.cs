using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ornekMetin = "";
        #region Örnek 1
        private void BtnCOMPARETO_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            int result = ornekMetin.CompareTo("araba");
            string mesaj = "";
            switch (result)
            {
                case -1:
                    mesaj = "Kelime, diğer kelime ile eşleşmemektedir, eksik karakter mevcut.";
                    break;
                case 0:
                    mesaj = "Kelime, diğer kelime ile eşleşmektedir.";
                    break;
                case 1:
                    mesaj = "Kelime, diğer kelime ile eşleşmemektedir, fazla karakter mevcut.";
                    break;
                default:
                    break;
            }
            MessageBox.Show(mesaj);
        }
        #endregion

        #region Örnek 2
        private void BtnCONTAINS_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            bool result = ornekMetin.Contains("adam");
            MessageBox.Show($"Aradığınız kelime metin içerisinde geçme{(result ? "" : "me")}ktedir");
        }
        #endregion

        #region Örnek 3
        private void BtnSTARTSWITH_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            bool result = ornekMetin.StartsWith("bil");

            MessageBox.Show($"Metin parametrede gönderdiğiniz anahtar kelime ile başlama{(result ? "" : "")}ktadır");
        }
        #endregion

        #region Örnek 4
        private void BtnENDSWITH_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            bool result = ornekMetin.EndsWith("dam");

            MessageBox.Show($"Kelime parametrede gönderdiğiniz değer ile bitme{(result ? "" : "me")}ktedir");
        }
        #endregion

        #region Örnek 5
        private void BtnINDEXOF_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            int index = ornekMetin.IndexOf('@');

            MessageBox.Show(index > -1 ? "Aradığınız karakterin metin içerisindeki index değeri : " + index : "Metin içerisinde aradığınız parametre yer almamaktadır");
        }
        #endregion

        #region Örnek 6
        private void BtnLASTINDEXOF_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            int index = ornekMetin.LastIndexOf('a');

            MessageBox.Show(index > -1 ? "Aradığınız karakterin metin içerisindeki index değeri : " + index : "Metin içerisinde aradığınız parametre yer almamaktadır");
        }
        #endregion

        #region Örnek 7
        private void BtnREMOVE_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;

            //ornekMetin = ornekMetin.Remove(5); verdiğiniz index değeri dahil olmak üzere kalan tüm karakterleri siler.
            ornekMetin = ornekMetin.Remove(3, 2);
            //1. Parametre, başlangıç index değeri.
            //2. Parametre, silinecek eleman sayısı.
            MessageBox.Show(ornekMetin);
        }
        #endregion

        #region Örnek 8
        private void BtnREPLACE_Click(object sender, EventArgs e)
        {
            //ornekMetin = txtGirisAlani.Text;
            //ornekMetin = ornekMetin.Replace("adam", "hatun");
            //MessageBox.Show(ornekMetin);

            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Replace("ı", "i").Replace("ç", "c").Replace("ü", "u").Replace("ö", "o").Replace("ş", "s").Replace("ğ", "g");
            //ornekMetin = ornekMetin.Replace("ı", "i");
            //ornekMetin = ornekMetin.Replace("ç", "c");
            //ornekMetin = ornekMetin.Replace("ü", "u");
            //ornekMetin = ornekMetin.Replace("ö", "o");
            //ornekMetin = ornekMetin.Replace("ş", "s");
            //ornekMetin = ornekMetin.Replace("ğ", "g");
            MessageBox.Show(ornekMetin);
        }
        #endregion

        #region Örnek 9
        private void BtnSPLIT_Click(object sender, EventArgs e)
        {
            //string[] mailAdresler = txtGirisAlani.Text.Split(';');
            //foreach (string mail in mailAdresler)
            //{
            //    MessageBox.Show(mail);
            //}

            string[] veriler = txtGirisAlani.Text.Split(';', ',', '+', '.');
            foreach (string veri in veriler)
            {
                MessageBox.Show(veri);
            }
        }
        #endregion

        #region Örnek 10
        private void BtnINSERT_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Insert(5, "cuk");
            MessageBox.Show(ornekMetin);
        }
        #endregion

        #region Örnek 11
        private void BtnTOLOWERTOUPPER_Click(object sender, EventArgs e)
        {
            this.Text = txtGirisAlani.Text.ToLower();
            MessageBox.Show(txtGirisAlani.Text.ToUpper());
        }
        #endregion

        #region Örnek 12
        private void BtnSUBSTRING_Click(object sender, EventArgs e)
        {
            //Remove (5) => "bilge adam" => "bilge"
            //Substring (5) => "bilge adam" => " adam"

            ornekMetin = txtGirisAlani.Text;
            //ornekMetin = ornekMetin.Substring(5);

            //Remove (3, 2) => "bilge adam" => "bil adam"
            //Substring (3, 2) => "bilge adam" => "ge"
            ornekMetin = ornekMetin.Substring(3, 2);

            MessageBox.Show(ornekMetin);
        }
        #endregion

        #region Örnek 13
        private void BtnTOCHARARRAY_Click(object sender, EventArgs e)
        {
            //ornekMetin = txtGirisAlani.Text;
            //char[] karakterler = ornekMetin.ToCharArray();

            ornekMetin = txtGirisAlani.Text;
            char[] karakterler = ornekMetin.ToCharArray();
            int toplam = 0;
            foreach (char karakter in karakterler)
            {
                toplam += karakter;
            }
            MessageBox.Show(toplam.ToString());
        }
        #endregion

        #region Örnek 14
        private void BtnTRIM_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            int l1 = ornekMetin.Length;
            ornekMetin = ornekMetin.Trim();
            int l2 = ornekMetin.Length;

            MessageBox.Show($"Metin boşluklar dahil toplamda {l1} karakterden oluşmaktadır!\nMetin boşluklar silinerek toplamda {l2} karakterden oluşmaktadır");

            //"".TrimEnd() => metnin sonundaki boşlukları siler
            //"".TrimStart() => metnin başındaki boşlukları siler
        } 
        #endregion
    }
}
