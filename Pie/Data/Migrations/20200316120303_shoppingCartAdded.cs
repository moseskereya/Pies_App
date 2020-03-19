using Microsoft.EntityFrameworkCore.Migrations;

namespace Pie.Data.Migrations
{
    public partial class shoppingCartAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shoppingCarts",
                columns: table => new
                {
                    CartItem = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    CartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppingCarts", x => x.CartItem);
                    table.ForeignKey(
                        name: "FK_shoppingCarts_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_shoppingCarts_productId",
                table: "shoppingCarts",
                column: "productId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shoppingCarts");
        }
    }
}
