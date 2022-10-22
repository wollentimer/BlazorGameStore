using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorGameStore.Server.Migrations
{
    public partial class Add_Views : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Views",
                table: "Products");
        }
    }
}
