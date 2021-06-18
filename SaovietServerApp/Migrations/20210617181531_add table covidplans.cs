using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaovietServerBlazorApp.Migrations
{
    public partial class addtablecovidplans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CovidPlans",
                columns: table => new
                {
                    WorkerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    ProvinceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommuneId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeathStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidPlans", x => x.WorkerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CovidPlans");
        }
    }
}
