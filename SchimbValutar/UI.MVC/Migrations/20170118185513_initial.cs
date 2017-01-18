using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UI.MVC.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    CursValutarStabilit = table.Column<decimal>(nullable: false),
                    DataTranzactie = table.Column<DateTime>(nullable: false),
                    DenumireCard = table.Column<string>(nullable: true),
                    NumarBonFiscal = table.Column<int>(nullable: false),
                    NumarCard = table.Column<string>(nullable: true),
                    NumarChitantaSchimbValutar = table.Column<int>(nullable: false),
                    SerieChitantaSchimbValutar = table.Column<string>(nullable: true),
                    SumaTranzactionata = table.Column<int>(nullable: false),
                    ValoareLei = table.Column<decimal>(nullable: false),
                    Valuta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Casier",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AccesEmployee = table.Column<bool>(nullable: false),
                    AccesManager = table.Column<bool>(nullable: false),
                    AccesOwner = table.Column<bool>(nullable: false),
                    CNP = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Nume = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CodTara = table.Column<string>(nullable: true),
                    DenumireTara = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    IsNigger = table.Column<bool>(nullable: false),
                    IsOwner = table.Column<bool>(nullable: false),
                    NumarDocumentIdentitate = table.Column<int>(nullable: false),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true),
                    SerieDocumentIdentitate = table.Column<string>(nullable: true),
                    TipDocumentIdentitate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Curs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AcronimValuta = table.Column<string>(nullable: true),
                    ActualizareValuta = table.Column<bool>(nullable: false),
                    CasierId = table.Column<Guid>(nullable: false),
                    CursCumparare = table.Column<decimal>(nullable: false),
                    CursOficialBnr = table.Column<decimal>(nullable: false),
                    CursVanzare = table.Column<decimal>(nullable: false),
                    DataCurs = table.Column<DateTime>(nullable: false),
                    DenumireValuta = table.Column<string>(nullable: true),
                    Multiplu = table.Column<int>(nullable: false),
                    NumarCurentValuta = table.Column<int>(nullable: false),
                    NumarLista = table.Column<int>(nullable: false),
                    ParitateEuro = table.Column<decimal>(nullable: false),
                    PozitieValuta = table.Column<string>(nullable: true),
                    SoldCurentValuta = table.Column<int>(nullable: false),
                    TipValuta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operatie",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AcronimValuta = table.Column<string>(nullable: true),
                    AdaosRealizat = table.Column<int>(nullable: false),
                    AdaosRelativ = table.Column<int>(nullable: false),
                    CalitateClient = table.Column<string>(nullable: true),
                    CodTaraClient = table.Column<int>(nullable: false),
                    CursOficialBnr = table.Column<int>(nullable: false),
                    CursValutarStabilit = table.Column<int>(nullable: false),
                    DataOperatiune = table.Column<DateTime>(nullable: false),
                    DenumireTaraClient = table.Column<string>(nullable: true),
                    InstrumentPlata = table.Column<string>(nullable: true),
                    Multiplu = table.Column<int>(nullable: false),
                    NumarCurentChitanta = table.Column<int>(nullable: false),
                    NumarDocument = table.Column<int>(nullable: false),
                    NumarDocumentIdentitate = table.Column<int>(nullable: false),
                    NumarLista = table.Column<int>(nullable: false),
                    NumarRaportZ = table.Column<int>(nullable: false),
                    NumePrenumeClient = table.Column<string>(nullable: true),
                    ParitateEuro = table.Column<decimal>(nullable: false),
                    ProcentComisionCard = table.Column<int>(nullable: false),
                    ProcentComisionCec = table.Column<int>(nullable: false),
                    SerieChitanta = table.Column<string>(nullable: true),
                    SerieDocumentIdentitate = table.Column<string>(nullable: true),
                    SoldPrecedent = table.Column<int>(nullable: false),
                    StareOperatiuneTranzactie = table.Column<string>(nullable: true),
                    SumaValuta = table.Column<int>(nullable: false),
                    TipDocumentIdentitate = table.Column<string>(nullable: true),
                    ValoareComision = table.Column<int>(nullable: false),
                    ValoareLei = table.Column<int>(nullable: false),
                    ValoareSpeze = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operatie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tara",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Cod = table.Column<string>(nullable: true),
                    Denumire = table.Column<string>(nullable: true),
                    TotalCumparariEuro = table.Column<int>(nullable: false),
                    TotalVanzariEuro = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tara", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Valuta",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AcronimValuta = table.Column<string>(nullable: true),
                    DenumireValuta = table.Column<string>(nullable: true),
                    Multiplu = table.Column<int>(nullable: false),
                    NumarCurentValuta = table.Column<int>(nullable: false),
                    PozitieValuta = table.Column<int>(nullable: false),
                    TipValuta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valuta", x => x.Id);
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
                });

            migrationBuilder.CreateTable(
                name: "CursValutar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BuyingEuroToRon = table.Column<decimal>(nullable: false),
                    BuyingGbpToRon = table.Column<decimal>(nullable: false),
                    BuyingUsdToRon = table.Column<decimal>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SellingEuroToRon = table.Column<decimal>(nullable: false),
                    SellingGbpToRon = table.Column<decimal>(nullable: false),
                    SellingUsdToRon = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursValutar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tranzactii",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ActIdentitate = table.Column<int>(nullable: false),
                    Cnp = table.Column<string>(nullable: false),
                    Din = table.Column<int>(nullable: false),
                    In = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Numarul = table.Column<string>(nullable: false),
                    Seria = table.Column<string>(nullable: false),
                    SumaDatorata = table.Column<decimal>(nullable: false),
                    SumaTranzationata = table.Column<decimal>(nullable: false),
                    TipOperatie = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tranzactii", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

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
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Casier");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Curs");

            migrationBuilder.DropTable(
                name: "Operatie");

            migrationBuilder.DropTable(
                name: "Tara");

            migrationBuilder.DropTable(
                name: "Valuta");

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
                name: "CursValutar");

            migrationBuilder.DropTable(
                name: "Tranzactii");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
