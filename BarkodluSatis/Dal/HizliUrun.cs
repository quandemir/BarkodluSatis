using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.Dal
{
    public class HizliUrun
    {
        public int Id { get; set; }
        public string Barkod { get; set; }
        public string UrunAd { get; set; }          
        public double Fiyat { get; set; }
        //public string  Photo { get; set; }
    }
}
