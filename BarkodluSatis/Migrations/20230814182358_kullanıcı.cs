using Microsoft.EntityFrameworkCore.Migrations;

namespace BarkodluSatis.Migrations
{
    public partial class kullanıcı : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kullanicis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    EPosta = table.Column<string>(nullable: true),
                    KullaniciAdi = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true),
                    Satış = table.Column<byte>(nullable: false),
                    Rapor = table.Column<byte>(nullable: false),
                    Stok = table.Column<byte>(nullable: false),
                    UrunGiris = table.Column<byte>(nullable: false),
                    Ayarlar = table.Column<byte>(nullable: false),
                    FiyatGuncelle = table.Column<byte>(nullable: false),
                    Yedekleme = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullanicis", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kullanicis");
        }
    }
}
