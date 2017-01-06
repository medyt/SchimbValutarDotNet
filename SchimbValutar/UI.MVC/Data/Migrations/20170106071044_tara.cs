using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UI.MVC.Data.Migrations
{
    public partial class tara : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tara");
        }
    }
}
