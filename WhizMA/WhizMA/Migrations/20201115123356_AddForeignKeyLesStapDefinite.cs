using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class AddForeignKeyLesStapDefinite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StapIcon",
                columns: table => new
                {
                    StapIconID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StapIconClass = table.Column<string>(nullable: true),
                    StapIconPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StapIcon", x => x.StapIconID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LesStap_StapIconID",
                table: "LesStap",
                column: "StapIconID");

            migrationBuilder.AddForeignKey(
                name: "FK_LesStap_StapIcon_StapIconID",
                table: "LesStap",
                column: "StapIconID",
                principalTable: "StapIcon",
                principalColumn: "StapIconID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LesStap_StapIcon_StapIconID",
                table: "LesStap");

            migrationBuilder.DropTable(
                name: "StapIcon");

            migrationBuilder.DropIndex(
                name: "IX_LesStap_StapIconID",
                table: "LesStap");
        }
    }
}
