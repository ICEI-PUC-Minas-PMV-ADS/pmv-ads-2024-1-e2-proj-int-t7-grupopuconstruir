using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PUConstruir.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoUsuarioMaterialnoConstrutordeMaterial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Materiais",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materiais_UsuarioId",
                table: "Materiais",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materiais_Usuarios_UsuarioId",
                table: "Materiais",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materiais_Usuarios_UsuarioId",
                table: "Materiais");

            migrationBuilder.DropIndex(
                name: "IX_Materiais_UsuarioId",
                table: "Materiais");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Materiais");
        }
    }
}
