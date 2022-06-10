namespace Güvenli_Not_Defteri
{
    partial class anaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaform));
            this.pnlUstBar = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.rtbMetin = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnSabitle = new System.Windows.Forms.Button();
            this.lblSonKayit = new System.Windows.Forms.Label();
            this.tmrOtoKayit = new System.Windows.Forms.Timer(this.components);
            this.tmrAyarGuncelle = new System.Windows.Forms.Timer(this.components);
            this.pnlUstBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUstBar
            // 
            this.pnlUstBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(190)))));
            this.pnlUstBar.Controls.Add(this.btnMin);
            this.pnlUstBar.Controls.Add(this.btnKapat);
            this.pnlUstBar.Controls.Add(this.label1);
            this.pnlUstBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUstBar.ForeColor = System.Drawing.Color.Black;
            this.pnlUstBar.Location = new System.Drawing.Point(0, 0);
            this.pnlUstBar.Name = "pnlUstBar";
            this.pnlUstBar.Size = new System.Drawing.Size(430, 35);
            this.pnlUstBar.TabIndex = 0;
            this.pnlUstBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlUstBar_MouseDown);
            this.pnlUstBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUstBar_MouseMove);
            this.pnlUstBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlUstBar_MouseUp);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(170)))));
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(360, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(35, 35);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(395, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(35, 35);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
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
            this.label1.Size = new System.Drawing.Size(240, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güvenli Not Defteri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlUstBar_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUstBar_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlUstBar_MouseUp);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(12, 50);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(250, 25);
            this.dtp.TabIndex = 1;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // rtbMetin
            // 
            this.rtbMetin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMetin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMetin.Location = new System.Drawing.Point(12, 90);
            this.rtbMetin.Name = "rtbMetin";
            this.rtbMetin.Size = new System.Drawing.Size(406, 222);
            this.rtbMetin.TabIndex = 2;
            this.rtbMetin.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(388, 49);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(30, 30);
            this.btnKaydet.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnKaydet, "KAYDET");
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.BackgroundImage")));
            this.btnAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAyarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Location = new System.Drawing.Point(352, 46);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(30, 30);
            this.btnAyarlar.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnAyarlar, "AYARLAR");
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnSabitle
            // 
            this.btnSabitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSabitle.BackColor = System.Drawing.Color.Transparent;
            this.btnSabitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSabitle.BackgroundImage")));
            this.btnSabitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSabitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSabitle.FlatAppearance.BorderSize = 0;
            this.btnSabitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSabitle.Location = new System.Drawing.Point(316, 46);
            this.btnSabitle.Name = "btnSabitle";
            this.btnSabitle.Size = new System.Drawing.Size(30, 30);
            this.btnSabitle.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnSabitle, "ÜSTTE TUT");
            this.btnSabitle.UseVisualStyleBackColor = false;
            this.btnSabitle.Click += new System.EventHandler(this.btnSabitle_Click);
            // 
            // lblSonKayit
            // 
            this.lblSonKayit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSonKayit.AutoSize = true;
            this.lblSonKayit.ForeColor = System.Drawing.Color.Gray;
            this.lblSonKayit.Location = new System.Drawing.Point(6, 316);
            this.lblSonKayit.Name = "lblSonKayit";
            this.lblSonKayit.Size = new System.Drawing.Size(93, 17);
            this.lblSonKayit.TabIndex = 5;
            this.lblSonKayit.Text = "Son Kayıt: YOK";
            // 
            // tmrOtoKayit
            // 
            this.tmrOtoKayit.Enabled = true;
            this.tmrOtoKayit.Interval = 1000;
            this.tmrOtoKayit.Tick += new System.EventHandler(this.tmrOtoKayit_Tick);
            // 
            // tmrAyarGuncelle
            // 
            this.tmrAyarGuncelle.Enabled = true;
            this.tmrAyarGuncelle.Interval = 2000;
            this.tmrAyarGuncelle.Tick += new System.EventHandler(this.tmrAyarGuncelle_Tick);
            // 
            // anaform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 340);
            this.Controls.Add(this.btnSabitle);
            this.Controls.Add(this.lblSonKayit);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rtbMetin);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.pnlUstBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 340);
            this.Name = "anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güvenli Not Defteri";
            this.Load += new System.EventHandler(this.anaform_Load);
            this.pnlUstBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUstBar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Label lblSonKayit;
        private System.Windows.Forms.Timer tmrOtoKayit;
        public System.Windows.Forms.RichTextBox rtbMetin;
        private System.Windows.Forms.Timer tmrAyarGuncelle;
        private System.Windows.Forms.Button btnSabitle;
    }
}