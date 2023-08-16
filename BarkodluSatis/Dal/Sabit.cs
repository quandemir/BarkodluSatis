using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.Dal
{
    internal class Sabit
    {
        public int Id { get; set; }
        public int KartKomisyon { get; set; }
        public int Yazici { get; set; }
        public string AdSoyad { get; set; }
        public string Unvan { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }

    }
}
