using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoAgencia.Migrations
{
    /// <inheritdoc />
    public partial class Criacaocerta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeContato",
                table: "Cadastro");

            migrationBuilder.AddColumn<string>(
                name: "Contato",
                table: "Cadastro",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contato",
                table: "Cadastro");

            migrationBuilder.AddColumn<int>(
                name: "NomeContato",
                table: "Cadastro",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
