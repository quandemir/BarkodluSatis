using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.Dal
{
    internal class IslemOzet
    {

        public int Id { get; set; }
        public int IslemNo { get; set; }
        public byte Iade { get; set; }
        public string OdemeSekli { get; set; }
        public double Nakit { get; set; }
        public double Kart { get; set; }
        public byte Gelir { get; set; }
        public byte Gider { get; set; }
        public double AlisFiyatToplam { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public string Kullanici { get; set; }
        //public Islem Islem { get; set; }
    }
}
