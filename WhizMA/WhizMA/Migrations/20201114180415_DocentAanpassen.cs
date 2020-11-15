using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class DocentAanpassen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocentBeschrijvingID",
                table: "Docenten");

            migrationBuilder.AddColumn<string>(
                name: "DocentBio",
                table: "Docenten",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocentBio",
                table: "Docenten");

            migrationBuilder.AddColumn<int>(
                name: "DocentBeschrijvingID",
                table: "Docenten",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
