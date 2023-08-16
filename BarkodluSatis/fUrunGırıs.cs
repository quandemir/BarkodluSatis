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
    public partial class fUrunGırıs : Form
    {
        public fUrunGırıs()
        {
            InitializeComponent();
        }
        Context context = new Context();
        private void fUrunGırıs_Load(object sender, EventArgs e)
        {
            tUrunSayisi.Text = context.Uruns.Count().ToString();
            gridUrunlerr.DataSource = context.Uruns.OrderByDescending(x => x.UrunId).Take(20).ToList();
            Islemler.GridDüzenle(gridUrunlerr);
            GrupDoldur();
        }
        public void GrupDoldur()
        {
            cmbUrunGrubu.DisplayMember = "UrunGrupAd";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = context.urunGrups.OrderBy(x => x.UrunGrupAd).ToList();
        }

        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = tBarkod.Text.Trim();
                if (context.Uruns.Any(x => x.Barkod == barkod))
                {
                    var urun = context.Uruns.Where(x => x.Barkod == barkod).SingleOrDefault();
                    tUrunAdı.Text = urun.UrunAd;
                    tAciklama.Text = urun.Aciklama;
                    cmbUrunGrubu.Text = urun.UrunGrup;
                    tAlisFiyati.Text = urun.AlisFiyat.ToString();
                    tSatisFiyati.Text = urun.SatisFiyat.ToString();
                    tMiktar.Text = urun.Miktar.ToString();
                    tKDVOrani.Text = urun.KdvTutari.ToString();
                    if (urun.Birim == "Kg")
                    {
                        chBarkodluUrunİslemi.Checked = true;
                    }
                    else
                    {
                        chBarkodluUrunİslemi.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Ürün kayıtlı değil!! Kaydedebilirsinizz");
                }
            }
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (tBarkod.Text != "" && tUrunAdı.Text != "" && cmbUrunGrubu.Text != "" && tAlisFiyati.Text != "" && tSatisFiyati.Text != "" && tKDVOrani.Text != "" && tMiktar.Text != "")
            {
                if (context.Uruns.Any(x => x.Barkod == tBarkod.Text))
                {
                    var guncelle = context.Uruns.Where(x => x.Barkod == tBarkod.Text).SingleOrDefault();
                    guncelle.Barkod = tBarkod.Text;
                    guncelle.UrunAd = tUrunAdı.Text;
                    guncelle.Aciklama = tAciklama.Text;
                    guncelle.UrunGrup = cmbUrunGrubu.Text;
                    guncelle.AlisFiyat = Convert.ToDouble(tAlisFiyati.Text);
                    guncelle.SatisFiyat = Convert.ToDouble(tSatisFiyati.Text);
                    guncelle.KdvOrani = Convert.ToInt32(tKDVOrani.Text);
                    guncelle.KdvTutari = Math.Round(Convert.ToDouble(tSatisFiyati.Text) * Convert.ToInt32(tKDVOrani.Text));
                    guncelle.Miktar += Convert.ToDouble(tMiktar.Text);
                    guncelle.Onay =1;
                    if (chBarkodluUrunİslemi.Checked)
                    {
                        guncelle.Birim = "Kg";
                    }
                    else
                    {
                        guncelle.Birim = "Birim";
                    }
                    guncelle.Tarih = DateTime.Now;
                    guncelle.Kullanici = lKullanici.Text;
                    context.SaveChanges();
                    gridUrunlerr.DataSource = context.Uruns.OrderByDescending(x => x.UrunId).Take(10).ToList();
                    Islemler.GridDüzenle(gridUrunlerr);
                }
                else
                {
                    var birim = "";
                    if (chBarkodluUrunİslemi.Checked)
                    {
                        birim = "Kg";
                    }
                    else
                    {
                        birim = "Birim";
                    }
                    Urun urun = new Urun()
                    {
                        Barkod = tBarkod.Text,
                        UrunAd = tUrunAdı.Text,
                        Aciklama = tAciklama.Text,
                        UrunGrup = cmbUrunGrubu.Text,
                        AlisFiyat = Convert.ToDouble(tAlisFiyati.Text),
                        SatisFiyat = Convert.ToDouble(tSatisFiyati.Text),
                        KdvOrani = Convert.ToInt32(tKDVOrani.Text),
                        KdvTutari = Math.Round(Convert.ToDouble(tSatisFiyati.Text) * Convert.ToInt32(tKDVOrani.Text)),
                        Miktar = Convert.ToDouble(tMiktar.Text),
                        Birim = birim,
                        Tarih = DateTime.Now,
                        Kullanici = lKullanici.Text,
                        Onay = 1,
                       
                    };
                    context.Add(urun);
                    context.SaveChanges();
                    if (tBarkod.Text.Length == 8)
                    {
                        var ozelbarkod = context.barkods.First();
                        ozelbarkod.BarkodNo += 1;
                        context.SaveChanges();
                    }

                    gridUrunlerr.DataSource = context.Uruns.OrderByDescending(x => x.UrunId).Take(20).ToList();
                    Islemler.GridDüzenle(gridUrunlerr);
                }
                Islemler.StokHareket(tBarkod.Text, tUrunAdı.Text, "Adet", Convert.ToDouble(tMiktar.Text), cmbUrunGrubu.Text, lKullanici.Text);
                Temizle();
            }
            else
            {
                MessageBox.Show("Ürün bilgilerini kontrol ediniz");
                tBarkod.Focus();
            }
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            string urunad = tUrunAra.Text;
            gridUrunlerr.DataSource = context.Uruns.Where(x => x.UrunAd.Contains(urunad)).ToList();
            Islemler.GridDüzenle(gridUrunlerr);
        }

        private void bİptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            tBarkod.Clear();
            tUrunAdı.Clear();
            tAciklama.Clear();
            tAlisFiyati.Text = "0";
            tSatisFiyati.Text = "0";
            tMiktar.Text = "0";
            tKDVOrani.Text = "8";
            tBarkod.Focus();
            chBarkodluUrunİslemi.Checked = false;
        }

        private void bUrunGrubuEkle_Click(object sender, EventArgs e)
        {
            fUrunGrubuEkle f = new fUrunGrubuEkle();
            f.ShowDialog();
        }

        private void bBarkodOlustur_Click(object sender, EventArgs e)
        {
            if (chBarkodluUrunİslemi.Checked)
            {
                var barkodno = context.barkods.First();
                int karakter = barkodno.BarkodNo.ToString().Length;
                string sifirlar = string.Empty;
                for (int i = 0; i < 5 - karakter; i++)
                {
                    sifirlar = sifirlar + "0";
                }
                string olusanbarkod = sifirlar + barkodno.BarkodNo.ToString();
                tBarkod.Text = olusanbarkod;
                tUrunAdı.Focus();
            }
            else
            {
                var barkodno = context.barkods.First();
                int karakter = barkodno.BarkodNo.ToString().Length;
                string sifirlar = string.Empty;
                for (int i = 0; i < 8 - karakter; i++)
                {
                    sifirlar = sifirlar + "0";
                }
                string olusanbarkod = sifirlar + barkodno.BarkodNo.ToString();
                tBarkod.Text = olusanbarkod;
                tUrunAdı.Focus();
            }
            
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridUrunlerr.Rows.Count > 0)
            {
                int urunid = Convert.ToInt32(gridUrunlerr.CurrentRow.Cells["UrunId"].Value.ToString());
                string urunad = gridUrunlerr.CurrentRow.Cells["UrunAd"].Value.ToString();
                string barkod = gridUrunlerr.CurrentRow.Cells["Barkod"].Value.ToString();
                DialogResult onay = MessageBox.Show(urunad + "ürünü silmek istiyor musunuz?", "Ürün Silme İşlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    var urun = context.Uruns.Find(urunid);
                    context.Uruns.Remove(urun);
                    context.SaveChanges();
                    var hızliürün = context.hizliUruns.Where(x => x.Barkod == barkod).SingleOrDefault();
                    hızliürün.Barkod = "-";
                    hızliürün.UrunAd = "-";
                    hızliürün.Fiyat = 0;
                    context.SaveChanges();
                    MessageBox.Show("Ürün Silinmiştir");
                    gridUrunlerr.DataSource = context.Uruns.OrderByDescending(x => x.UrunId).Take(20).ToList();
                    Islemler.GridDüzenle(gridUrunlerr);
                    tBarkod.Focus();
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chBarkodluUrunİslemi_CheckedChanged(object sender, EventArgs e)
        {
            if(chBarkodluUrunİslemi.Checked)
            {
                chBarkodluUrunİslemi.Text = "Gramajlı Ürün İşlemi";
                //bBarkodOlustur.Enabled= false;
            }
            else
            {
                chBarkodluUrunİslemi.Text = "Barkodlu Ürün İşlemi";
                //bBarkodOlustur.Enabled = true;
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(gridUrunlerr.Rows.Count > 0)
            {
                tBarkod.Text = gridUrunlerr.CurrentRow.Cells["Barkod"].Value.ToString();
                tUrunAdı.Text = gridUrunlerr.CurrentRow.Cells["UrunAd"].Value.ToString();
                tAciklama.Text = gridUrunlerr.CurrentRow.Cells["Aciklama"].Value.ToString();
                cmbUrunGrubu.Text = gridUrunlerr.CurrentRow.Cells["UrunGrup"].Value.ToString();
                tAlisFiyati.Text = gridUrunlerr.CurrentRow.Cells["AlisFiyat"].Value.ToString();
                tSatisFiyati.Text = gridUrunlerr.CurrentRow.Cells["SatisFiyat"].Value.ToString();
                tMiktar.Text = gridUrunlerr.CurrentRow.Cells["Miktar"].Value.ToString();
                tKDVOrani.Text = gridUrunlerr.CurrentRow.Cells["KdvOrani"].Value.ToString();
                string birim= gridUrunlerr.CurrentRow.Cells["Birim"].Value.ToString();
                if (birim == "Kg")
                {
                    chBarkodluUrunİslemi.Checked=true;
                }
                else
                {
                    chBarkodluUrunİslemi.Checked = false;
                }
            }
        }



        //private void tSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if(char.IsDigit(e.KeyChar)==false&&e.KeyChar!=(char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)45)
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
