using Microsoft.EntityFrameworkCore.Migrations;

namespace Case_90321.Data.Migrations
{
    public partial class MakeRequiredOnProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ClothingTypes_ClothingTypeId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClothingTypeId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ClothingTypes_ClothingTypeId",
                table: "Products",
                column: "ClothingTypeId",
                principalTable: "ClothingTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ClothingTypes_ClothingTypeId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ClothingTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ClothingTypes_ClothingTypeId",
                table: "Products",
                column: "ClothingTypeId",
                principalTable: "ClothingTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
