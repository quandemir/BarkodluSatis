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
    public partial class fBaslangic : Form
    {
        public fBaslangic()
        {
            InitializeComponent();
        }

        private void bSatisİslemi_Click(object sender, EventArgs e)
        {
            fSatis f = new fSatis();
            f.lKullanıcı.Text = lKullanıcı.Text;
            f.ShowDialog(); 
        }

        private void bRaporlar_Click(object sender, EventArgs e)
        {
            fRapor f = new fRapor();
            f.lkullanıcı.Text = lKullanıcı.Text;
            f.ShowDialog();
        }

        private void bStokTakibi_Click(object sender, EventArgs e)
        {
            fStok f = new fStok();
            f.lKullanici.Text = lKullanıcı.Text;
            f.ShowDialog();
        }

        private void bUrunGiris_Click(object sender, EventArgs e)
        {
            fUrunGırıs f = new fUrunGırıs();
            f.lKullanici.Text = lKullanıcı.Text;
            f.ShowDialog();
        }

        private void bBarkodluTerazi_Click(object sender, EventArgs e)
        {

        }

        private void bAyarlar_Click(object sender, EventArgs e)
        {
            fAyarlar f = new fAyarlar();
            f.ShowDialog();
        }

        private void bFiyatGuncelle_Click(object sender, EventArgs e)
        {
            fFiyatGuncelle f = new fFiyatGuncelle();
            f.ShowDialog();
        }

        private void bYedekle_Click(object sender, EventArgs e)
        {
            Islemler.BackUp();
        }

        private void bKullanıcıDeğistir_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin();
            login.Show();
            this.Hide();
        }

        private void fBaslangic_Load(object sender, EventArgs e)
        {

        }

        private void bYedekle_Click_1(object sender, EventArgs e)
        {
            Islemler.BackUp();
        }
    }
}
