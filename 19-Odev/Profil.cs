using System;
using System.Windows.Forms;
using System.IO;

namespace UrunlerOtomasyonu
{
    public partial class Profil : Form
    {
        DB db = new DB();
        ClassMetodlarim Metodlarim = new ClassMetodlarim();
        string[] dizi = new string[4];
        string id = "";
        string path = "";
        public static string varsayilanpath = "resimler\\images.jpg";
        bool resimdegistimi = false;
        public Profil()
        {
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.UrunListele("Urunler");
            dataGridView1_SelectionChanged(null, null);
        }

        private void btnyeniurun_Click(object sender, EventArgs e)
        {
            YeniUrun fb = new YeniUrun();
            this.Visible = false;
            fb.Show();
        }

        private void btnresimdeg_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " (*.jpg)|*.jpg|(*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                resimdegistimi = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    resimdegistimi = false;
                    id = row.Cells[0].Value.ToString();
                    txtad.Text = row.Cells[1].Value.ToString();
                    txtaciklama.Text = row.Cells[3].Value.ToString();
                    txtfiyat.Text = row.Cells[2].Value.ToString();
                    txttarih.Text = row.Cells[5].Value.ToString();
                    path = row.Cells[4].Value.ToString();
                    try
                    {
                        pictureBox1.Load(path);
                    }
                    catch (Exception)
                    {
                        pictureBox1.Load(varsayilanpath);
                    }
                }
            }
        }

        private void btnurunsil_Click(object sender, EventArgs e)
        {
            if (id != "" && !(dataGridView1.RowCount <= 1))
            {
                DialogResult dialogResult = MessageBox.Show("Seçili Ürünü Silmek İstediğinizden Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (db.UrunSil("Urunler", id) && path != varsayilanpath)
                    {
                        KlasordenResimSilme();
                    }
                }
            }
        }
        private void btnurunguncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 1)
            {
                Metodlarim.Temizle(Controls);
            }

            if (Metodlarim.MetinKontrol(txtaciklama.Text, txtad.Text, txtfiyat.Text))
            {
                for (int i = 0; i < dizi.Length; i++)
                {
                    dizi[i] = "";
                }
                dizi[0] = txtad.Text;
                dizi[1] = txtfiyat.Text;
                dizi[2] = txtaciklama.Text;
                if (path != varsayilanpath && resimdegistimi)
                {
                    dizi[3] = "resimler\\" + id + txtad.Text + DateTime.Now.Second + Path.GetExtension(openFileDialog1.FileName);
                    if (db.UrunGuncelle("Urunler", id, dizi))
                    {
                        pictureBox1.Image.Save(dizi[3]);
                        KlasordenResimSilme();
                    }
                }
                else
                {
                    dizi[3] = path;
                    db.UrunGuncelle("Urunler", id, dizi);
                    id = "";
                    path = "";
                    Profil_Load(null, null);
                }
            }
        }

        private void KlasordenResimSilme()
        {
            pictureBox1.Load(varsayilanpath);
            try
            {
                File.Delete(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                id = "";
                path = "";
                Profil_Load(null, null);
            }
        }
    }
}
