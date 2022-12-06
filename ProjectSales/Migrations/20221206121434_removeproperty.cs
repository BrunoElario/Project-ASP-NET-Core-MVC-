using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectSales.Migrations
{
    public partial class removeproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "SalesRecord");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "SalesRecord",
                nullable: false,
                defaultValue: 0);
        }
    }
}
