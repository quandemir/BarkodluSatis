using Microsoft.EntityFrameworkCore.Migrations;

namespace BarkodluSatis.Migrations
{
    public partial class sabit_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdSoyad",
                table: "sabits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "sabits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Eposta",
                table: "sabits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "sabits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Unvan",
                table: "sabits",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Yazici",
                table: "sabits",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdSoyad",
                table: "sabits");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "sabits");

            migrationBuilder.DropColumn(
                name: "Eposta",
                table: "sabits");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "sabits");

            migrationBuilder.DropColumn(
                name: "Unvan",
                table: "sabits");

            migrationBuilder.DropColumn(
                name: "Yazici",
                table: "sabits");
        }
    }
}
