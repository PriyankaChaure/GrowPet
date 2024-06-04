using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class deletecategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblPetProduct_TblCategory_CategoryId",
                table: "TblPetProduct");

            migrationBuilder.DropIndex(
                name: "IX_TblPetProduct_CategoryId",
                table: "TblPetProduct");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "TblPetProduct");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoPath",
                table: "TblPet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CategoryId",
                table: "TblPetProduct",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoPath",
                table: "TblPet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblPetProduct_CategoryId",
                table: "TblPetProduct",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblPetProduct_TblCategory_CategoryId",
                table: "TblPetProduct",
                column: "CategoryId",
                principalTable: "TblCategory",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
