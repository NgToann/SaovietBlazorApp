using Microsoft.EntityFrameworkCore.Migrations;

namespace SaovietServerBlazorApp.Migrations
{
    public partial class initital2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OutsoleMaterialCheckingList",
                table: "OutsoleMaterialCheckingList");

            migrationBuilder.RenameTable(
                name: "OutsoleMaterialCheckingList",
                newName: "OutsoleMaterialCheckingList_2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutsoleMaterialCheckingList_2",
                table: "OutsoleMaterialCheckingList_2",
                column: "OSCheckID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OutsoleMaterialCheckingList_2",
                table: "OutsoleMaterialCheckingList_2");

            migrationBuilder.RenameTable(
                name: "OutsoleMaterialCheckingList_2",
                newName: "OutsoleMaterialCheckingList");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutsoleMaterialCheckingList",
                table: "OutsoleMaterialCheckingList",
                column: "OSCheckID");
        }
    }
}
