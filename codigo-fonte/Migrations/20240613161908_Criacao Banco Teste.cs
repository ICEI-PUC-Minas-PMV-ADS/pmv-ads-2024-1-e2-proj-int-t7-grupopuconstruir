using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PUConstruir.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoBancoTeste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Um",
                table: "Servicos");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Servicos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Materiais",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Orcamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataCriacao = table.Column<DateOnly>(type: "date", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orcamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orcamentos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProjeto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataInicial = table.Column<DateOnly>(type: "date", nullable: true),
                    DataFinal = table.Column<DateOnly>(type: "date", nullable: true),
                    DataCriacao = table.Column<DateOnly>(type: "date", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projetos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrcamentoProjetos",
                columns: table => new
                {
                    OrcamentosId = table.Column<int>(type: "int", nullable: false),
                    ProjetosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrcamentoProjetos", x => new { x.OrcamentosId, x.ProjetosId });
                    table.ForeignKey(
                        name: "FK_OrcamentoProjetos_Orcamentos_OrcamentosId",
                        column: x => x.OrcamentosId,
                        principalTable: "Orcamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrcamentoProjetos_Projetos_ProjetosId",
                        column: x => x.ProjetosId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjetoMateriais",
                columns: table => new
                {
                    MateriaisId = table.Column<int>(type: "int", nullable: false),
                    ProjetosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoMateriais", x => new { x.MateriaisId, x.ProjetosId });
                    table.ForeignKey(
                        name: "FK_ProjetoMateriais_Materiais_MateriaisId",
                        column: x => x.MateriaisId,
                        principalTable: "Materiais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjetoMateriais_Projetos_ProjetosId",
                        column: x => x.ProjetosId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjetoServicos",
                columns: table => new
                {
                    ProjetosId = table.Column<int>(type: "int", nullable: false),
                    ServicosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoServicos", x => new { x.ProjetosId, x.ServicosId });
                    table.ForeignKey(
                        name: "FK_ProjetoServicos_Projetos_ProjetosId",
                        column: x => x.ProjetosId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjetoServicos_Servicos_ServicosId",
                        column: x => x.ServicosId,
                        principalTable: "Servicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_UsuarioId",
                table: "Servicos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_OrcamentoProjetos_ProjetosId",
                table: "OrcamentoProjetos",
                column: "ProjetosId");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamentos_UsuarioId",
                table: "Orcamentos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoMateriais_ProjetosId",
                table: "ProjetoMateriais",
                column: "ProjetosId");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_UsuarioId",
                table: "Projetos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoServicos_ServicosId",
                table: "ProjetoServicos",
                column: "ServicosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Usuarios_UsuarioId",
                table: "Servicos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Usuarios_UsuarioId",
                table: "Servicos");

            migrationBuilder.DropTable(
                name: "OrcamentoProjetos");

            migrationBuilder.DropTable(
                name: "ProjetoMateriais");

            migrationBuilder.DropTable(
                name: "ProjetoServicos");

            migrationBuilder.DropTable(
                name: "Orcamentos");

            migrationBuilder.DropTable(
                name: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_UsuarioId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Materiais");

            migrationBuilder.AddColumn<string>(
                name: "Um",
                table: "Servicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
