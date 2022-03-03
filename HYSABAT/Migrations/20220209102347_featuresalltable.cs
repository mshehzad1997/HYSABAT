using Microsoft.EntityFrameworkCore.Migrations;

namespace HYSABAT.Migrations
{
    public partial class featuresalltable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accountManagement");

            migrationBuilder.DropTable(
                name: "assests");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "helps");

            migrationBuilder.DropTable(
                name: "purchases");

            migrationBuilder.DropTable(
                name: "salesInformation");

            migrationBuilder.CreateTable(
                name: "features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DashboradTypes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_features", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "features");

            migrationBuilder.CreateTable(
                name: "accountManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DashboradTypes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountManagement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "assests",
                columns: table => new
                {
                    AssestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssesImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssestDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssetTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DashboradTypes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assests", x => x.AssestId);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DashboradTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "helps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DashboradTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpCenterDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpCenterImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpCenterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_helps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "purchases",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DashboradTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchases", x => x.PurchaseId);
                });

            migrationBuilder.CreateTable(
                name: "salesInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DashboradTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesInformation", x => x.Id);
                });
        }
    }
}
