using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class addprodbrandcattodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GetBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GetCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GetProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductBrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GetProducts_GetBrands_ProductBrandId",
                        column: x => x.ProductBrandId,
                        principalTable: "GetBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GetProducts_GetCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "GetCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GetProducts_CategoryId",
                table: "GetProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GetProducts_ProductBrandId",
                table: "GetProducts",
                column: "ProductBrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetProducts");

            migrationBuilder.DropTable(
                name: "GetBrands");

            migrationBuilder.DropTable(
                name: "GetCategories");
        }
    }
}
