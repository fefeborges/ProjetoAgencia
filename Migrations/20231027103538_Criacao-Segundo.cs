using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoAgencia.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoSegundo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AtracoesId",
                table: "Cadastro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PassageirosId",
                table: "Cadastro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TransporteId",
                table: "Cadastro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cadastro_AtracoesId",
                table: "Cadastro",
                column: "AtracoesId");

            migrationBuilder.CreateIndex(
                name: "IX_Cadastro_PassageirosId",
                table: "Cadastro",
                column: "PassageirosId");

            migrationBuilder.CreateIndex(
                name: "IX_Cadastro_TransporteId",
                table: "Cadastro",
                column: "TransporteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cadastro_Atracoes_AtracoesId",
                table: "Cadastro",
                column: "AtracoesId",
                principalTable: "Atracoes",
                principalColumn: "IdAtracoes",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cadastro_Passageiros_PassageirosId",
                table: "Cadastro",
                column: "PassageirosId",
                principalTable: "Passageiros",
                principalColumn: "IdPassageiros",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cadastro_Transporte_TransporteId",
                table: "Cadastro",
                column: "TransporteId",
                principalTable: "Transporte",
                principalColumn: "IdTransporte",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cadastro_Atracoes_AtracoesId",
                table: "Cadastro");

            migrationBuilder.DropForeignKey(
                name: "FK_Cadastro_Passageiros_PassageirosId",
                table: "Cadastro");

            migrationBuilder.DropForeignKey(
                name: "FK_Cadastro_Transporte_TransporteId",
                table: "Cadastro");

            migrationBuilder.DropIndex(
                name: "IX_Cadastro_AtracoesId",
                table: "Cadastro");

            migrationBuilder.DropIndex(
                name: "IX_Cadastro_PassageirosId",
                table: "Cadastro");

            migrationBuilder.DropIndex(
                name: "IX_Cadastro_TransporteId",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "AtracoesId",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "PassageirosId",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "TransporteId",
                table: "Cadastro");
        }
    }
}
