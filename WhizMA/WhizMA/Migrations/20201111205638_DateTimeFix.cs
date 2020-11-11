using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class DateTimeFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeschikbaarheidInMaanden",
                table: "Cursussen");

            migrationBuilder.AddColumn<int>(
                name: "BeschikbaarheidInMaanden",
                table: "Cursussen",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeschikbaarheidInMaanden",
                table: "Cursussen");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "BeschikbaarheidInMaanden",
                table: "Cursussen",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
