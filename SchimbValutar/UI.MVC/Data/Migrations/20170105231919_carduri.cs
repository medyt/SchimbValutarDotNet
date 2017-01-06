using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UI.MVC.Data.Migrations
{
    public partial class carduri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");
        }
    }
}
