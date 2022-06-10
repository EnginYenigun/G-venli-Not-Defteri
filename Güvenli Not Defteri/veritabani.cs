using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Güvenli_Not_Defteri
{
    class veritabani
    {
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + Application.StartupPath + "\\gnd.mdb; Persist Security Info=True;Jet OLEDB:Database Password=123456789");
        OleDbCommand komut;
        OleDbDataReader oku;
        #region Giriş Formu Veritabanı Kodları
        public bool giris(string sifre)
        {
            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut = new OleDbCommand("select * from giris where sifre='" + sifre + "'", baglanti);
                oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    oku.Close();
                    baglanti.Close();
                    return true;
                }
                else
                {
                    oku.Close();
                    baglanti.Close();
                    MessageBox.Show("Girdiğiniz şifre yanlıştır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception)
            {
                baglanti.Close();
                oku.Close();
                MessageBox.Show("Giriş yapma sırasında bir hata oluştu!\nHata Kodu: CLASS_giris\n", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public string epostacek()
        {
            string eposta = "";
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut = new OleDbCommand("select * from giris eposta", baglanti);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                eposta = oku["eposta"].ToString();
            }
            oku.Close();
            baglanti.Close();
            return eposta;
        }

        public void kayit(string eposta, string sifre)
        {
            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut = new OleDbCommand("insert into giris (eposta,sifre) values (@eposta,@sifre)", baglanti);
                komut.Parameters.AddWithValue("@eposta", eposta);
                komut.Parameters.AddWithValue("@sifre", sifre);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla kayıt oldunuz. Şimdi giriş yapabilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("Kayıt olma işlemi sırasında bir hata oluştu!\nHata Kodu: CLASS_kayit\n", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void sifredegistir(string yenisifre)
        {
            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut = new OleDbCommand("update giris set sifre='" + yenisifre + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni şifreniz başarıyla belirlendi. Artık giriş yapabilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("Şifrenizi yenileme sırasında bir hata oluştu!\nHata Kodu: CLASS_sifredegistir\n", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int kayitdurum()
        {
            try
            {
                baglanti.Open();
                komut = new OleDbCommand("select count(*) from giris", baglanti);
                return Convert.ToInt32(komut.ExecuteScalar());
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanıyla ilk bağlantı kurulurken bir hata oluştu!\nHata Kodu: CLASS_kayitdurum\n", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return -0;
            }
        }
        #endregion
        #region Ana Form Veritabanı Kodları
        public void kaydet(string metin, string tarih)
        {
            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                komut = new OleDbCommand("select * from kayitlar where tarih='" + tarih + "'", baglanti);
                oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    oku.Close();
                    komut = new OleDbCommand("update kayitlar set metin=@metin where tarih=@tarih", baglanti);
                    komut.Parameters.AddWithValue("@metin", metin);
                    komut.Parameters.AddWithValue("@tarih", tarih);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {
                    oku.Close();
                    komut = new OleDbCommand("insert into kayitlar (tarih,metin) values (@tarih,@metin)", baglanti);
                    komut.Parameters.AddWithValue("@tarih", tarih);
                    komut.Parameters.AddWithValue("@metin", metin);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }

            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Kaydetme işlemi sırasında bir hata oluştu!\nHata Kodu: CLASS_kaydet\n" + ex, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string notgoster(string secilitarih)
        {
            try
            {
                string notlar = "Kayıt Bulunamadı.";
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut = new OleDbCommand("select * from kayitlar metin where tarih='" + secilitarih + "'", baglanti);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    notlar = oku["metin"].ToString();
                }
                return notlar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından not çekme sırasında bir hata oluştu!\nHata Kodu: CLASS_notgoster\n" + ex, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Hata Kodu: CLASS_notgoster";
            }
        }
        #endregion
        #region Ayarlar Formu Veritabanı Kodları
        public string eposta;
        public string sifre;
        public void bilgicek()
        {
            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut = new OleDbCommand("select * from giris", baglanti);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    eposta = oku["eposta"].ToString();
                    sifre = oku["sifre"].ToString();
                }
                baglanti.Close();
                oku.Close();
            }
            catch (Exception ex)
            {
                baglanti.Close();
                oku.Close();
                MessageBox.Show("Hesap bilgileri çekilirken bir hata oluştu!\nHata Kodu: CLASS_bilgicek\n" + ex, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void hesapguncelle(string eposta, string sifre)
        {
            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut = new OleDbCommand("update giris set eposta=@eposta, sifre=@sifre", baglanti);
                komut.Parameters.AddWithValue("@eposta", eposta);
                komut.Parameters.AddWithValue("@sifre", sifre);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Hesap bilgileri başarıyla güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Hesap bilgileri güncellenirken bir hata oluştu!\nHata Kodu: CLASS_hesapguncelle\n" + ex, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}