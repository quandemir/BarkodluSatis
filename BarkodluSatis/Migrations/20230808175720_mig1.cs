using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarkodluSatis.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Terazis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeraziÖnEk = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terazis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uruns",
                columns: table => new
                {
                    UrunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barkod = table.Column<string>(nullable: true),
                    UrunAd = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    UrunGrup = table.Column<string>(nullable: true),
                    AlisFiyat = table.Column<float>(nullable: false),
                    SatisFiyat = table.Column<float>(nullable: false),
                    KdvOrani = table.Column<int>(nullable: false),
                    KdvTutari = table.Column<float>(nullable: false),
                    Birim = table.Column<string>(nullable: true),
                    Miktar = table.Column<float>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    Kullanici = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uruns", x => x.UrunId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Terazis");

            migrationBuilder.DropTable(
                name: "Uruns");
        }
    }
}
