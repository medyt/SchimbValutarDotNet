using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UI.MVC.Data.Migrations
{
    public partial class casier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.CreateTable(
                name: "Casier",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccesCasaLeiValuta = table.Column<bool>(nullable: false),
                    AccesOperatiiTransfer = table.Column<bool>(nullable: false),
                    AccesRaportAdaosLunar = table.Column<bool>(nullable: false),
                    AccesRaportBnrNou = table.Column<bool>(nullable: false),
                    AccesRaportBnrVechi = table.Column<bool>(nullable: false),
                    AccesRaportSpecial = table.Column<bool>(nullable: false),
                    AccesRaportTransferuriZilnice = table.Column<bool>(nullable: false),
                    AccesRaportTranzactiiZilnice = table.Column<bool>(nullable: false),
                    AccesTransferuriLunare = table.Column<bool>(nullable: false),
                    AccesTranzactiiLunare = table.Column<bool>(nullable: false),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casier", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Casier");

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Genre = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.ID);
                });
        }
    }
}
