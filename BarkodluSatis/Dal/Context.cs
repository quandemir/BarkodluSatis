using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.Dal
{
    internal class Context: Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=BarkodDb;User Id=SA;Password=test*sql.11;TrustServerCertificate=True");
        }
        public Microsoft.EntityFrameworkCore.DbSet<Urun> Uruns { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Terazi> Terazis { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<HizliUrun> hizliUruns { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Islem> ıslems { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Satis> satis { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<IslemOzet> ıslemOzets { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<UrunGrup> urunGrups { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Barkod> barkods { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<StokHareket> stokHarekets { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Sabit> sabits { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Kullanici> kullanicis { get; set; }


    }
}
