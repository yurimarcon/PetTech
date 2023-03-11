using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetTech_API.Migrations
{
    /// <inheritdoc />
    public partial class Remoçãoderelaçãoentretabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Breeds_breadid",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_breadid",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "breadid",
                table: "Pets",
                newName: "bread");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bread",
                table: "Pets",
                newName: "breadid");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_breadid",
                table: "Pets",
                column: "breadid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Breeds_breadid",
                table: "Pets",
                column: "breadid",
                principalTable: "Breeds",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
