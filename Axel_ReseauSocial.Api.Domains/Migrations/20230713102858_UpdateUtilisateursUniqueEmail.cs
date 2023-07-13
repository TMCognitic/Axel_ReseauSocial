using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axel_ReseauSocial.Api.Domains.Migrations
{
    public partial class UpdateUtilisateursUniqueEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_Email",
                table: "Utilisateur",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Utilisateur_Email",
                table: "Utilisateur");
        }
    }
}
