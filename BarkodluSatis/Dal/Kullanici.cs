using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.Dal
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string EPosta { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public byte Satış { get; set; }
        public byte Rapor { get; set; }
        public byte Stok { get; set; }
        public byte UrunGiris { get; set; }
        public byte Ayarlar { get; set; }
        public byte FiyatGuncelle { get; set; }
        public byte Yedekleme { get; set; }
    }
}
