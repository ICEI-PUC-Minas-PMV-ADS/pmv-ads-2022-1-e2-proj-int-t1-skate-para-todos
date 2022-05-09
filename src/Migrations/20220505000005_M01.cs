using Microsoft.EntityFrameworkCore.Migrations;

namespace skateparatodos.Migrations
{
    public partial class M01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Doacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Doacoes_UsuarioId",
                table: "Doacoes",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doacoes_Usuarios_UsuarioId",
                table: "Doacoes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doacoes_Usuarios_UsuarioId",
                table: "Doacoes");

            migrationBuilder.DropIndex(
                name: "IX_Doacoes_UsuarioId",
                table: "Doacoes");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Doacoes");
        }
    }
}
