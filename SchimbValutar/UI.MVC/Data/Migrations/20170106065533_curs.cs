using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UI.MVC.Data.Migrations
{
    public partial class curs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curs");
        }
    }
}
