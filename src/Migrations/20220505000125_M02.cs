using Microsoft.EntityFrameworkCore.Migrations;

namespace skateparatodos.Migrations
{
    public partial class M02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "DoacoesItens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DoacoesItens_UsuarioId",
                table: "DoacoesItens",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoacoesItens_Usuarios_UsuarioId",
                table: "DoacoesItens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoacoesItens_Usuarios_UsuarioId",
                table: "DoacoesItens");

            migrationBuilder.DropIndex(
                name: "IX_DoacoesItens_UsuarioId",
                table: "DoacoesItens");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "DoacoesItens");
        }
    }
}
