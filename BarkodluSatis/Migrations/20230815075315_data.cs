using Microsoft.EntityFrameworkCore.Migrations;

namespace BarkodluSatis.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_satis_ıslems_IslemId",
                table: "satis");

            migrationBuilder.DropIndex(
                name: "IX_satis_IslemId",
                table: "satis");

            migrationBuilder.DropColumn(
                name: "IslemId",
                table: "satis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IslemId",
                table: "satis",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_satis_IslemId",
                table: "satis",
                column: "IslemId");

            migrationBuilder.AddForeignKey(
                name: "FK_satis_ıslems_IslemId",
                table: "satis",
                column: "IslemId",
                principalTable: "ıslems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
