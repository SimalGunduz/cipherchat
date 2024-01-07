
namespace proje
{
    partial class frmSifremiUnuttum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifremiUnuttum));
            this.comboSoru = new System.Windows.Forms.ComboBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // comboSoru
            // 
            this.comboSoru.FormattingEnabled = true;
            this.comboSoru.Items.AddRange(new object[] {
            "1) En sevdiğiniz renk hangisidir?",
            "2) İlkokul öğretmeninizin ismi nedir?",
            "3) En sevdiğiniz film hangisidir?"});
            this.comboSoru.Location = new System.Drawing.Point(133, 259);
            this.comboSoru.Name = "comboSoru";
            this.comboSoru.Size = new System.Drawing.Size(190, 23);
            this.comboSoru.TabIndex = 17;
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCikis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageIndex = 1;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(248, 353);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 74);
            this.btnCikis.TabIndex = 15;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.ImageIndex = 0;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(150, 353);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 75);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(69, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cevap:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Güvenlik Sorusu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adı Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(133, 292);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(190, 23);
            this.txtCevap.TabIndex = 4;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(133, 230);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(190, 23);
            this.txtAdiSoyadi.TabIndex = 5;
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(133, 149);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(190, 23);
            this.txtSifreTekrar.TabIndex = 6;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(133, 111);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(190, 23);
            this.txtSifre.TabIndex = 7;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(133, 76);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(190, 23);
            this.txtKullaniciAdi.TabIndex = 8;
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Location = new System.Drawing.Point(133, 38);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(190, 23);
            this.txtKullaniciID.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(42, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kullanıcı ID:";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "zyro-image (2).png");
            this.ımageList1.Images.SetKeyName(1, "zyro-image.png");
            // 
            // frmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 496);
            this.Controls.Add(this.comboSoru);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciID);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Name = "frmSifremiUnuttum";
            this.Text = "frmSifremiUnuttum";
            this.Load += new System.EventHandler(this.frmSifremiUnuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSoru;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.Label label7;
    }
}