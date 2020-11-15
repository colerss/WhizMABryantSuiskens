using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class FormaatFoutenInfoNOde : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "beschrijving",
                table: "InfoNodes",
                newName: "Beschrijving");

            migrationBuilder.RenameColumn(
                name: "afbeelding",
                table: "InfoNodes",
                newName: "Afbeelding");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Beschrijving",
                table: "InfoNodes",
                newName: "beschrijving");

            migrationBuilder.RenameColumn(
                name: "Afbeelding",
                table: "InfoNodes",
                newName: "afbeelding");
        }
    }
}
