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
    public partial class fUrunGrubuEkle : Form
    {
        public fUrunGrubuEkle()
        {
            InitializeComponent();
        }
        Context context = new Context();

        private void bUrunGrubuEkle_Click(object sender, EventArgs e)
        {
            if (tUrunGrupAdi.Text != "")
            {
                UrunGrup urunGrup = new UrunGrup()
                {
                    UrunGrupAd = tUrunGrupAdi.Text
                };
                context.Add(urunGrup);
                context.SaveChanges();
                GrupDoldur();
                tUrunGrupAdi.Clear();
                MessageBox.Show("Ürün Grubu Eklenmiştir");
                fUrunGırıs f = (fUrunGırıs)Application.OpenForms["fUrunGırıs"];
                if (f != null)
                {
                    f.GrupDoldur();
                }
            }
            else
            {
                MessageBox.Show("Grup Bilgisi Ekleyin");
            }
        }

        private void fUrunGrubuEkle_Load(object sender, EventArgs e)
        {
            GrupDoldur();
        }
        private void GrupDoldur()
        {
            listUrunGrup.DisplayMember = "UrunGrupAd";
            listUrunGrup.ValueMember = "Id";
            listUrunGrup.DataSource = context.urunGrups.OrderBy(x => x.UrunGrupAd).ToList();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            int grupid = Convert.ToInt32(listUrunGrup.SelectedValue.ToString());
            string grupad = listUrunGrup.Text;
            DialogResult onay = MessageBox.Show(grupad + "grubunu silmek istiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                var grup = context.urunGrups.FirstOrDefault(x => x.Id == grupid);
                context.urunGrups.Remove(grup);
                context.SaveChanges();
                GrupDoldur();
                tUrunGrupAdi.Focus();
                MessageBox.Show(grupad + " ürün grubu silindi");
                fUrunGırıs f = (fUrunGırıs)Application.OpenForms["fUrunGırıs"];
                f.GrupDoldur();
            }
        }
    }
}
