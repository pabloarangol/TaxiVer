using Microsoft.EntityFrameworkCore.Migrations;

namespace TaxiVer.Web.Migrations
{
    public partial class AddUniquePlaque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Plaque",
                table: "Taxis",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 7);

            migrationBuilder.CreateIndex(
                name: "IX_Taxis_Plaque",
                table: "Taxis",
                column: "Plaque",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Taxis_Plaque",
                table: "Taxis");

            migrationBuilder.AlterColumn<string>(
                name: "Plaque",
                table: "Taxis",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 6);
        }
    }
}
