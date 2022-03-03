using Microsoft.EntityFrameworkCore.Migrations;

namespace HYSABAT.Migrations
{
    public partial class enumsprimarykey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plans",
                table: "contactInformation");

            migrationBuilder.AddColumn<int>(
                name: "PlansId",
                table: "contactInformation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContactInfoVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    plans = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfoVM", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contactInformation_PlansId",
                table: "contactInformation",
                column: "PlansId");

            migrationBuilder.AddForeignKey(
                name: "FK_contactInformation_ContactInfoVM_PlansId",
                table: "contactInformation",
                column: "PlansId",
                principalTable: "ContactInfoVM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contactInformation_ContactInfoVM_PlansId",
                table: "contactInformation");

            migrationBuilder.DropTable(
                name: "ContactInfoVM");

            migrationBuilder.DropIndex(
                name: "IX_contactInformation_PlansId",
                table: "contactInformation");

            migrationBuilder.DropColumn(
                name: "PlansId",
                table: "contactInformation");

            migrationBuilder.AddColumn<string>(
                name: "Plans",
                table: "contactInformation",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
