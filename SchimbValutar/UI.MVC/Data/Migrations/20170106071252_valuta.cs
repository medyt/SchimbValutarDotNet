using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UI.MVC.Data.Migrations
{
    public partial class valuta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Valuta");
        }
    }
}
