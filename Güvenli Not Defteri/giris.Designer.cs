namespace Güvenli_Not_Defteri
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.pnlUstBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.gbKayit = new System.Windows.Forms.GroupBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbGiris = new System.Windows.Forms.GroupBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.lblSU = new System.Windows.Forms.LinkLabel();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbKod = new System.Windows.Forms.GroupBox();
            this.btnKO = new System.Windows.Forms.Button();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbSD = new System.Windows.Forms.GroupBox();
            this.btnSD = new System.Windows.Forms.Button();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlUstBar.SuspendLayout();
            this.gbKayit.SuspendLayout();
            this.gbGiris.SuspendLayout();
            this.gbKod.SuspendLayout();
            this.gbSD.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUstBar
            // 
            this.pnlUstBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.pnlUstBar.Controls.Add(this.label1);
            this.pnlUstBar.Controls.Add(this.btnMin);
            this.pnlUstBar.Controls.Add(this.btnKapat);
            this.pnlUstBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUstBar.Location = new System.Drawing.Point(0, 0);
            this.pnlUstBar.Name = "pnlUstBar";
            this.pnlUstBar.Size = new System.Drawing.Size(400, 35);
            this.pnlUstBar.TabIndex = 0;
            this.pnlUstBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlUstBar_MouseDown);
            this.pnlUstBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUstBar_MouseMove);
            this.pnlUstBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlUstBar_MouseUp);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "     Güvenli Not Defteri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlUstBar_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUstBar_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlUstBar_MouseUp);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(190)))));
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(320, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 35);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(360, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(40, 35);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // gbKayit
            // 
            this.gbKayit.Controls.Add(this.btnKayitOl);
            this.gbKayit.Controls.Add(this.txtKayitSifre);
            this.gbKayit.Controls.Add(this.label5);
            this.gbKayit.Controls.Add(this.txtEPosta);
            this.gbKayit.Controls.Add(this.label3);
            this.gbKayit.Controls.Add(this.label2);
            this.gbKayit.Location = new System.Drawing.Point(12, 41);
            this.gbKayit.Name = "gbKayit";
            this.gbKayit.Size = new System.Drawing.Size(376, 218);
            this.gbKayit.TabIndex = 1;
            this.gbKayit.TabStop = false;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnKayitOl.FlatAppearance.BorderSize = 0;
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitOl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.Location = new System.Drawing.Point(125, 160);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(123, 38);
            this.btnKayitOl.TabIndex = 7;
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.BackColor = System.Drawing.Color.White;
            this.txtKayitSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKayitSifre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtKayitSifre.ForeColor = System.Drawing.Color.Black;
            this.txtKayitSifre.Location = new System.Drawing.Point(125, 117);
            this.txtKayitSifre.MaxLength = 30;
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.Size = new System.Drawing.Size(186, 29);
            this.txtKayitSifre.TabIndex = 6;
            this.txtKayitSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEPosta_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Şifre:";
            // 
            // txtEPosta
            // 
            this.txtEPosta.BackColor = System.Drawing.Color.White;
            this.txtEPosta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEPosta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEPosta.ForeColor = System.Drawing.Color.Black;
            this.txtEPosta.Location = new System.Drawing.Point(125, 82);
            this.txtEPosta.MaxLength = 100;
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(186, 29);
            this.txtEPosta.TabIndex = 2;
            this.txtEPosta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEPosta_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-Posta:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Görünüşe göre programa kayıtlı değilsiniz.\r\nLütfen kayıt olun.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbGiris
            // 
            this.gbGiris.Controls.Add(this.btnGirisYap);
            this.gbGiris.Controls.Add(this.lblSU);
            this.gbGiris.Controls.Add(this.txtGirisSifre);
            this.gbGiris.Controls.Add(this.label4);
            this.gbGiris.Controls.Add(this.label6);
            this.gbGiris.Location = new System.Drawing.Point(12, 41);
            this.gbGiris.Name = "gbGiris";
            this.gbGiris.Size = new System.Drawing.Size(376, 218);
            this.gbGiris.TabIndex = 2;
            this.gbGiris.TabStop = false;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnGirisYap.Enabled = false;
            this.btnGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(125, 160);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(123, 38);
            this.btnGirisYap.TabIndex = 10;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // lblSU
            // 
            this.lblSU.AutoSize = true;
            this.lblSU.Location = new System.Drawing.Point(122, 126);
            this.lblSU.Name = "lblSU";
            this.lblSU.Size = new System.Drawing.Size(133, 20);
            this.lblSU.TabIndex = 9;
            this.lblSU.TabStop = true;
            this.lblSU.Text = "Şifreni mi unuttun?";
            this.lblSU.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSU_LinkClicked);
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.BackColor = System.Drawing.Color.White;
            this.txtGirisSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGirisSifre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtGirisSifre.ForeColor = System.Drawing.Color.Black;
            this.txtGirisSifre.Location = new System.Drawing.Point(119, 91);
            this.txtGirisSifre.MaxLength = 30;
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.Size = new System.Drawing.Size(186, 29);
            this.txtGirisSifre.TabIndex = 8;
            this.txtGirisSifre.TextChanged += new System.EventHandler(this.txtGirisSifre_TextChanged);
            this.txtGirisSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGirisSifre_KeyDown);
            this.txtGirisSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEPosta_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(44, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 57);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hoş Geldiniz\r\nDevam etmek için lütfen giriş yapın.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbKod
            // 
            this.gbKod.Controls.Add(this.btnKO);
            this.gbKod.Controls.Add(this.txtKod);
            this.gbKod.Controls.Add(this.label7);
            this.gbKod.Controls.Add(this.label8);
            this.gbKod.Location = new System.Drawing.Point(12, 41);
            this.gbKod.Name = "gbKod";
            this.gbKod.Size = new System.Drawing.Size(376, 218);
            this.gbKod.TabIndex = 3;
            this.gbKod.TabStop = false;
            // 
            // btnKO
            // 
            this.btnKO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnKO.Enabled = false;
            this.btnKO.FlatAppearance.BorderSize = 0;
            this.btnKO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKO.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnKO.ForeColor = System.Drawing.Color.White;
            this.btnKO.Location = new System.Drawing.Point(127, 147);
            this.btnKO.Name = "btnKO";
            this.btnKO.Size = new System.Drawing.Size(123, 38);
            this.btnKO.TabIndex = 10;
            this.btnKO.Text = "ONAYLA";
            this.btnKO.UseVisualStyleBackColor = false;
            this.btnKO.Click += new System.EventHandler(this.btnKO_Click);
            // 
            // txtKod
            // 
            this.txtKod.BackColor = System.Drawing.Color.White;
            this.txtKod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKod.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtKod.ForeColor = System.Drawing.Color.Black;
            this.txtKod.Location = new System.Drawing.Point(154, 91);
            this.txtKod.MaxLength = 4;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(116, 29);
            this.txtKod.TabIndex = 8;
            this.txtKod.TextChanged += new System.EventHandler(this.txtKod_TextChanged);
            this.txtKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKod_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kod:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(364, 41);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lütfen E-Posta adresinize gönderilen kodu girin.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSD
            // 
            this.gbSD.Controls.Add(this.btnSD);
            this.gbSD.Controls.Add(this.txtYeniSifre);
            this.gbSD.Controls.Add(this.label9);
            this.gbSD.Controls.Add(this.label10);
            this.gbSD.Location = new System.Drawing.Point(12, 41);
            this.gbSD.Name = "gbSD";
            this.gbSD.Size = new System.Drawing.Size(376, 218);
            this.gbSD.TabIndex = 4;
            this.gbSD.TabStop = false;
            // 
            // btnSD
            // 
            this.btnSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnSD.Enabled = false;
            this.btnSD.FlatAppearance.BorderSize = 0;
            this.btnSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSD.ForeColor = System.Drawing.Color.White;
            this.btnSD.Location = new System.Drawing.Point(109, 149);
            this.btnSD.Name = "btnSD";
            this.btnSD.Size = new System.Drawing.Size(159, 38);
            this.btnSD.TabIndex = 10;
            this.btnSD.Text = "ŞİFREYİ DEĞİŞTİR";
            this.btnSD.UseVisualStyleBackColor = false;
            this.btnSD.Click += new System.EventHandler(this.btnSD_Click);
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.BackColor = System.Drawing.Color.White;
            this.txtYeniSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYeniSifre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtYeniSifre.ForeColor = System.Drawing.Color.Black;
            this.txtYeniSifre.Location = new System.Drawing.Point(144, 91);
            this.txtYeniSifre.MaxLength = 30;
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(168, 29);
            this.txtYeniSifre.TabIndex = 8;
            this.txtYeniSifre.TextChanged += new System.EventHandler(this.txtYeniSifre_TextChanged);
            this.txtYeniSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEPosta_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Yeni Şifre:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(25, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(326, 56);
            this.label10.TabIndex = 0;
            this.label10.Text = "Girdiğiniz kod onaylandı. Lütfen yeni şifrenizi belirleyin.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // giris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 270);
            this.Controls.Add(this.pnlUstBar);
            this.Controls.Add(this.gbGiris);
            this.Controls.Add(this.gbKayit);
            this.Controls.Add(this.gbSD);
            this.Controls.Add(this.gbKod);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 270);
            this.MinimumSize = new System.Drawing.Size(400, 270);
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güvenli Not Defteri";
            this.Load += new System.EventHandler(this.giris_Load);
            this.pnlUstBar.ResumeLayout(false);
            this.gbKayit.ResumeLayout(false);
            this.gbKayit.PerformLayout();
            this.gbGiris.ResumeLayout(false);
            this.gbGiris.PerformLayout();
            this.gbKod.ResumeLayout(false);
            this.gbKod.PerformLayout();
            this.gbSD.ResumeLayout(false);
            this.gbSD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUstBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.GroupBox gbKayit;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbGiris;
        private System.Windows.Forms.TextBox txtGirisSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.LinkLabel lblSU;
        private System.Windows.Forms.GroupBox gbKod;
        private System.Windows.Forms.Button btnKO;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbSD;
        private System.Windows.Forms.Button btnSD;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

