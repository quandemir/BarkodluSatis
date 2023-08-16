using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.Dal
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string Barkod { get; set;}
        public string UrunAd { get; set;}
        public string Aciklama { get; set;}
        public string UrunGrup { get; set;}
        public double AlisFiyat { get; set;}
        public double SatisFiyat { get; set;}
        public int KdvOrani { get; set;}
        public double KdvTutari { get; set;}
        public string Birim { get; set;}
        public double Miktar { get; set; }
        public DateTime Tarih { get; set; }
        public string Kullanici { get; set; }
        public byte Onay { get; set; }
        //INSERT INTO Uruns (Barkod,UrunAd,Aciklama,UrunGrup,AlisFiyat,SatisFiyat,KdvOrani,KdvTutari,Birim,Miktar,Tarih,Kullanici) VALUES ('12345679','Dometes','sdfdsffsd','Manav',1,4,3,2,'Kg',200,'01.01.2020','Osman Kandemir');


    }
}
