using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;//Dosya Kütüphanesi

namespace Etüt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       SqlConnection baglanti = new SqlConnection(@" Data Source = Monster; Initial Catalog = Etut; Integrated Security = True");
        void derslistesi()
        {   //Dersleri Combobox'a Listeleme
            SqlCommand komut = new SqlCommand("select * from Tbl_Dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_Ders.ValueMember = "DERSID"; //arkada alınan deger
            cmb_Ders.DisplayMember = "DERSAD";//bize görünecek değer
            cmb_Ders.DataSource = dt;
        }
        void derslistesi2()
        {   //Öğretmen Eklleme kısmınaDersleri Combobox'a Listeleme
            SqlCommand komut = new SqlCommand("select * from Tbl_Dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Cmb_Ders_Ogretmen.ValueMember = "DERSID"; //arkada alınan deger
            Cmb_Ders_Ogretmen.DisplayMember = "DERSAD";//bize görünecek değer
            Cmb_Ders_Ogretmen.DataSource = dt;
        }
        void etutlisteleme()
        {   //Datagriedview'e etütüleri alma  (joın ile)
            SqlCommand komut7 = new SqlCommand("select e.ID,d.DERSAD,o.AD+''+o.SOYAD as 'ÖğretmenAd-Soyad',e.TARIH,e.SAAT,e.DURUM from Tbl_Etut e\r\nINNER JOIN Tbl_Dersler d on e.DERSID=d.DERSID\r\nINNER JOIN Tbl_Ogretmen o on e.OGRETMENID=o.OGRETMENID\r\n", baglanti);
            SqlDataAdapter da7 = new SqlDataAdapter(komut7);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            dataGridView1.DataSource = dt7;
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //forma oluşturduğumuz voidleri alma
            derslistesi();
            etutlisteleme();
            derslistesi2();
        }

        private void cmb_Ders_SelectedIndexChanged(object sender, EventArgs e)
        {   //Ders Seçildikten Sonra O derse ait Öğretmenler gelsin
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Ogretmen WHERE BRANSID = @p", baglanti);//ogretmen branşına gore alıcanack
            komut.Parameters.AddWithValue("@p", cmb_Ders.SelectedValue);//cmbdersten secilen brans neyse 

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add("ad-soyad", typeof(string), "AD + ' ' + SOYAD");//typeof(string)-->veri tipini belirtiyor ad ve soyadı birlikte aldık
            cmb_Ogretmen.ValueMember = "OGRETMENID";//arka planda ıd alıncak
            cmb_Ogretmen.DisplayMember = "ad-soyad";//bize öğretmenin adı-soyadı gözükecek
            cmb_Ogretmen.DataSource = dt;
        }

        private void btn_Etutu_Olustur_Click(object sender, EventArgs e)
        {   //Etüt Ekleme 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Etut (DERSID,OGRETMENID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmb_Ders.SelectedValue.ToString());
            komut.Parameters.AddWithValue("@p2", cmb_Ogretmen.SelectedValue.ToString());
            komut.Parameters.AddWithValue("@p3", msk_Tarih.Text);
            komut.Parameters.AddWithValue("@p4", msk_Saat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Etut_ıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_Etut_Ver_Click(object sender, EventArgs e)
        {   //Öğrencinin Etüt seşmesi
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Tbl_Etut set OGRENCIID=@p1,DURUM=@p2 where ID=@p3", baglanti);
                komut.Parameters.AddWithValue("@p1", txt_Ogrenci.Text);
                komut.Parameters.AddWithValue("@p2", "true");
                komut.Parameters.AddWithValue("@p3", txt_Etut_ıd.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Etüt Öğrenciye Verildi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Etüt Alınırken Bir Hara oluştu"+ex.Message, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                baglanti.Close();
            }
            
            
        }

        private void btn_Fotograf_Yukle_Click(object sender, EventArgs e)
        {   //Fotoğraf Ekleme
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void btn_Ogrenci_Ekle_Click(object sender, EventArgs e)
        {
            //Öğrenci Ekleme
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Ogrenci (AD,SOYAD,SINIF,TELEFON,MAIL,FOTOGRAF)values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
                komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
                komut.Parameters.AddWithValue("@p3", txt_Sınıf.Text);
                komut.Parameters.AddWithValue("@p4", msk_Telefon.Text);
                komut.Parameters.AddWithValue("@p5", txt_Mail.Text);
                komut.Parameters.AddWithValue("@p6", pictureBox2.ImageLocation);
                komut.ExecuteNonQuery();
                MessageBox.Show("Öğrenci Sisteme Kaydedildi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci Sisteme Kaydedilirken Hata Oluştu"+ex.Message, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Yeni Bir Ders Ekleme(var olan ders bir daha seçilemesin)
            try
            {
                baglanti.Open();
                SqlCommand Komut = new SqlCommand("SELECT * FROM Tbl_Dersler", baglanti);//Dersleri Listeledik
                SqlDataReader dr = Komut.ExecuteReader();

                string yeniDersAdi = txt_Ders_Ad.Text;//kullanıcının girecegı ders adı

                while (dr.Read())// önceden eklenmiş dersleri kontol edecek
                {
                    // Eğer aynı isimde bir ders varsa, işlemi iptal et ve hata mesajı göster
                    if (dr[1].ToString() == yeniDersAdi)//dr[1]-->dersad  kullanıcının girecegi der ile dr[1] aynıysa
                    {
                        MessageBox.Show("Ders zaten Mevcut", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dr.Close();//hata mesajı ver ve dr çık
                        return;
                    }
                }
                dr.Close(); 

                //yeni ders ekleme işlemi(artık farklı olan ders eklenecek)
                SqlCommand ekleKomut = new SqlCommand("INSERT INTO Tbl_Dersler (DERSAD) VALUES (@p1)", baglanti);
                ekleKomut.Parameters.AddWithValue("@p1", yeniDersAdi);
                ekleKomut.ExecuteNonQuery();

                // Ekleme işlemi başarılıysa
                label13.Text = yeniDersAdi;
                MessageBox.Show("Ders Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btn_Ogretmen_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Öğretmen ekleme işlemi
                SqlCommand ekleKomut = new SqlCommand("INSERT INTO Tbl_Ogretmen (AD, SOYAD, BRANSID) VALUES (@p1, @p2, @p3)", baglanti);
                ekleKomut.Parameters.AddWithValue("@p1", txt_Ogretmen_Ad.Text);
                ekleKomut.Parameters.AddWithValue("@p2", txt_Ogretmen_Soyad.Text);
                ekleKomut.Parameters.AddWithValue("@p3", Cmb_Ders_Ogretmen.SelectedValue);

                int affectedRows = ekleKomut.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Öğretmen Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cmb_Ders_Ogretmen ComboBox'ını güncelleme işlemi
                    SqlCommand listeleKomut = new SqlCommand("SELECT OGRETMENID, CONCAT(AD, ' ', SOYAD) AS AD_SOYAD FROM Tbl_Ogretmen", baglanti);
                    SqlDataAdapter da = new SqlDataAdapter(listeleKomut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    Cmb_Ders_Ogretmen.ValueMember = "OGRETMENID";
                    Cmb_Ders_Ogretmen.DisplayMember = "AD_SOYAD";
                    Cmb_Ders_Ogretmen.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Öğretmen Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }




        }

        private void btn_Ders_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Tbl_Dersler where DERSAD=@p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_Ders_Ad.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ders silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }
    }
}
