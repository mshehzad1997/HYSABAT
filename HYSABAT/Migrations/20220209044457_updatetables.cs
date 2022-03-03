using Microsoft.EntityFrameworkCore.Migrations;

namespace HYSABAT.Migrations
{
    public partial class updatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "business");

            migrationBuilder.DropTable(
                name: "enterPrises");

            migrationBuilder.DropTable(
                name: "starterPlans");

            migrationBuilder.AddColumn<string>(
                name: "DashboradTypes",
                table: "salesInformation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "question",
                table: "questions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Answers",
                table: "questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DashboradTypes",
                table: "purchases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DashboradTypes",
                table: "helps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DashboradTypes",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DashboradTypes",
                table: "assests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DashboradTypes",
                table: "accountManagement",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "pricingPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricingPlanTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricingPlanMonthlyPrice = table.Column<int>(type: "int", nullable: false),
                    PricingPlanYearlyPrice = table.Column<int>(type: "int", nullable: false),
                    PricingPlanPlanFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricingPlanImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pricingPlans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pricingPlans");

            migrationBuilder.DropColumn(
                name: "DashboradTypes",
                table: "salesInformation");

            migrationBuilder.DropColumn(
                name: "Answers",
                table: "questions");

            migrationBuilder.DropColumn(
                name: "DashboradTypes",
                table: "purchases");

            migrationBuilder.DropColumn(
                name: "DashboradTypes",
                table: "helps");

            migrationBuilder.DropColumn(
                name: "DashboradTypes",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "DashboradTypes",
                table: "assests");

            migrationBuilder.DropColumn(
                name: "DashboradTypes",
                table: "accountManagement");

            migrationBuilder.AlterColumn<string>(
                name: "question",
                table: "questions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "business",
                columns: table => new
                {
                    BusinessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessMonthlyPrice = table.Column<int>(type: "int", nullable: false),
                    BusinessPlanFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessYearlyPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business", x => x.BusinessId);
                });

            migrationBuilder.CreateTable(
                name: "enterPrises",
                columns: table => new
                {
                    EnterpriseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnterpriseImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnterpriseMonthlyPrice = table.Column<int>(type: "int", nullable: false),
                    EnterprisePlanFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnterpriseTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnterpriseYearlyPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enterPrises", x => x.EnterpriseId);
                });

            migrationBuilder.CreateTable(
                name: "starterPlans",
                columns: table => new
                {
                    StarterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StarterImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StarterMonthlyPrice = table.Column<int>(type: "int", nullable: false),
                    StarterPlanFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StarterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StarterYearlyPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_starterPlans", x => x.StarterId);
                });
        }
    }
}
