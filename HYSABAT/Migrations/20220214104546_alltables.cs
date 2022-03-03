using Microsoft.EntityFrameworkCore.Migrations;

namespace HYSABAT.Migrations
{
    public partial class alltables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DashBoardFeatures");

            migrationBuilder.DropColumn(
                name: "CompanyEmail",
                table: "contactUs");

            migrationBuilder.DropColumn(
                name: "CompanyLocation",
                table: "contactUs");

            migrationBuilder.DropColumn(
                name: "CompanyPhone",
                table: "contactUs");

            migrationBuilder.RenameColumn(
                name: "FreeSupport",
                table: "pricingPlans",
                newName: "planfeatures5");

            migrationBuilder.RenameColumn(
                name: "FreeSpace",
                table: "pricingPlans",
                newName: "planfeatures4");

            migrationBuilder.RenameColumn(
                name: "FreeService",
                table: "pricingPlans",
                newName: "planfeatures3");

            migrationBuilder.RenameColumn(
                name: "CreateUser",
                table: "pricingPlans",
                newName: "planfeatures2");

            migrationBuilder.RenameColumn(
                name: "AnalyticsOfBussiness",
                table: "pricingPlans",
                newName: "planfeatures1");

            migrationBuilder.CreateTable(
                name: "companyContactInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companyContactInformation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companyContactInformation");

            migrationBuilder.RenameColumn(
                name: "planfeatures5",
                table: "pricingPlans",
                newName: "FreeSupport");

            migrationBuilder.RenameColumn(
                name: "planfeatures4",
                table: "pricingPlans",
                newName: "FreeSpace");

            migrationBuilder.RenameColumn(
                name: "planfeatures3",
                table: "pricingPlans",
                newName: "FreeService");

            migrationBuilder.RenameColumn(
                name: "planfeatures2",
                table: "pricingPlans",
                newName: "CreateUser");

            migrationBuilder.RenameColumn(
                name: "planfeatures1",
                table: "pricingPlans",
                newName: "AnalyticsOfBussiness");

            migrationBuilder.AddColumn<string>(
                name: "CompanyEmail",
                table: "contactUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyLocation",
                table: "contactUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyPhone",
                table: "contactUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DashBoardFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dashBoardType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashBoardFeatures", x => x.Id);
                });
        }
    }
}
