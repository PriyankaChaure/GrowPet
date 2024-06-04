using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class CartQuantitydatatypechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "TblCart",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "OrderTaxId",
                table: "TblCart",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblCart_OrderTaxId",
                table: "TblCart",
                column: "OrderTaxId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblCart_TblOrderTax_OrderTaxId",
                table: "TblCart",
                column: "OrderTaxId",
                principalTable: "TblOrderTax",
                principalColumn: "OrderTaxId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblCart_TblOrderTax_OrderTaxId",
                table: "TblCart");

            migrationBuilder.DropIndex(
                name: "IX_TblCart_OrderTaxId",
                table: "TblCart");

            migrationBuilder.DropColumn(
                name: "OrderTaxId",
                table: "TblCart");

            migrationBuilder.AlterColumn<long>(
                name: "Quantity",
                table: "TblCart",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
