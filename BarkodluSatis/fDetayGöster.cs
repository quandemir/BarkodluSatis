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
    public partial class fDetayGöster : Form
    {
        public fDetayGöster()
        {
            InitializeComponent();
        }
        public int islemNo { get; set; }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void fDetayGöster_Load(object sender, EventArgs e)
        {
            lİşlemNo.Text = "İşlem No: " + islemNo.ToString();
            using(var db=new Context())
            {
                gridList.DataSource = db.satis.Select(x=> new {x.IslemNo,x.UrunAd,x.UrunGrup,x.Miktar,x.Toplam}).Where(x=>x.IslemNo==islemNo).ToList();
                Islemler.GridDüzenle(gridList);
            }
        }
    }
}
