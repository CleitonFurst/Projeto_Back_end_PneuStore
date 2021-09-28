using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Pneus.Migrations
{
    public partial class correcaoCarrinho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "produtosId",
                table: "Carrinho",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_produtosId",
                table: "Carrinho",
                column: "produtosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrinho_Produtos_produtosId",
                table: "Carrinho",
                column: "produtosId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrinho_Produtos_produtosId",
                table: "Carrinho");

            migrationBuilder.DropIndex(
                name: "IX_Carrinho_produtosId",
                table: "Carrinho");

            migrationBuilder.DropColumn(
                name: "produtosId",
                table: "Carrinho");
        }
    }
}
