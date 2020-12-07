using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class AddFK2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountCatalogus_AspNetUsers_AccountId",
                table: "AccountCatalogus");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "AccountCatalogus",
                newName: "AccountID");

            migrationBuilder.RenameIndex(
                name: "IX_AccountCatalogus_AccountId",
                table: "AccountCatalogus",
                newName: "IX_AccountCatalogus_AccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountCatalogus_AspNetUsers_AccountID",
                table: "AccountCatalogus",
                column: "AccountID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountCatalogus_AspNetUsers_AccountID",
                table: "AccountCatalogus");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "AccountCatalogus",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_AccountCatalogus_AccountID",
                table: "AccountCatalogus",
                newName: "IX_AccountCatalogus_AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountCatalogus_AspNetUsers_AccountId",
                table: "AccountCatalogus",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
