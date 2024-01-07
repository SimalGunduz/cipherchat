
//namespace proje
//{
//    partial class frmStegoIslem
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.SuspendLayout();
//            // 
//            // frmStegoIslem
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Name = "frmStegoIslem";
//            this.Text = "frmStegoIslem";
//            this.Load += new System.EventHandler(this.frmStegoIslem_Load);
//            this.ResumeLayout(false);

//        }

//        #endregion
//    }
//}
namespace proje
{
    partial class frmStegoIslem
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picIsleme = new System.Windows.Forms.PictureBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCoz = new System.Windows.Forms.Button();
            this.btnGizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKullanim = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSayi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIsleme)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picIsleme);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(14, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(750, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlenecek Resim";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // picIsleme
            // 
            this.picIsleme.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picIsleme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picIsleme.Location = new System.Drawing.Point(21, 36);
            this.picIsleme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picIsleme.Name = "picIsleme";
            this.picIsleme.Size = new System.Drawing.Size(631, 334);
            this.picIsleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIsleme.TabIndex = 0;
            this.picIsleme.TabStop = false;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(7, 24);
            this.txtMesaj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(396, 140);
            this.txtMesaj.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMesaj);
            this.groupBox2.Location = new System.Drawing.Point(14, 462);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(411, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gizlenecek Mesaj";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCoz);
            this.groupBox3.Controls.Add(this.btnGizle);
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.btnAc);
            this.groupBox3.Location = new System.Drawing.Point(432, 462);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(332, 172);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnCoz
            // 
            this.btnCoz.Location = new System.Drawing.Point(192, 105);
            this.btnCoz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCoz.Name = "btnCoz";
            this.btnCoz.Size = new System.Drawing.Size(88, 48);
            this.btnCoz.TabIndex = 3;
            this.btnCoz.Text = "Çöz";
            this.btnCoz.UseVisualStyleBackColor = true;
            this.btnCoz.Click += new System.EventHandler(this.btnCoz_Click);
            // 
            // btnGizle
            // 
            this.btnGizle.Location = new System.Drawing.Point(192, 24);
            this.btnGizle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGizle.Name = "btnGizle";
            this.btnGizle.Size = new System.Drawing.Size(88, 48);
            this.btnGizle.TabIndex = 2;
            this.btnGizle.Text = "Gizle";
            this.btnGizle.UseVisualStyleBackColor = true;
            this.btnGizle.Click += new System.EventHandler(this.btnGizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(64, 105);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 48);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(64, 24);
            this.btnAc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(88, 48);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKullanim,
            this.menuCikis});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // menuKullanim
            // 
            this.menuKullanim.Name = "menuKullanim";
            this.menuKullanim.Size = new System.Drawing.Size(121, 22);
            this.menuKullanim.Text = "Kullanım";
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.Size = new System.Drawing.Size(121, 22);
            this.menuCikis.Text = "Çıkış";
            this.menuCikis.Click += new System.EventHandler(this.menuCikis_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSayi,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 651);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(778, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSayi
            // 
            this.toolStripSayi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSayi.Name = "toolStripSayi";
            this.toolStripSayi.Size = new System.Drawing.Size(13, 17);
            this.toolStripSayi.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(135, 17);
            this.toolStripStatusLabel2.Text = "Karakter gizleyebilirsiniz.";
            // 
            // frmStegoIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(778, 673);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmStegoIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganografi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIsleme)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picIsleme;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCoz;
        private System.Windows.Forms.Button btnGizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuKullanim;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSayi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

