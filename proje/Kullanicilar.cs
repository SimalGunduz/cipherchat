using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proje
{
    class Kullanicilar
    {
        private int _KullaniciID;
        private string _KullaniciAdi;
        private string _Sifre;
        private string _AdiSoyadi;
        private string _Soru;
        private string _Cevap;

        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string KullaniciAdi { get => _KullaniciAdi; set => _KullaniciAdi = value; }
        public string Sifre { get => _Sifre; set => _Sifre = value; }
        public string AdiSoyadi { get => _AdiSoyadi; set => _AdiSoyadi = value; }
        public string Soru { get => _Soru; set => _Soru = value; }
        public string Cevap { get => _Cevap; set => _Cevap = value; }

        public static bool durum = false;
        public static int kid = 0;

        public static SqlDataReader KullaniciGirisi(string kullaniciadi, string sifre)
        {
            Kullanicilar k = new Kullanicilar();
            k._KullaniciAdi = kullaniciadi;
            k._Sifre = sifre;

            using (SqlConnection connection = new SqlConnection(veritabani.baglanti.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM kullanicilar WHERE kullaniciadi = @KullaniciAdi AND sifre = @Sifre";
                SqlCommand komut = new SqlCommand(query, connection);
                komut.Parameters.AddWithValue("@KullaniciAdi", k._KullaniciAdi);
                komut.Parameters.AddWithValue("@Sifre", k._Sifre);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    durum = true;
                    kid = Convert.ToInt32(dr["KullaniciID"]);
                }
                else
                {
                    durum = false;
                }

                return dr;
            }
        }

        //public static SqlDataReader KullaniciGrisi(string kullaniciadi,string sifre)
        //{
        //    Kullanicilar k = new Kullanicilar();
        //    k._KullaniciAdi = kullaniciadi;
        //    k._Sifre = sifre;
        //    veritabani.baglanti.Open();
        //    SqlCommand komut = new SqlCommand("select*from kullanicilar where kullaniciadi ='" + k._KullaniciAdi + "' " +
        //        "and  sifre = '" + k._Sifre + "'", veritabani.baglanti);
        //    SqlDataReader dr = komut.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        durum = true;
        //        kid = int.Parse(dr[0].ToString());
        //    }
        //    else
        //    {
        //        durum = false;
        //    }
        //    dr.Close();
        //    veritabani.baglanti.Close();
        //    return dr;
        //}
    }
}
