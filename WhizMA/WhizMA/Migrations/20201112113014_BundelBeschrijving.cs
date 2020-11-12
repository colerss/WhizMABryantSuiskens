using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class BundelBeschrijving : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocentBeschrijvingID",
                table: "Docenten",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BundelBeschrijvingID",
                table: "Bundels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BundelBeschrijving",
                columns: table => new
                {
                    BundelBeschrijvingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BundelInhoudsBeschrijving = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BundelBeschrijving", x => x.BundelBeschrijvingID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bundels_BundelBeschrijvingID",
                table: "Bundels",
                column: "BundelBeschrijvingID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bundels_BundelBeschrijving_BundelBeschrijvingID",
                table: "Bundels",
                column: "BundelBeschrijvingID",
                principalTable: "BundelBeschrijving",
                principalColumn: "BundelBeschrijvingID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bundels_BundelBeschrijving_BundelBeschrijvingID",
                table: "Bundels");

            migrationBuilder.DropTable(
                name: "BundelBeschrijving");

            migrationBuilder.DropIndex(
                name: "IX_Bundels_BundelBeschrijvingID",
                table: "Bundels");

            migrationBuilder.DropColumn(
                name: "DocentBeschrijvingID",
                table: "Docenten");

            migrationBuilder.DropColumn(
                name: "BundelBeschrijvingID",
                table: "Bundels");
        }
    }
}
