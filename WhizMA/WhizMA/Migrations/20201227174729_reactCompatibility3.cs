using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class reactCompatibility3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Bundels_BundelBeschrijvingID",
                table: "Bundels");

            migrationBuilder.CreateIndex(
                name: "IX_Bundels_BundelBeschrijvingID",
                table: "Bundels",
                column: "BundelBeschrijvingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Bundels_BundelBeschrijvingID",
                table: "Bundels");

            migrationBuilder.CreateIndex(
                name: "IX_Bundels_BundelBeschrijvingID",
                table: "Bundels",
                column: "BundelBeschrijvingID",
                unique: true);
        }
    }
}
