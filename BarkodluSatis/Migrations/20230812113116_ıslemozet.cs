using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarkodluSatis.Migrations
{
    public partial class ıslemozet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ıslemOzets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemNo = table.Column<int>(nullable: false),
                    Iade = table.Column<byte>(nullable: false),
                    OdemeSekli = table.Column<string>(nullable: true),
                    Nakit = table.Column<float>(nullable: false),
                    Kart = table.Column<float>(nullable: false),
                    Gelir = table.Column<byte>(nullable: false),
                    Gider = table.Column<byte>(nullable: false),
                    AlisFiyatToplam = table.Column<float>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    Tarih = table.Column<DateTime>(nullable: false),
                    Kullanici = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ıslemOzets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ıslemOzets");
        }
    }
}
