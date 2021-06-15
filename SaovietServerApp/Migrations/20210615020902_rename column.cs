using Microsoft.EntityFrameworkCore.Migrations;

namespace SaovietServerBlazorApp.Migrations
{
    public partial class renamecolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OutsoleMaterialCheckingList_2",
                table: "OutsoleMaterialCheckingList_2");

            migrationBuilder.RenameTable(
                name: "OutsoleMaterialCheckingList_2",
                newName: "OutsoleMaterialCheckingList");

            migrationBuilder.RenameColumn(
                name: "OSCheckID",
                table: "OutsoleMaterialCheckingList",
                newName: "OSCheckingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutsoleMaterialCheckingList",
                table: "OutsoleMaterialCheckingList",
                column: "OSCheckingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OutsoleMaterialCheckingList",
                table: "OutsoleMaterialCheckingList");

            migrationBuilder.RenameTable(
                name: "OutsoleMaterialCheckingList",
                newName: "OutsoleMaterialCheckingList_2");

            migrationBuilder.RenameColumn(
                name: "OSCheckingID",
                table: "OutsoleMaterialCheckingList_2",
                newName: "OSCheckID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutsoleMaterialCheckingList_2",
                table: "OutsoleMaterialCheckingList_2",
                column: "OSCheckID");
        }
    }
}
