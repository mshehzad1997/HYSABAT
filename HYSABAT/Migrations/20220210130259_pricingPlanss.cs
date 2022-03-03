using Microsoft.EntityFrameworkCore.Migrations;

namespace HYSABAT.Migrations
{
    public partial class pricingPlanss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PricingPlanPlanFeatures",
                table: "pricingPlans",
                newName: "FreeSupport");

            migrationBuilder.AddColumn<string>(
                name: "AnalyticsOfBussiness",
                table: "pricingPlans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "pricingPlans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FreeService",
                table: "pricingPlans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FreeSpace",
                table: "pricingPlans",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnalyticsOfBussiness",
                table: "pricingPlans");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "pricingPlans");

            migrationBuilder.DropColumn(
                name: "FreeService",
                table: "pricingPlans");

            migrationBuilder.DropColumn(
                name: "FreeSpace",
                table: "pricingPlans");

            migrationBuilder.RenameColumn(
                name: "FreeSupport",
                table: "pricingPlans",
                newName: "PricingPlanPlanFeatures");
        }
    }
}
