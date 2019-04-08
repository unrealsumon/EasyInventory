using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyInventory.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "TB_Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    UnitName = table.Column<string>(nullable: false),
                    Barcode = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_TB_Products_TB_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "TB_Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_Inventory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductID = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<float>(nullable: false),
                    Quanity = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Inventory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_Inventory_TB_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "TB_Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_Inventory_ProductID",
                table: "TB_Inventory",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_Products_CategoryID",
                table: "TB_Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Inventory");

            migrationBuilder.DropTable(
                name: "TB_Products");

            migrationBuilder.DropTable(
                name: "TB_Category");
        }
    }
}
