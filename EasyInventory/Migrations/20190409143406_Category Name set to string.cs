using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyInventory.Migrations
{
    public partial class CategoryNamesettostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "TB_Category",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryName",
                table: "TB_Category",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
