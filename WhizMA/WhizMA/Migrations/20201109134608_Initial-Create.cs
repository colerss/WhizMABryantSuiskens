using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WhizMA.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bundels",
                columns: table => new
                {
                    BundelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    Afbeelding = table.Column<string>(nullable: false),
                    StandaardPrijs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HuidigePrijs = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bundels", x => x.BundelID);
                });

            migrationBuilder.CreateTable(
                name: "Docenten",
                columns: table => new
                {
                    DocentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocentNaam = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docenten", x => x.DocentID);
                });

            migrationBuilder.CreateTable(
                name: "Lessen",
                columns: table => new
                {
                    LesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    Duur = table.Column<TimeSpan>(nullable: false),
                    Beschrijving = table.Column<string>(nullable: false),
                    VideoAddress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessen", x => x.LesID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cursussen",
                columns: table => new
                {
                    CursusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    StandaardPrijs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HuidigePrijs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Beschrijving = table.Column<string>(nullable: false),
                    Afbeelding = table.Column<string>(nullable: false),
                    Gecertificieerd = table.Column<bool>(nullable: false),
                    Beschikbaarheid = table.Column<TimeSpan>(nullable: false),
                    DocentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursussen", x => x.CursusID);
                    table.ForeignKey(
                        name: "FK_Cursussen_Docenten_DocentID",
                        column: x => x.DocentID,
                        principalTable: "Docenten",
                        principalColumn: "DocentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountCatalogus",
                columns: table => new
                {
                    CatalogusItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursusID = table.Column<int>(nullable: false),
                    AccountID = table.Column<int>(nullable: false),
                    VerloopTijd = table.Column<DateTime>(nullable: false),
                    Voortgang = table.Column<int>(nullable: false),
                    AccountId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountCatalogus", x => x.CatalogusItemID);
                    table.ForeignKey(
                        name: "FK_AccountCatalogus_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountCatalogus_Cursussen_CursusID",
                        column: x => x.CursusID,
                        principalTable: "Cursussen",
                        principalColumn: "CursusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BundelInhoud",
                columns: table => new
                {
                    BundelInhoudID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BundelID = table.Column<int>(nullable: false),
                    CursusID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BundelInhoud", x => x.BundelInhoudID);
                    table.ForeignKey(
                        name: "FK_BundelInhoud_Bundels_BundelID",
                        column: x => x.BundelID,
                        principalTable: "Bundels",
                        principalColumn: "BundelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BundelInhoud_Cursussen_CursusID",
                        column: x => x.CursusID,
                        principalTable: "Cursussen",
                        principalColumn: "CursusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CursusInhoud",
                columns: table => new
                {
                    CursusInhoudID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursusID = table.Column<int>(nullable: false),
                    LesID = table.Column<int>(nullable: false),
                    LesInterval = table.Column<TimeSpan>(nullable: false),
                    Positie = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursusInhoud", x => x.CursusInhoudID);
                    table.ForeignKey(
                        name: "FK_CursusInhoud_Cursussen_CursusID",
                        column: x => x.CursusID,
                        principalTable: "Cursussen",
                        principalColumn: "CursusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursusInhoud_Lessen_LesID",
                        column: x => x.LesID,
                        principalTable: "Lessen",
                        principalColumn: "LesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfoNodes",
                columns: table => new
                {
                    InfoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(nullable: false),
                    Subtitel = table.Column<string>(nullable: true),
                    beschrijving = table.Column<string>(nullable: false),
                    afbeelding = table.Column<string>(nullable: false),
                    CursusID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoNodes", x => x.InfoID);
                    table.ForeignKey(
                        name: "FK_InfoNodes_Cursussen_CursusID",
                        column: x => x.CursusID,
                        principalTable: "Cursussen",
                        principalColumn: "CursusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountCatalogus_AccountId",
                table: "AccountCatalogus",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountCatalogus_CursusID",
                table: "AccountCatalogus",
                column: "CursusID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BundelInhoud_BundelID",
                table: "BundelInhoud",
                column: "BundelID");

            migrationBuilder.CreateIndex(
                name: "IX_BundelInhoud_CursusID",
                table: "BundelInhoud",
                column: "CursusID");

            migrationBuilder.CreateIndex(
                name: "IX_CursusInhoud_CursusID",
                table: "CursusInhoud",
                column: "CursusID");

            migrationBuilder.CreateIndex(
                name: "IX_CursusInhoud_LesID",
                table: "CursusInhoud",
                column: "LesID");

            migrationBuilder.CreateIndex(
                name: "IX_Cursussen_DocentID",
                table: "Cursussen",
                column: "DocentID");

            migrationBuilder.CreateIndex(
                name: "IX_InfoNodes_CursusID",
                table: "InfoNodes",
                column: "CursusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountCatalogus");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BundelInhoud");

            migrationBuilder.DropTable(
                name: "CursusInhoud");

            migrationBuilder.DropTable(
                name: "InfoNodes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Bundels");

            migrationBuilder.DropTable(
                name: "Lessen");

            migrationBuilder.DropTable(
                name: "Cursussen");

            migrationBuilder.DropTable(
                name: "Docenten");
        }
    }
}
