using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class IconAparteTabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StapIcon",
                table: "LesStap");

            migrationBuilder.DropColumn(
                name: "StapIconPath",
                table: "LesStap");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StapIcon",
                table: "LesStap",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StapIconPath",
                table: "LesStap",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
