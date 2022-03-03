using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HYSABAT.Migrations
{
    public partial class alldbmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accountManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    AssetTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssestDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssesImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assests", x => x.AssestId);
                });

            migrationBuilder.CreateTable(
                name: "business",
                columns: table => new
                {
                    BusinessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessMonthlyPrice = table.Column<int>(type: "int", nullable: false),
                    BusinessYearlyPrice = table.Column<int>(type: "int", nullable: false),
                    BusinessPlanFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business", x => x.BusinessId);
                });

            migrationBuilder.CreateTable(
                name: "contactInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NumberOfBranches = table.Column<int>(type: "int", nullable: false),
                    NumberOfUser = table.Column<int>(type: "int", nullable: false),
                    Postion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CRNumber = table.Column<int>(type: "int", nullable: false),
                    NumberOfCustomer = table.Column<int>(type: "int", nullable: false),
                    NumberOfSupliers = table.Column<int>(type: "int", nullable: false),
                    Bussiness = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    State = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Postal_ZipCode = table.Column<int>(type: "int", nullable: false),
                    NameOnCard = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreditCardNumber = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CVC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "contactUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CompanyLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "enterPrises",
                columns: table => new
                {
                    EnterpriseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnterpriseTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnterpriseMonthlyPrice = table.Column<int>(type: "int", nullable: false),
                    EnterpriseYearlyPrice = table.Column<int>(type: "int", nullable: false),
                    EnterprisePlanFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnterpriseImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enterPrises", x => x.EnterpriseId);
                });

            migrationBuilder.CreateTable(
                name: "helps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HelpCenterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpCenterDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpCenterImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    PurchaseTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchases", x => x.PurchaseId);
                });

            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "salesInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "starterPlans",
                columns: table => new
                {
                    StarterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StarterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StarterMonthlyPrice = table.Column<int>(type: "int", nullable: false),
                    StarterYearlyPrice = table.Column<int>(type: "int", nullable: false),
                    StarterPlanFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StarterImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_starterPlans", x => x.StarterId);
                });

            migrationBuilder.CreateTable(
                name: "videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bIDashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleId = table.Column<int>(type: "int", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    HelpCenterId = table.Column<int>(type: "int", nullable: true),
                    AssetId = table.Column<int>(type: "int", nullable: true),
                    PurchaseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bIDashboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bIDashboards_accountManagement_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accountManagement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bIDashboards_assests_AssetId",
                        column: x => x.AssetId,
                        principalTable: "assests",
                        principalColumn: "AssestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bIDashboards_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bIDashboards_helps_HelpCenterId",
                        column: x => x.HelpCenterId,
                        principalTable: "helps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bIDashboards_purchases_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "purchases",
                        principalColumn: "PurchaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bIDashboards_salesInformation_SaleId",
                        column: x => x.SaleId,
                        principalTable: "salesInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "fleetDashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleId = table.Column<int>(type: "int", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    HelpCenterId = table.Column<int>(type: "int", nullable: true),
                    AssetId = table.Column<int>(type: "int", nullable: true),
                    PurchaseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fleetDashboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_fleetDashboards_accountManagement_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accountManagement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_fleetDashboards_assests_AssetId",
                        column: x => x.AssetId,
                        principalTable: "assests",
                        principalColumn: "AssestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_fleetDashboards_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_fleetDashboards_helps_HelpCenterId",
                        column: x => x.HelpCenterId,
                        principalTable: "helps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_fleetDashboards_purchases_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "purchases",
                        principalColumn: "PurchaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_fleetDashboards_salesInformation_SaleId",
                        column: x => x.SaleId,
                        principalTable: "salesInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "kPIDashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleId = table.Column<int>(type: "int", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    HelpCenterId = table.Column<int>(type: "int", nullable: true),
                    AssetId = table.Column<int>(type: "int", nullable: true),
                    PurchaseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kPIDashboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_kPIDashboards_accountManagement_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accountManagement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_kPIDashboards_assests_AssetId",
                        column: x => x.AssetId,
                        principalTable: "assests",
                        principalColumn: "AssestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_kPIDashboards_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_kPIDashboards_helps_HelpCenterId",
                        column: x => x.HelpCenterId,
                        principalTable: "helps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_kPIDashboards_purchases_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "purchases",
                        principalColumn: "PurchaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_kPIDashboards_salesInformation_SaleId",
                        column: x => x.SaleId,
                        principalTable: "salesInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bIDashboards_AccountId",
                table: "bIDashboards",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_bIDashboards_AssetId",
                table: "bIDashboards",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_bIDashboards_EmployeeId",
                table: "bIDashboards",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_bIDashboards_HelpCenterId",
                table: "bIDashboards",
                column: "HelpCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_bIDashboards_PurchaseId",
                table: "bIDashboards",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_bIDashboards_SaleId",
                table: "bIDashboards",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_fleetDashboards_AccountId",
                table: "fleetDashboards",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_fleetDashboards_AssetId",
                table: "fleetDashboards",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_fleetDashboards_EmployeeId",
                table: "fleetDashboards",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_fleetDashboards_HelpCenterId",
                table: "fleetDashboards",
                column: "HelpCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_fleetDashboards_PurchaseId",
                table: "fleetDashboards",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_fleetDashboards_SaleId",
                table: "fleetDashboards",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_kPIDashboards_AccountId",
                table: "kPIDashboards",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_kPIDashboards_AssetId",
                table: "kPIDashboards",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_kPIDashboards_EmployeeId",
                table: "kPIDashboards",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_kPIDashboards_HelpCenterId",
                table: "kPIDashboards",
                column: "HelpCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_kPIDashboards_PurchaseId",
                table: "kPIDashboards",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_kPIDashboards_SaleId",
                table: "kPIDashboards",
                column: "SaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bIDashboards");

            migrationBuilder.DropTable(
                name: "business");

            migrationBuilder.DropTable(
                name: "contactInformation");

            migrationBuilder.DropTable(
                name: "contactUs");

            migrationBuilder.DropTable(
                name: "enterPrises");

            migrationBuilder.DropTable(
                name: "fleetDashboards");

            migrationBuilder.DropTable(
                name: "kPIDashboards");

            migrationBuilder.DropTable(
                name: "questions");

            migrationBuilder.DropTable(
                name: "starterPlans");

            migrationBuilder.DropTable(
                name: "videos");

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
        }
    }
}
