using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ruan.Migrations
{
    public partial class PrimeiraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Carrinho_UsuarioId",
                table: "Carrinho");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_UsuarioId",
                table: "Carrinho",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Carrinho_UsuarioId",
                table: "Carrinho");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Produto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_UsuarioId",
                table: "Carrinho",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id");
        }
    }
}
