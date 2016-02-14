using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace UrunlerOtomasyonu
{

    public partial class Form1 : Form
    {
        DB db = new DB();
        ClassMetodlarim Metodlarim = new ClassMetodlarim();
        string tabloismi = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void btngiris_Click(object sender, EventArgs e)
        {
            tabloismi = "Adminler";
            if (Metodlarim.MetinKontrol(textBox1.Text) && Metodlarim.MetinKontrol(textBox2.Text))
            {
                bool deger = db.KullaniciGiris(tabloismi, textBox1.Text, ClassMetodlarim.MD5Sifrele(textBox2.Text));
                if (deger)
                {
                    MessageBox.Show("Bilgiler Doğru");
                    Metodlarim.Temizle(Controls);
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    btngiris.Enabled = false;
                    //this.Hide();
                    Profil fb = new Profil();
                    //fb.FormClosing += Fb_FormClosing;                                      
                    fb.Show();
                }

                else
                {
                    MessageBox.Show("Bilgiler Yanlış");
                    Metodlarim.Temizle(Controls);
                }                   
            }

            else
            {
                MessageBox.Show("Alanları Doldurunuz");
                Metodlarim.Temizle(Controls);
            }

        }

        //private void Fb_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    //this.Close();
        //}

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
