
//namespace Client
//{
//    partial class Form1
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
//            // Form1
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Name = "Form1";
//            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
//            this.ResumeLayout(false);

//        }

//        #endregion
//    }
//}
namespace proje
{
    partial class frmClient
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_chat = new System.Windows.Forms.RichTextBox();
            this.Gorsel = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.görselŞifrelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metinŞifrelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Gorsel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 18;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(292, 51);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 27);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "İsminiz : ";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(84, 54);
            this.txName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(200, 23);
            this.txName.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(383, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(169, 243);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tüm Clientler";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(7, 22);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(154, 214);
            this.listBox1.TabIndex = 0;
            // 
            // txt_text
            // 
            this.txt_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_text.Location = new System.Drawing.Point(15, 300);
            this.txt_text.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(207, 23);
            this.txt_text.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(230, 299);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 27);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_chat);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(364, 208);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelen Mesaj :";
            // 
            // rb_chat
            // 
            this.rb_chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_chat.Location = new System.Drawing.Point(4, 19);
            this.rb_chat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_chat.Name = "rb_chat";
            this.rb_chat.Size = new System.Drawing.Size(356, 186);
            this.rb_chat.TabIndex = 1;
            this.rb_chat.Text = "";
            // 
            // Gorsel
            // 
            this.Gorsel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.metinŞifrelemeToolStripMenuItem});
            this.Gorsel.Location = new System.Drawing.Point(0, 0);
            this.Gorsel.Name = "Gorsel";
            this.Gorsel.Size = new System.Drawing.Size(562, 24);
            this.Gorsel.TabIndex = 20;
            this.Gorsel.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görselŞifrelemeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 20);
            this.toolStripMenuItem1.Text = "Görsel Şifreleme";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // görselŞifrelemeToolStripMenuItem
            // 
            this.görselŞifrelemeToolStripMenuItem.Name = "görselŞifrelemeToolStripMenuItem";
            this.görselŞifrelemeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.görselŞifrelemeToolStripMenuItem.Text = "Görsel Şifreleme";
            // 
            // metinŞifrelemeToolStripMenuItem
            // 
            this.metinŞifrelemeToolStripMenuItem.Name = "metinŞifrelemeToolStripMenuItem";
            this.metinŞifrelemeToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.metinŞifrelemeToolStripMenuItem.Text = "Metin Şifreleme";
            this.metinŞifrelemeToolStripMenuItem.Click += new System.EventHandler(this.metinŞifrelemeToolStripMenuItem_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_text);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gorsel);
            this.MainMenuStrip = this.Gorsel;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Gorsel.ResumeLayout(false);
            this.Gorsel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rb_chat;
        private System.Windows.Forms.MenuStrip Gorsel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem görselŞifrelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metinŞifrelemeToolStripMenuItem;
    }
}

