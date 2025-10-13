using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceitaDesafio.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarCampoTurno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Turno",
                table: "tb_Receita",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Turno",
                table: "tb_Receita");
        }
    }
}
