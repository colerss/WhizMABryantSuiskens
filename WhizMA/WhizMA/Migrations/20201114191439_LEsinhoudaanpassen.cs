using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class LEsinhoudaanpassen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LesInterval",
                table: "CursusInhoud");

            migrationBuilder.AddColumn<int>(
                name: "LesIntervalWeken",
                table: "CursusInhoud",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LesIntervalWeken",
                table: "CursusInhoud");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "LesInterval",
                table: "CursusInhoud",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
