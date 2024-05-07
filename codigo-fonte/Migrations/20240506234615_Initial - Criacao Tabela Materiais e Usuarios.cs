using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PUConstruir.Migrations
{
    /// <inheritdoc />
    public partial class InitialCriacaoTabelaMateriaiseUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materiais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Um = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ValorPadrao = table.Column<decimal>(type: "decimal(18,2)", precision: 18, nullable: false),
                    Altura = table.Column<decimal>(type: "decimal(18,2)", precision: 18, nullable: false),
                    Largura = table.Column<decimal>(type: "decimal(18,2)", precision: 18, nullable: false),
                    Comprimento = table.Column<decimal>(type: "decimal(18,2)", precision: 18, nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(18,2)", precision: 18, nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DataCriacao = table.Column<DateOnly>(type: "date", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materiais_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materiais_UsuarioId",
                table: "Materiais",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materiais");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
