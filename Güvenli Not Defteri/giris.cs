using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace Güvenli_Not_Defteri
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        veritabani vt = new veritabani();
        string ksctrl;
        int kod;

        void mail()
        {
            Random r = new Random();
            kod = r.Next(1000, 9999);
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("", "");
                MailMessage mail = new MailMessage();
                mail.To.Add(txtEPosta.Text);
                mail.From = new MailAddress("");
                mail.Subject = "Güvenli Not Defteri - GÜVENLİK KODU";
                mail.Body = "Güvenli Not Defteri Programı için istenen kodunuz: " + kod;
                smtp.Send(mail);
            }
            catch (Exception)
            {
                MessageBox.Show("Kod gönderimi sırasında hata ile karşılaşıldı!\nHata Kodu: giris_mail", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEPosta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblSU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gbGiris.Visible = false;
            gbKayit.Visible = false;
            gbSD.Visible = false;
            gbKod.Visible = true;
            Thread tm = new Thread(mail);
            tm.Start();
        }

        private void txtKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar);
        }

        private void txtKod_TextChanged(object sender, EventArgs e)
        {
            if (txtKod.Text == "" || txtKod.Text == null)
                btnKO.Enabled = false;
            else
                btnKO.Enabled = true;
        }

        private void txtGirisSifre_TextChanged(object sender, EventArgs e)
        {
            if (txtGirisSifre.Text == "" || txtGirisSifre.Text == null)
                btnGirisYap.Enabled = false;
            else
                btnGirisYap.Enabled = true;
        }

        private void txtYeniSifre_TextChanged(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text == "" || txtYeniSifre.Text == null)
                btnSD.Enabled = false;
            else
                btnSD.Enabled = true;
        }

        private void giris_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            if (vt.kayitdurum() == 0)
            {
                gbGiris.Visible = false;
                gbKayit.Visible = true;
                gbKod.Visible = false;
                gbSD.Visible = false;
            }
            else
            {
                txtEPosta.Text = vt.epostacek();
                gbGiris.Visible = true;
                gbKayit.Visible = false;
                gbKod.Visible = false;
                gbSD.Visible = false;
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtEPosta.Text.Contains("@") == true && txtKayitSifre.Text != "")
            {
                Thread tm = new Thread(mail);
                tm.Start();
                gbGiris.Visible = false;
                gbKayit.Visible = false;
                gbSD.Visible = false;
                gbKod.Visible = true;
                ksctrl = "k";
            }
            else
                MessageBox.Show("Lütfen geçerli bir E-Posta adresi veya şifre girin!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnKO_Click(object sender, EventArgs e)
        {
            if (txtKod.Text == kod.ToString())
            {
                if (ksctrl == "k")
                {
                    vt.kayit(txtEPosta.Text, txtKayitSifre.Text);
                    ksctrl = "";
                    txtKayitSifre.Clear();
                    txtKod.Clear();
                    gbGiris.Visible = true;
                    gbKayit.Visible = false;
                    gbKod.Visible = false;
                    gbSD.Visible = false;
                }
                else
                {
                    gbGiris.Visible = false;
                    gbKayit.Visible = false;
                    gbKod.Visible = false;
                    gbSD.Visible = true;
                }
            }
            else
                MessageBox.Show("Girdiğiniz kod yanlış! Lütfen E-Posta adresinize gönderilen kodu girin!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSD_Click(object sender, EventArgs e)
        {
            vt.sifredegistir(txtYeniSifre.Text);
            txtYeniSifre.Clear();
            txtKod.Clear();
            gbGiris.Visible = true;
            gbKayit.Visible = false;
            gbKod.Visible = false;
            gbSD.Visible = false;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            bool giriskontrol = vt.giris(txtGirisSifre.Text);
            if (giriskontrol == true)
            {
                anaform af = new anaform();
                af.Show();
                this.Hide();
            }
        }

        bool surukle;
        Point nokta;

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

        private void pnlUstBar_MouseUp(object sender, MouseEventArgs e)
        {
            surukle = false;
        }

        private void txtGirisSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGirisYap.PerformClick();
            }
        }
    }
}