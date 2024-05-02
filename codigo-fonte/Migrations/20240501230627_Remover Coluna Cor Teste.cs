using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PUConstruir.Migrations
{
    /// <inheritdoc />
    public partial class RemoverColunaCorTeste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cor",
                table: "Materiais");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cor",
                table: "Materiais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
