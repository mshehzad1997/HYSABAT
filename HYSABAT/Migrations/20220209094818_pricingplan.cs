using Microsoft.EntityFrameworkCore.Migrations;

namespace HYSABAT.Migrations
{
    public partial class pricingplan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameOfPricingPlan",
                table: "contactInformation");

            migrationBuilder.AddColumn<int>(
                name: "PricingPlanId",
                table: "contactInformation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_contactInformation_PricingPlanId",
                table: "contactInformation",
                column: "PricingPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_contactInformation_pricingPlans_PricingPlanId",
                table: "contactInformation",
                column: "PricingPlanId",
                principalTable: "pricingPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contactInformation_pricingPlans_PricingPlanId",
                table: "contactInformation");

            migrationBuilder.DropIndex(
                name: "IX_contactInformation_PricingPlanId",
                table: "contactInformation");

            migrationBuilder.DropColumn(
                name: "PricingPlanId",
                table: "contactInformation");

            migrationBuilder.AddColumn<string>(
                name: "NameOfPricingPlan",
                table: "contactInformation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
