using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class LesStappenAangepast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beschrijving",
                table: "Lessen");

            migrationBuilder.DropColumn(
                name: "Duur",
                table: "Lessen");

            migrationBuilder.DropColumn(
                name: "VideoAddress",
                table: "Lessen");

            migrationBuilder.AddColumn<string>(
                name: "VideoAddress",
                table: "LesStap",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoAddress",
                table: "LesStap");

            migrationBuilder.AddColumn<string>(
                name: "Beschrijving",
                table: "Lessen",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duur",
                table: "Lessen",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "VideoAddress",
                table: "Lessen",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
