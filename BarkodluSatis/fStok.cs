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
    public partial class fStok : Form
    {
        public fStok()
        {
            InitializeComponent();
        }
        Context c=new Context();

        private void bAra_Click(object sender, EventArgs e)
        {
            gridList.DataSource = null;
            using (var c=new Context())
            {
                if (cmbİşlemTürü.Text != "")
                {
                    string urungrubu = cmbÜrünGrubu.Text;
                    if (cmbİşlemTürü.SelectedIndex == 0)
                    {
                        if (rdTümü.Checked)
                        {
                            c.Uruns.OrderBy(x => x.Miktar).Load();
                            gridList.DataSource = c.Uruns.Local.ToBindingList(); //bu column sıralaması içindir
                        }
                        else if (rdUrunGrubunaGöre.Checked)
                        {
                            c.Uruns.Where(x => x.UrunGrup == urungrubu).OrderBy(x=>x.Miktar).Load();
                            gridList.DataSource=c.Uruns.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Filtreleme Türünü Seçiniz");
                        }
                        
                    }else if (cmbİşlemTürü.SelectedIndex == 1)
                    {
                        DateTime baslangıc = DateTime.Parse(dateBaslangıc.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(dateBitiş.Value.ToShortDateString());
                        bitis=bitis.AddDays(1);
                        if (rdTümü.Checked)
                        {
                            c.stokHarekets.OrderByDescending(x => x.datetime).Where(x => x.datetime >= baslangıc && x.datetime <= bitis).Load();
                            gridList.DataSource = c.stokHarekets.Local.ToBindingList();
                        }
                        else if (rdUrunGrubunaGöre.Checked)
                        {
                            c.stokHarekets.OrderByDescending(x=>x.datetime).Where(x=>x.datetime>=baslangıc && x.datetime <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                            gridList.DataSource = c.stokHarekets.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Filtreleme Türünü Seçiniz");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("İşlem Türünü Seçiniz");
                }
            }
            Islemler.GridDüzenle(gridList);
        }

        private void fStok_Load(object sender, EventArgs e)
        {
            //başlangıçta urun grubunu dolduruyorum
            cmbÜrünGrubu.DisplayMember = "UrunGrupAd";
            cmbÜrünGrubu.ValueMember = "Id";
            cmbÜrünGrubu.DataSource=c.urunGrups.ToList();
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text.Length >= 3)
            {
                string urunad=tUrunAra.Text;
                using(var c=new Context())
                {
                    if (cmbİşlemTürü.SelectedIndex == 0)
                    {
                        c.Uruns.Where(x=>x.UrunAd.Contains(urunad)).Load();
                        gridList.DataSource=c.Uruns.Local.ToBindingList();
                    }
                    else if (cmbİşlemTürü.SelectedIndex == 1)
                    {
                        c.stokHarekets.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridList.DataSource = c.stokHarekets.Local.ToBindingList();
                    }
                }
                Islemler.GridDüzenle(gridList);
            }
        }
    }
}
