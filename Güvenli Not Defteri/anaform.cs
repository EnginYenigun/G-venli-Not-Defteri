using System;
using System.Drawing;
using System.Windows.Forms;

namespace Güvenli_Not_Defteri
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        veritabani vt = new veritabani();
        ayarlar a = new ayarlar();

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            rtbMetin.Text = vt.notgoster(dtp.Text);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            vt.kaydet(rtbMetin.Text, dtp.Text);
            Application.Exit();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            vt.kaydet(rtbMetin.Text, dtp.Text);
            sayac = 0;
            lblSonKayit.Text = "Son Kayıt: " + DateTime.Now.ToLongTimeString();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            a.ShowDialog();
        }

        private void anaform_Load(object sender, EventArgs e)
        {
            rtbMetin.BackColor = Properties.Settings.Default.ap;
            rtbMetin.Font = Properties.Settings.Default.f;
            rtbMetin.ForeColor = Properties.Settings.Default.fr;
            pnlUstBar.BackColor = Properties.Settings.Default.fbr;
            rtbMetin.Text = vt.notgoster(dtp.Text);
        }
        bool surukle;
        Point nokta;
        private void pnlUstBar_MouseUp(object sender, MouseEventArgs e)
        {
            surukle = false;
        }

        private void pnlUstBar_MouseDown(object sender, MouseEventArgs e)
        {
            surukle = true;
            nokta = e.Location;
        }

        private void pnlUstBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukle)
            {
                Point csp = PointToScreen(e.Location);
                Location = new Point(csp.X - nokta.X, csp.Y - nokta.Y);
            }
        }
        int sayac = 0;
        private void tmrOtoKayit_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 30)
            {
                sayac = 0;
                vt.kaydet(rtbMetin.Text, dtp.Text);
                lblSonKayit.Text = "Son Kayıt: " + DateTime.Now.ToLongTimeString();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tmrAyarGuncelle_Tick(object sender, EventArgs e)
        {
            rtbMetin.BackColor = Properties.Settings.Default.ap;
            rtbMetin.Font = Properties.Settings.Default.f;
            rtbMetin.ForeColor = Properties.Settings.Default.fr;
            pnlUstBar.BackColor = Properties.Settings.Default.fbr;
        }
        bool sabitle = false;
        private void btnSabitle_Click(object sender, EventArgs e)
        {
            if (sabitle == false)
            {
                sabitle = true;
                TopMost = true;
            }
            else
            {
                sabitle = false;
                TopMost = false;
            }
        }
    }
}