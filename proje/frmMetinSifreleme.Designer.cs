
namespace proje
{
    partial class frmMetinSifreleme
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
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnCozumle = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(100, 287);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(79, 43);
            this.btnSifrele.TabIndex = 0;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            // 
            // btnCozumle
            // 
            this.btnCozumle.Location = new System.Drawing.Point(206, 287);
            this.btnCozumle.Name = "btnCozumle";
            this.btnCozumle.Size = new System.Drawing.Size(79, 43);
            this.btnCozumle.TabIndex = 0;
            this.btnCozumle.Text = "Çözümle";
            this.btnCozumle.UseVisualStyleBackColor = true;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(309, 287);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(79, 43);
            this.btnGonder.TabIndex = 1;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(24, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(364, 208);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelen Mesaj :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(4, 19);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(356, 186);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // frmMetinSifreleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(436, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnCozumle);
            this.Controls.Add(this.btnSifrele);
            this.Name = "frmMetinSifreleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metin Şifreleme";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Button btnCozumle;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}