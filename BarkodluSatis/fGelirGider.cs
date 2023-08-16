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
    public partial class fGelirGider : Form
    {
        public fGelirGider()
        {
            InitializeComponent();
        }
        public string gelirgider { get; set; }
        public string kullanici { get; set; }
        private void fGelirGider_Load(object sender, EventArgs e)
        {
            lGelirGider.Text = gelirgider + "İŞLEMİ YAPILIYOR";
        }

        private void cmbOdemeTürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdemeTürü.SelectedIndex == 0)
            {
                tNakit.Enabled = true;
                tKart.Enabled = false;
            }
            else if (cmbOdemeTürü.SelectedIndex == 1)
            {
                tNakit.Enabled = false;
                tKart.Enabled = true;
            }
            else if (cmbOdemeTürü.SelectedIndex == 2)
            {
                tNakit.Enabled = true;
                tKart.Enabled = true;
            }
            tNakit.Text = "0";
            tKart.Text = "0";
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (cmbOdemeTürü.Text != "")
            {
                if (tNakit.Text != "" && tKart.Text != "" /*&& (tNakit.Text!="0" && tKart.Text != "0")*/)
                {
                    using (var db = new Context())
                    {
                        IslemOzet ıslemOzet = new IslemOzet();
                        ıslemOzet.IslemNo = 0;
                        ıslemOzet.Iade = Convert.ToByte(false);
                        ıslemOzet.OdemeSekli = tNakit.Text;
                        ıslemOzet.Kart = Islemler.DoubleYap(tKart.Text);
                        if (gelirgider == "GELİR")
                        {
                            ıslemOzet.Gelir = 1;
                            ıslemOzet.Gider = 0;
                        }
                        else
                        {
                            ıslemOzet.Gelir = 0;
                            ıslemOzet.Gider = 1;
                        }
                        ıslemOzet.AlisFiyatToplam = 0;
                        ıslemOzet.Aciklama = gelirgider + " - İşlemi " + tAçıklama.Text;
                        ıslemOzet.Tarih = date.Value;
                        ıslemOzet.Kullanici = kullanici;
                        db.ıslemOzets.Add(ıslemOzet);
                        db.SaveChanges();
                        MessageBox.Show(gelirgider + " işlemi kaydedildi ");
                        tNakit.Text = "0";
                        tKart.Text = "0";
                        tAçıklama.Clear();
                        cmbOdemeTürü.Text = "";
                        fRapor f = (fRapor)Application.OpenForms["fRapor"];
                        if(f != null)
                        {
                            f.bGöster_Click(null, null);
                        }
                        this.Hide();

                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ödeme Türünü Seçiniz");
            }
        }
    }
}
