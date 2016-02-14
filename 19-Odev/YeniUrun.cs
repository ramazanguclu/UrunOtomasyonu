using System;
using System.Windows.Forms;
using System.IO;


namespace UrunlerOtomasyonu
{
    public partial class YeniUrun : Form
    {
        ClassMetodlarim Metodlarim = new ClassMetodlarim();
        DB db = new DB();
        
        string[] dizi = new string[4];
        public YeniUrun()
        {
            InitializeComponent();
            pictureBox1.Load(Profil.varsayilanpath);
        }
        private void btnresimsec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " (*.jpg)|*.jpg|(*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && Metodlarim.MetinKontrol(txtad.Text, txtaciklama.Text, txtfiyat.Text))
            {
                for (int i = 0; i < dizi.Length; i++)
                {
                    dizi[i] = "";
                }

                dizi[0] = txtad.Text;
                dizi[1] = txtfiyat.Text;
                dizi[2] = txtaciklama.Text;
                dizi[3] = "resimler\\" + txtad.Text + DateTime.Now.Second + Path.GetExtension(openFileDialog1.FileName);

                if (db.UrunKaydet("Urunler", dizi))
                {                                    
                    pictureBox1.Image.Save(dizi[3]);
                }
            }

            else
                MessageBox.Show("Tüm Alanları Doldurunuz.");

            Metodlarim.Temizle(Controls);
            txtad.Focus();
        }

        private void btnprofil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profil pf = new Profil();
            pf.Show();           
        }
        private void txtfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}
