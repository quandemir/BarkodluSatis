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
    public partial class fFiyatGuncelle : Form
    {
        public fFiyatGuncelle()
        {
            InitializeComponent();
        }

        private void tBarkod_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                using(var db=new Context())
                {
                    if (db.Uruns.Any(x => x.Barkod == tBarkod.Text))
                    {
                        var getir=db.Uruns.Where(x=>x.Barkod==tBarkod.Text).SingleOrDefault();
                        lBarkod.Text = getir.Barkod;
                        lUrunAd.Text = getir.UrunAd;
                        double mevcutfiyat=Convert.ToDouble(getir.SatisFiyat);
                        lFiyat.Text= mevcutfiyat.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Ürün Kayıtlı Değil");
                    }
                }
            }
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if(tYeniFiyat.Text!="" && lBarkod.Text != "")
            {
                using(var db =new Context())
                {
                    var guncellenecek=db.Uruns.Where(x=>x.Barkod==lBarkod.Text).SingleOrDefault();
                    guncellenecek.SatisFiyat = Islemler.DoubleYap(tYeniFiyat.Text);
                    int kvdorani = guncellenecek.KdvOrani;
                    Math.Round(Islemler.DoubleYap(tYeniFiyat.Text) * kvdorani / 100, 2);
                    db.SaveChanges();
                    MessageBox.Show("Yeni Fiyat Kaydedildi");
                    lBarkod.Text = "";
                    lUrunAd.Text = "";
                    lFiyat.Text = "";
                    tBarkod.Text = "";
                    tYeniFiyat.Text = "";
                    tBarkod.Clear();
                    tBarkod.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ürün okutunuz");
                tBarkod.Focus();
            }
        }

        private void fFiyatGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
