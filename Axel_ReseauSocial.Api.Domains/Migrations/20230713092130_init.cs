using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axel_ReseauSocial.Api.Domains.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Localite",
                columns: table => new
                {
                    IdLocalite = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    CP = table.Column<int>(type: "int", nullable: false),
                    Ville = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localite", x => x.IdLocalite);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Localite");
        }
    }
}
