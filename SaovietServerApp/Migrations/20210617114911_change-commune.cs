using Microsoft.EntityFrameworkCore.Migrations;

namespace SaovietServerBlazorApp.Migrations
{
    public partial class changecommune : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Commue",
                table: "Addresses",
                newName: "Commune");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Commune",
                table: "Addresses",
                newName: "Commue");
        }
    }
}
