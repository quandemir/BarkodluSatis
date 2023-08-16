using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarkodluSatis.Migrations
{
    public partial class islem_and_satis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ıslems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ıslems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "satis",
                columns: table => new
                {
                    SatisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemNo = table.Column<int>(nullable: false),
                    UrunAd = table.Column<string>(nullable: true),
                    Barkod = table.Column<string>(nullable: true),
                    UrunGrup = table.Column<string>(nullable: true),
                    Birim = table.Column<string>(nullable: true),
                    AlisFiyat = table.Column<float>(nullable: false),
                    SatisFiyat = table.Column<float>(nullable: false),
                    Miktar = table.Column<float>(nullable: false),
                    Toplam = table.Column<float>(nullable: false),
                    KdvTutari = table.Column<float>(nullable: false),
                    OdemeSekli = table.Column<string>(nullable: true),
                    Iade = table.Column<byte>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    Kullanici = table.Column<string>(nullable: true),
                    IslemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_satis", x => x.SatisId);
                    table.ForeignKey(
                        name: "FK_satis_ıslems_IslemId",
                        column: x => x.IslemId,
                        principalTable: "ıslems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_satis_IslemId",
                table: "satis",
                column: "IslemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "satis");

            migrationBuilder.DropTable(
                name: "ıslems");
        }
    }
}
