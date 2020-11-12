using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class lesStapBeschrijving : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LesStapText",
                table: "LesStap",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LesStapText",
                table: "LesStap");
        }
    }
}
