using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UrunlerOtomasyonu
{
    class DB
    {
        // bağlantı deişkenleri
        string dbName = "db_19_odev";
        string dataSource = "RAMAZAN";
        //sqlconnection nesnesi
        public SqlConnection conn = null;
        public DB()
        {

        }
        public void ac()
        {
            try
            {
                //sql bağlantısı yapılıyor
                conn = new SqlConnection("Data Source=" + dataSource + ";Initial Catalog=" + dbName + ";Integrated Security=True");
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası: " + ex);
            }
        }
        public void kapat()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("db kapatma sorunu:" + ex);
            }
        }

        public bool KullaniciGiris(string tableName, string kulad, string sifre)
        {
            bool deger = false;
            ac();
            SqlDataReader rd = null;
            try
            {
                string sorgu = "select * from " + tableName + "   where kullaniciadi='" + kulad + "' and sifre='" + sifre + "'  ";
                SqlCommand cmd = new SqlCommand(sorgu, conn);

                rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    deger = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("data getir hatası: " + ex);
            }

            finally
            {
                kapat();
            }

            return deger;
        }

        //datatable doldur
        public DataTable UrunListele(string tableName)
        {
            ac();
            DataTable dt = new DataTable();
            try
            {
                string sorgu = "select *from " + tableName;
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("datatable doldurma hatası " + ex);
            }

            finally
            {
                kapat();
            }

            return dt;

        }

        public bool UrunKaydet(string tableName, string[] dizi)
        {
            bool deger = false;
            ac();
            string sorgu = "insert into " + tableName + " values('" + string.Join("','", dizi) + "', GETDATE())";
            SqlCommand cm = new SqlCommand(sorgu, conn);
            int sonuc = cm.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt İşlemi Başarılı !!!");
                kapat();
                deger = true;
            }
            else
                MessageBox.Show("Kaydetme İşlemi Başarısız !!!");

            kapat();

            return deger;
        }

        public bool UrunSil(string tableName, string id)
        {
            bool deger = false;
            ac();
            string sorgu = "delete " + tableName + " where urunid=" + id;
            SqlCommand cm = new SqlCommand(sorgu, conn);
            int sonuc = cm.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("Silme İşlemi Başarılı !!!");
                kapat();
                deger = true;
            }
            else
                MessageBox.Show("Silme İşlemi Başarısız !!!");

            kapat();

            return deger;
        }

        public bool UrunGuncelle(string tableName, string id, string[] dizi)
        {
            bool deger = false;
            ac();
            string sorgu = "update " + tableName + " set urunad='" + dizi[0] + "',urunfiyati='" + dizi[1] + "',urunaciklama='" + dizi[2] + "',urunresimyolu='" + dizi[3] + "',uruntarih=GETDATE() where urunid=" + id;
            SqlCommand cm = new SqlCommand(sorgu, conn);
            int sonuc = cm.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("Güncelleme İşlemi Başarılı !!!");
                kapat();
                deger = true;
            }
            else
                MessageBox.Show("Güncelleme İşlemi Başarısız !!!");

            kapat();

            return deger;

        }
    }
}
