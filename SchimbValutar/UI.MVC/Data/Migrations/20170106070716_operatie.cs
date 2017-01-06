using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UI.MVC.Data.Migrations
{
    public partial class operatie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Operatie");
        }
    }
}
