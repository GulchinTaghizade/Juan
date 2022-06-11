using Microsoft.EntityFrameworkCore.Migrations;

namespace JuanFronttoEnd.Migrations
{
    public partial class UpdatedImagesColoursTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColours_Colours_ColoursId",
                table: "ProductColours");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColours_Products_ProductsId",
                table: "ProductColours");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductsId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductsId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductColours_ColoursId",
                table: "ProductColours");

            migrationBuilder.DropIndex(
                name: "IX_ProductColours_ProductsId",
                table: "ProductColours");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ColoursId",
                table: "ProductColours");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "ProductColours");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColours_ColourID",
                table: "ProductColours",
                column: "ColourID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColours_ProductId",
                table: "ProductColours",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColours_Colours_ColourID",
                table: "ProductColours",
                column: "ColourID",
                principalTable: "Colours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColours_Products_ProductId",
                table: "ProductColours",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColours_Colours_ColourID",
                table: "ProductColours");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColours_Products_ProductId",
                table: "ProductColours");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductColours_ColourID",
                table: "ProductColours");

            migrationBuilder.DropIndex(
                name: "IX_ProductColours_ProductId",
                table: "ProductColours");

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColoursId",
                table: "ProductColours",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "ProductColours",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductsId",
                table: "ProductImages",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColours_ColoursId",
                table: "ProductColours",
                column: "ColoursId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColours_ProductsId",
                table: "ProductColours",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColours_Colours_ColoursId",
                table: "ProductColours",
                column: "ColoursId",
                principalTable: "Colours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColours_Products_ProductsId",
                table: "ProductColours",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductsId",
                table: "ProductImages",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
