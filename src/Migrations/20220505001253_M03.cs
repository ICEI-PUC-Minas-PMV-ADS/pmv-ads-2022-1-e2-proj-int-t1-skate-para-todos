using Microsoft.EntityFrameworkCore.Migrations;

namespace skateparatodos.Migrations
{
    public partial class M03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoacoesItens_Usuarios_UsuarioId",
                table: "DoacoesItens");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "DoacoesItens",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DoacaoId",
                table: "DoacoesItens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DoacoesItens_DoacaoId",
                table: "DoacoesItens",
                column: "DoacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoacoesItens_Doacoes_DoacaoId",
                table: "DoacoesItens",
                column: "DoacaoId",
                principalTable: "Doacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoacoesItens_Usuarios_UsuarioId",
                table: "DoacoesItens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoacoesItens_Doacoes_DoacaoId",
                table: "DoacoesItens");

            migrationBuilder.DropForeignKey(
                name: "FK_DoacoesItens_Usuarios_UsuarioId",
                table: "DoacoesItens");

            migrationBuilder.DropIndex(
                name: "IX_DoacoesItens_DoacaoId",
                table: "DoacoesItens");

            migrationBuilder.DropColumn(
                name: "DoacaoId",
                table: "DoacoesItens");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "DoacoesItens",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DoacoesItens_Usuarios_UsuarioId",
                table: "DoacoesItens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
