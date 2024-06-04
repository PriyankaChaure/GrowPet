using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class TaxTblEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CGSTRate",
                table: "TblTax");

            migrationBuilder.DropColumn(
                name: "IGSTRate",
                table: "TblTax");

            migrationBuilder.RenameColumn(
                name: "SGSTRate",
                table: "TblTax",
                newName: "TaxPercentage");

            migrationBuilder.CreateTable(
                name: "TblOrderTax",
                columns: table => new
                {
                    OrderTaxId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    TaxId = table.Column<long>(type: "bigint", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOrderTax", x => x.OrderTaxId);
                    table.ForeignKey(
                        name: "FK_TblOrderTax_TblOrder_OrderId",
                        column: x => x.OrderId,
                        principalTable: "TblOrder",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblOrderTax_TblTax_TaxId",
                        column: x => x.TaxId,
                        principalTable: "TblTax",
                        principalColumn: "TaxId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblOrderTax_OrderId",
                table: "TblOrderTax",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrderTax_TaxId",
                table: "TblOrderTax",
                column: "TaxId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblOrderTax");

            migrationBuilder.RenameColumn(
                name: "TaxPercentage",
                table: "TblTax",
                newName: "SGSTRate");

            migrationBuilder.AddColumn<decimal>(
                name: "CGSTRate",
                table: "TblTax",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "IGSTRate",
                table: "TblTax",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
