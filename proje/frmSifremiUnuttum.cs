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
    public partial class frmSifremiUnuttum : Form
    {
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void frmSifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = int.Parse(txtKullaniciID.Text);
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.AdiSoyadi = txtAdiSoyadi.Text;
            k.Soru = comboSoru.Text;
            k.Cevap = txtCevap.Text;

            if (txtSifre == txtSifreTekrar)
            {
                string sql = "update kullanicilar set kullaniciAdi='" + k.KullaniciAdi + "',Sifre='" + k.Sifre + "',AdiSoyadi='" + k.AdiSoyadi + "'," +
                 "Soru='" + k.Soru + "',Cevap='" + k.Cevap + "' where KullaniciID='" + k.KullaniciID + "'";

                SqlCommand komut = new SqlCommand();
                veritabani.ESG(komut, sql);
                MessageBox.Show("Kullanıcı bilgileri güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
