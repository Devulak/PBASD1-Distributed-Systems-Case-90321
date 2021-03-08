using Microsoft.EntityFrameworkCore.Migrations;

namespace Case_90321.Data.Migrations
{
    public partial class UpdateProcentToPercent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiscountProcent",
                table: "ProductDiscounts",
                newName: "DiscountPercent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiscountPercent",
                table: "ProductDiscounts",
                newName: "DiscountProcent");
        }
    }
}
