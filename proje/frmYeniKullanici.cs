using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class frmYeniKullanici : Form
    {
        public frmYeniKullanici()
        {
            InitializeComponent();
        }

        private void frmYeniKullanici_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.AdiSoyadi = txtAdiSoyadi.Text;
            k.Soru = comboSoru.Text;
            k.Cevap = txtCevap.Text;

            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                string sql = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, AdiSoyadi, Soru, Cevap) VALUES (@KullaniciAdi, @Sifre, @AdiSoyadi, @Soru, @Cevap)";

                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@KullaniciAdi", k.KullaniciAdi);
                komut.Parameters.AddWithValue("@Sifre", k.Sifre);
                komut.Parameters.AddWithValue("@AdiSoyadi", k.AdiSoyadi);
                komut.Parameters.AddWithValue("@Soru", k.Soru);
                komut.Parameters.AddWithValue("@Cevap", k.Cevap);

                veritabani.ESG(komut, sql);

                MessageBox.Show("Yeni kullanıcı eklendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void btnEkle_Click(object sender, EventArgs e)
        //{
        //    Kullanicilar k = new Kullanicilar();
        //    k.KullaniciAdi = txtKullaniciAdi.Text;
        //    k.Sifre = txtSifre.Text;
        //    k.AdiSoyadi = txtAdiSoyadi.Text;
        //    k.Soru = comboSoru.Text;
        //    k.Cevap = txtCevap.Text;

        //    if (txtSifre.Text==txtSifreTekrar.Text)
        //    {
        //        string sql = "insert into Kullanicilar values('" + k.KullaniciAdi + "','" + k.Sifre + "','" + k.AdiSoyadi + "','" + k.Soru + "')";
        //        SqlCommand komut = new SqlCommand();
        //        veritabani.ESG(komut, sql);

        //        MessageBox.Show("Yeni kullanici eklendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        Temizle();
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Şifreler uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }

        //}

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Temizle()
        {
            comboSoru.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
