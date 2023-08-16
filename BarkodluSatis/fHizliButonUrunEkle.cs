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
    public partial class fHizliButonUrunEkle : Form
    {
        public fHizliButonUrunEkle()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Context context=new Context();

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if(tUrunAra.Text != "") 
            { 
                string urunad=tUrunAra.Text;
                var urunler=context.Uruns.Where(x=>x.UrunAd.Contains(urunad)).ToList();
                gridUrunler.DataSource = urunler;
                Islemler.GridDüzenle(gridUrunler);
            }
        }

        private void gridUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridUrunler.Rows.Count > 0)
            {
                string barkod = gridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string urunad = gridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                double fiyat = Convert.ToDouble(gridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());
                int id =Convert.ToInt16(lButonId.Text);
                var guncellenecek = context.hizliUruns.Find(id);
                guncellenecek.Barkod= barkod;
                guncellenecek.UrunAd= urunad;
                guncellenecek.Fiyat = fiyat;
                //guncellenecek.Photo="
                context.SaveChanges();
                MessageBox.Show("Ürün Hızlı Butona Eklenmiştir");
                fSatis f = (fSatis)Application.OpenForms["fSatis"];
                if( f != null )
                {
                    Button b = f.Controls.Find("bH" + id, true).FirstOrDefault() as Button;
                    b.Text=urunad + "\n" + fiyat.ToString("C2");
                }

            }
        }

        private void chTümü_CheckedChanged(object sender, EventArgs e)
        {
            if (chTümü.Checked)
            {
                gridUrunler.DataSource = context.Uruns.ToList();
                gridUrunler.Columns["AlisFiyat"].Visible = false;
                gridUrunler.Columns["SatisFiyat"].Visible = false;
                gridUrunler.Columns["KdvOrani"].Visible = false;
                gridUrunler.Columns["KdvTutari"].Visible = false;
                gridUrunler.Columns["Miktar"].Visible = false;
                gridUrunler.Columns["Kullanici"].Visible = false;
                Islemler.GridDüzenle(gridUrunler);
            }
            else
            {
                gridUrunler.DataSource = null;
            }
        }

        private void fHizliButonUrunEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
