using BarkodluSatis.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void bGiris_Click(object sender, EventArgs e)
        {
            GirisYap();
        }
        private void GirisYap()
        {
            if (tKullanıcıadı.Text != "" && tSifre.Text != "")
            {
                try
                {
                    using (var db = new Context())
                    {
                        if (db.kullanicis.Any())
                        {
                            var bak = db.kullanicis.Where(x => x.KullaniciAdi == tKullanıcıadı.Text && x.Sifre == tSifre.Text).FirstOrDefault();
                            if (bak != null)
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                fBaslangic f = new fBaslangic();
                                f.bSatisİslemi.Enabled = Convert.ToBoolean(bak.Satış);
                                f.bRaporlar.Enabled = Convert.ToBoolean(bak.Rapor);
                                f.bStokTakibi.Enabled = Convert.ToBoolean(bak.Stok);
                                f.bUrunGiris.Enabled = Convert.ToBoolean(bak.UrunGiris);
                                f.bAyarlar.Enabled = Convert.ToBoolean(bak.Ayarlar);
                                f.bFiyatGuncelle.Enabled = Convert.ToBoolean(bak.FiyatGuncelle);
                                f.bYedekle.Enabled = Convert.ToBoolean(bak.Yedekleme);
                                f.lKullanıcı.Text = bak.AdSoyad;

                                f.Show();
                                this.Hide();
                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Giriş");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GirisYap();
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
