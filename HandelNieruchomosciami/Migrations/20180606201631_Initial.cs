using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HandelNieruchomosciami.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgentDataWaznosciLicencji = table.Column<string>(nullable: true),
                    AgentEmail = table.Column<string>(nullable: true),
                    AgentImie = table.Column<string>(nullable: true),
                    AgentKodPocztowy = table.Column<string>(nullable: true),
                    AgentMiasto = table.Column<string>(nullable: true),
                    AgentNIP = table.Column<int>(nullable: false),
                    AgentNazwisko = table.Column<string>(nullable: true),
                    AgentNrLicencji = table.Column<string>(nullable: true),
                    AgentPESEL = table.Column<int>(nullable: false),
                    AgentTelefon = table.Column<int>(nullable: false),
                    AgentUlica = table.Column<string>(nullable: true),
                    AgentZatrudnienieOd = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AgentId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
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
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kontrahents",
                columns: table => new
                {
                    KontrahentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KontrahentAdresKorespondencyjny = table.Column<string>(nullable: true),
                    KontrahentEmail = table.Column<string>(nullable: true),
                    KontrahentImie = table.Column<string>(nullable: true),
                    KontrahentNIP = table.Column<int>(nullable: false),
                    KontrahentNazwisko = table.Column<string>(nullable: true),
                    KontrahentPESEL = table.Column<int>(nullable: false),
                    KontrahentTelefon = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kontrahents", x => x.KontrahentId);
                });

            migrationBuilder.CreateTable(
                name: "StatusTransakcjis",
                columns: table => new
                {
                    StatusTransakcjiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StatusTransakcjiNazwa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusTransakcjis", x => x.StatusTransakcjiId);
                });

            migrationBuilder.CreateTable(
                name: "TypZabudowies",
                columns: table => new
                {
                    TypZabudowyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypZabudowyNazwa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypZabudowies", x => x.TypZabudowyId);
                });

            migrationBuilder.CreateTable(
                name: "Wlasciciels",
                columns: table => new
                {
                    WlascicielId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WlascicielAdres = table.Column<string>(nullable: true),
                    WlascicielEmail = table.Column<string>(nullable: true),
                    WlascicielImie = table.Column<string>(nullable: true),
                    WlascicielNazwisko = table.Column<string>(nullable: true),
                    WlascicielTelefon = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wlasciciels", x => x.WlascicielId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
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
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
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
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
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
                name: "Nieruchomoscs",
                columns: table => new
                {
                    NieruchomoscId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NieruchomoscCzynsz = table.Column<int>(nullable: false),
                    NieruchomoscKodPocztowy = table.Column<string>(nullable: true),
                    NieruchomoscMiasto = table.Column<string>(nullable: true),
                    NieruchomoscNrBudynku = table.Column<string>(nullable: true),
                    NieruchomoscPowierzchnia = table.Column<int>(nullable: false),
                    NieruchomoscTypZabudowy = table.Column<int>(nullable: false),
                    NieruchomoscUlica = table.Column<string>(nullable: true),
                    NieruchomoscWlasciciel = table.Column<int>(nullable: false),
                    TypZabudowyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nieruchomoscs", x => x.NieruchomoscId);
                    table.ForeignKey(
                        name: "FK_Nieruchomoscs_TypZabudowies_TypZabudowyId",
                        column: x => x.TypZabudowyId,
                        principalTable: "TypZabudowies",
                        principalColumn: "TypZabudowyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Umowas",
                columns: table => new
                {
                    UmowaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KontrahentId = table.Column<int>(nullable: true),
                    NieruchomoscId = table.Column<int>(nullable: true),
                    UmowaDataSporzadzeniaUmowy = table.Column<DateTime>(nullable: false),
                    UmowaKontrahentId = table.Column<int>(nullable: false),
                    UmowaKwotaPLN = table.Column<int>(nullable: false),
                    UmowaNieruchomoscId = table.Column<int>(nullable: false),
                    UmowaNumerUmowy = table.Column<string>(nullable: true),
                    UmowaSprzedajacyId = table.Column<int>(nullable: false),
                    WlascicielId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Umowas", x => x.UmowaId);
                    table.ForeignKey(
                        name: "FK_Umowas_Kontrahents_KontrahentId",
                        column: x => x.KontrahentId,
                        principalTable: "Kontrahents",
                        principalColumn: "KontrahentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Umowas_Nieruchomoscs_NieruchomoscId",
                        column: x => x.NieruchomoscId,
                        principalTable: "Nieruchomoscs",
                        principalColumn: "NieruchomoscId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Umowas_Wlasciciels_WlascicielId",
                        column: x => x.WlascicielId,
                        principalTable: "Wlasciciels",
                        principalColumn: "WlascicielId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transakcjas",
                columns: table => new
                {
                    TransakcjaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgentId = table.Column<int>(nullable: true),
                    KontrahentId = table.Column<int>(nullable: true),
                    NieruchomoscId = table.Column<int>(nullable: true),
                    StatusTransakcjiId = table.Column<int>(nullable: true),
                    TransakcjaAgentId = table.Column<int>(nullable: false),
                    TransakcjaDataUtworzenia = table.Column<DateTime>(nullable: false),
                    TransakcjaKontrahentId = table.Column<int>(nullable: false),
                    TransakcjaNieruchomoscId = table.Column<int>(nullable: false),
                    TransakcjaNumer = table.Column<string>(nullable: true),
                    TransakcjaNumerUmowy = table.Column<string>(nullable: true),
                    TransakcjaSprzedawcaId = table.Column<int>(nullable: false),
                    TransakcjaStatusTransakcjiId = table.Column<int>(nullable: false),
                    UmowaId = table.Column<int>(nullable: true),
                    WlascicielId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transakcjas", x => x.TransakcjaId);
                    table.ForeignKey(
                        name: "FK_Transakcjas_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "AgentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transakcjas_Kontrahents_KontrahentId",
                        column: x => x.KontrahentId,
                        principalTable: "Kontrahents",
                        principalColumn: "KontrahentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transakcjas_Nieruchomoscs_NieruchomoscId",
                        column: x => x.NieruchomoscId,
                        principalTable: "Nieruchomoscs",
                        principalColumn: "NieruchomoscId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transakcjas_StatusTransakcjis_StatusTransakcjiId",
                        column: x => x.StatusTransakcjiId,
                        principalTable: "StatusTransakcjis",
                        principalColumn: "StatusTransakcjiId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transakcjas_Umowas_UmowaId",
                        column: x => x.UmowaId,
                        principalTable: "Umowas",
                        principalColumn: "UmowaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transakcjas_Wlasciciels_WlascicielId",
                        column: x => x.WlascicielId,
                        principalTable: "Wlasciciels",
                        principalColumn: "WlascicielId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_Nieruchomoscs_TypZabudowyId",
                table: "Nieruchomoscs",
                column: "TypZabudowyId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcjas_AgentId",
                table: "Transakcjas",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcjas_KontrahentId",
                table: "Transakcjas",
                column: "KontrahentId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcjas_NieruchomoscId",
                table: "Transakcjas",
                column: "NieruchomoscId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcjas_StatusTransakcjiId",
                table: "Transakcjas",
                column: "StatusTransakcjiId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcjas_UmowaId",
                table: "Transakcjas",
                column: "UmowaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcjas_WlascicielId",
                table: "Transakcjas",
                column: "WlascicielId");

            migrationBuilder.CreateIndex(
                name: "IX_Umowas_KontrahentId",
                table: "Umowas",
                column: "KontrahentId");

            migrationBuilder.CreateIndex(
                name: "IX_Umowas_NieruchomoscId",
                table: "Umowas",
                column: "NieruchomoscId");

            migrationBuilder.CreateIndex(
                name: "IX_Umowas_WlascicielId",
                table: "Umowas",
                column: "WlascicielId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Transakcjas");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "StatusTransakcjis");

            migrationBuilder.DropTable(
                name: "Umowas");

            migrationBuilder.DropTable(
                name: "Kontrahents");

            migrationBuilder.DropTable(
                name: "Nieruchomoscs");

            migrationBuilder.DropTable(
                name: "Wlasciciels");

            migrationBuilder.DropTable(
                name: "TypZabudowies");
        }
    }
}
