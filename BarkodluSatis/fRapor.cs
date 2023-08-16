using BarkodluSatis.Dal;
using Microsoft.EntityFrameworkCore;
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
    public partial class fRapor : Form
    {
        public fRapor()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        public void bGöster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; //fare yuvarlak olacak
            DateTime baslangic = DateTime.Parse(dBaslangıc.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dBitiş.Value.ToShortDateString());
            bitis = bitis.AddDays(1);
            using (var context = new Context())
            {
                if (listFiltrelemeTuru.SelectedIndex == 0)
                {
                    context.ıslemOzets.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();
                    var islemozet = context.ıslemOzets.Local.ToBindingList();
                    Islemler.GridDüzenle(gridList);
                    gridList.DataSource = islemozet;

                    tSatisNakit.Text = islemozet.Where(x => x.Iade == 0 && x.Gelir == 0 && x.Gider == 0).Sum(x => x.Nakit).ToString("C2");
                    tSatisKart.Text = islemozet.Where(x => x.Iade == 0 && x.Gelir == 0 && x.Gider == 0).Sum(x => x.Kart).ToString("C2");


                    tİadeNakit.Text = islemozet.Where(x => x.Iade == 1).Sum(x => x.Nakit).ToString("C2");
                    tİadeKart.Text = islemozet.Where(x => x.Iade == 1).Sum(x => x.Kart).ToString("C2");

                    tGelirNakit.Text = islemozet.Where(x => x.Gelir == 1).Sum(x => x.Nakit).ToString("C2");
                    tGelirKart.Text = islemozet.Where(x => x.Gelir == 1).Sum(x => x.Kart).ToString("C2");

                    tGiderNakit.Text = islemozet.Where(x => x.Gider == 1).Sum(x => x.Nakit).ToString("C2");
                    tGiderKart.Text = islemozet.Where(x => x.Gider == 1).Sum(x => x.Kart).ToString("C2");

                    context.satis.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                    var satistablosu = context.satis.Local.ToBindingList();
                    Islemler.GridDüzenle(gridList);
                    double kdvtutarisatıs = satistablosu.Where(x => x.Iade == 0).Sum(x => x.KdvTutari);
                    double kdvtutariiade = satistablosu.Where(x => x.Iade == 1).Sum(x => x.KdvTutari);
                    tKdvToplam.Text = (kdvtutarisatıs - kdvtutariiade).ToString("C2");
                }
                else if (listFiltrelemeTuru.SelectedIndex == 1)
                {
                    context.ıslemOzets.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == 0 && x.Gelir == 0 && x.Gider == 0).Load();
                    var islemozet = context.ıslemOzets.Local.ToBindingList();
                    gridList.DataSource = islemozet;
                }
                else if (listFiltrelemeTuru.SelectedIndex == 2)
                {
                    context.ıslemOzets.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == 1).Load();
                    gridList.DataSource = context.ıslemOzets.Local.ToBindingList();
                }
                else if (listFiltrelemeTuru.SelectedIndex == 3)
                {
                    context.ıslemOzets.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gelir == 1).Load();
                    gridList.DataSource = context.ıslemOzets.Local.ToBindingList();
                }
                else if (listFiltrelemeTuru.SelectedIndex == 4)
                {
                    context.ıslemOzets.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gider == 1).Load();
                    gridList.DataSource = context.ıslemOzets.Local.ToBindingList();
                }
            }
            Islemler.GridDüzenle(gridList);
            Cursor.Current = Cursors.Default; // fare düzelecek
        }

        private void fRapor_Load(object sender, EventArgs e)
        {
            listFiltrelemeTuru.SelectedIndex = 0;
            tKartKomisyon.Text = Islemler.Komisyon().ToString();
            bGöster_Click(null, null);
        }

        //true false yapma
        private void gridList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if(e.ColumnIndex == 3)
            //{
            //    if(e.Value is bool)
            //    {
            //        bool value=(bool)e.Value;
            //        e.Value = (value) ? "Evet" : "Hayır";
            //        e.FormattingApplied = true;
            //    }
            //}
        }

        private void bGelirEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.gelirgider = "GELİR";
            f.kullanici = lkullanıcı.Text;
            f.ShowDialog();
        }

        private void bGiderEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.gelirgider = "GİDER";
            f.kullanici = lkullanıcı.Text;
            f.ShowDialog();
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridList.Rows.Count > 0)
            {
                int islemno = Convert.ToInt32(gridList.CurrentRow.Cells["IslemNo"].Value.ToString());
                if (islemno != 0)
                {
                    fDetayGöster f = new fDetayGöster();
                    f.islemNo = islemno;
                    f.ShowDialog();
                }
            }
        }

        private void bRaporAl_Click(object sender, EventArgs e)
        {
            Raporlar.Baslik = "Genel Rapor";
            Raporlar.SatisNakit = tSatisNakit.Text;
            Raporlar.SatisKart = tSatisKart.Text;
            Raporlar.IadeKart = tİadeKart.Text;
            Raporlar.IadeNakit = tİadeNakit.Text;
            Raporlar.GelirKart = tGelirKart.Text;
            Raporlar.GelirNakit = tGelirNakit.Text;
            Raporlar.GiderNakit = tGiderNakit.Text;
            Raporlar.GiderKart = tGiderKart.Text;
            Raporlar.TarihBaslangic = dBaslangıc.Value.ToShortDateString();
            Raporlar.TarihBitis = dBitiş.Value.ToShortDateString();
            Raporlar.KdvToplam = tKdvToplam.Text;
            Raporlar.KartKomisyon = tKartKomisyon.Text;
            Raporlar.RaporSayfasiRaporu(gridList);
        }
    }
}
