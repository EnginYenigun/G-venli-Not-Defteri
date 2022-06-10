using System;
using System.Windows.Forms;

namespace Güvenli_Not_Defteri
{
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }

        veritabani vt = new veritabani();

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            Properties.Settings.Default.f = fontDialog.Font;
            Properties.Settings.Default.fr = fontDialog.Color;
            Properties.Settings.Default.Save();
        }

        private void pbFormBasligi_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            pbFormBasligi.BackColor = colorDialog.Color;
            Properties.Settings.Default.fbr = pbFormBasligi.BackColor;
            Properties.Settings.Default.Save();
        }

        private void pbArkaPlanRenk_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            pbArkaPlanRenk.BackColor = colorDialog.Color;
            Properties.Settings.Default.ap = pbArkaPlanRenk.BackColor;
            Properties.Settings.Default.Save();
        }

        private void ayarlar_Load(object sender, EventArgs e)
        {
            pbArkaPlanRenk.BackColor = Properties.Settings.Default.ap;
            pbFormBasligi.BackColor = Properties.Settings.Default.fbr;
            vt.bilgicek();
            txtEPosta.Text = vt.eposta;
            txtSifre.Text = vt.sifre;
        }

        private void btnHesapGuncelle_Click(object sender, EventArgs e)
        {
            vt.hesapguncelle(txtEPosta.Text, txtSifre.Text);
        }
    }
}