using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class lesStap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stappen",
                table: "Lessen");

            migrationBuilder.CreateTable(
                name: "LesStap",
                columns: table => new
                {
                    LesStapID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LesStapNaam = table.Column<int>(nullable: false),
                    StapTimeStamp = table.Column<TimeSpan>(nullable: false),
                    StapIcon = table.Column<string>(nullable: true),
                    LesID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LesStap", x => x.LesStapID);
                    table.ForeignKey(
                        name: "FK_LesStap_Lessen_LesID",
                        column: x => x.LesID,
                        principalTable: "Lessen",
                        principalColumn: "LesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LesStap_LesID",
                table: "LesStap",
                column: "LesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LesStap");

            migrationBuilder.AddColumn<int>(
                name: "Stappen",
                table: "Lessen",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
