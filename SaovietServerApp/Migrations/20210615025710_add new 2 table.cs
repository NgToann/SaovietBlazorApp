using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaovietServerBlazorApp.Migrations
{
    public partial class addnew2table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ProductNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TypeOfShoes = table.Column<int>(type: "int", nullable: false),
                    GTNPONo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UCustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ETD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArticleNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShoeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PatternNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MidsoleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutsoleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnable = table.Column<bool>(type: "bit", nullable: false),
                    Reviser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ProductNo);
                });

            migrationBuilder.CreateTable(
                name: "OutsoleSuppliers",
                columns: table => new
                {
                    OutsoleSupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierOperation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutsoleSuppliers", x => x.OutsoleSupplierId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "OutsoleSuppliers");
        }
    }
}
