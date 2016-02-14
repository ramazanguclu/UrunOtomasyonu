using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunlerOtomasyonu
{
    public class ClassMetodlarim
    {
        public static string MD5Sifrele(string metin)
        {
            // MD5CryptoServiceProvider nesnenin yeni bir instance'sını oluşturalım.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //Girilen veriyi bir byte dizisine dönüştürelim ve hash hesaplamasını yapalım.
            byte[] btr = Encoding.UTF8.GetBytes(metin);
            btr = md5.ComputeHash(btr);

            //byte'ları biriktirmek için yeni bir StringBuilder ve string oluşturalım.
            StringBuilder sb = new StringBuilder();


            //hash yapılmış her bir byte'ı dizi içinden alalım ve her birini hexadecimal string olarak formatlayalım.
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürelim.
            return sb.ToString();
        }

        public bool MetinKontrol(params string[] metin)
        {
            bool deger = true; 
            foreach (string item in metin)
            {
                if (string.IsNullOrEmpty(item.Trim()))
                {
                    deger = false;
                    break;
                }                 
            }

            return deger;     
        }

        public void Temizle(Control.ControlCollection controlCollection)
        {
            foreach (Control item in controlCollection)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is Panel)
                    Temizle(item.Controls);
                else if (item is RadioButton)
                {
                    RadioButton rb = item as RadioButton;
                    rb.Checked = false;
                }
                else if (item is GroupBox)
                    Temizle(item.Controls);
            }
        }
    }
}
