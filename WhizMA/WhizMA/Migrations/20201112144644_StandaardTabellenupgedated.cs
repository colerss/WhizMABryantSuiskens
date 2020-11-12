using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class StandaardTabellenupgedated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stappen",
                table: "Lessen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DocentFB",
                table: "Docenten",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocentIG",
                table: "Docenten",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocentPin",
                table: "Docenten",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocentTitel",
                table: "Docenten",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stappen",
                table: "Lessen");

            migrationBuilder.DropColumn(
                name: "DocentFB",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "DocentIG",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "DocentPin",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "DocentTitel",
                table: "Docenten");
        }
    }
}
