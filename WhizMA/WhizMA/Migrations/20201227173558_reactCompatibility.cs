using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class reactCompatibility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cursussen_CursusBeschrijvingID",
                table: "Cursussen");

            migrationBuilder.CreateIndex(
                name: "IX_Cursussen_CursusBeschrijvingID",
                table: "Cursussen",
                column: "CursusBeschrijvingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cursussen_CursusBeschrijvingID",
                table: "Cursussen");

            migrationBuilder.CreateIndex(
                name: "IX_Cursussen_CursusBeschrijvingID",
                table: "Cursussen",
                column: "CursusBeschrijvingID",
                unique: true);
        }
    }
}
