using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarkodluSatis.Migrations
{
    public partial class stokhareket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "stokHarekets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barkod = table.Column<string>(nullable: true),
                    UrunAd = table.Column<string>(nullable: true),
                    Birim = table.Column<string>(nullable: true),
                    Miktar = table.Column<double>(nullable: false),
                    UrunGrup = table.Column<string>(nullable: true),
                    Kullanici = table.Column<string>(nullable: true),
                    datetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stokHarekets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stokHarekets");
        }
    }
}
