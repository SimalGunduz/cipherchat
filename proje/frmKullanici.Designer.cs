
namespace proje
{
    partial class frmKullanici
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
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCikis = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(34, 147);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(220, 23);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEkle.Location = new System.Drawing.Point(34, 287);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(220, 41);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Giriş";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(34, 208);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(220, 23);
            this.txtSifre.TabIndex = 0;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.Transparent;
            this.btnKayitOl.FlatAppearance.BorderSize = 0;
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitOl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKayitOl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnKayitOl.Location = new System.Drawing.Point(90, 334);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(105, 41);
            this.btnKayitOl.TabIndex = 1;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(34, 245);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Beni Hatırla";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(159, 246);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblCikis);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 98);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(78, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Girişi";
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCikis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCikis.Location = new System.Drawing.Point(261, 0);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(24, 25);
            this.lblCikis.TabIndex = 1;
            this.lblCikis.Text = "X";
            this.lblCikis.Click += new System.EventHandler(this.lblCikis_Click);
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(288, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmKullanici_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCikis;
    }
}