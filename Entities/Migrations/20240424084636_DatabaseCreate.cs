using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblAdmin",
                columns: table => new
                {
                    AdminId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAdmin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "TblCategory",
                columns: table => new
                {
                    CategoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCategory", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "TblCountry",
                columns: table => new
                {
                    CountryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCountry", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "TblDispatchAgency",
                columns: table => new
                {
                    DispatchAgencyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDispatchAgency", x => x.DispatchAgencyId);
                });

            migrationBuilder.CreateTable(
                name: "TblPetFamily",
                columns: table => new
                {
                    PetFamilyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetFamilyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPetFamily", x => x.PetFamilyId);
                });

            migrationBuilder.CreateTable(
                name: "TblPetType",
                columns: table => new
                {
                    PetTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPetType", x => x.PetTypeId);
                });

            migrationBuilder.CreateTable(
                name: "TblTax",
                columns: table => new
                {
                    TaxId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CGSTRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SGSTRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IGSTRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HSNSACNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTax", x => x.TaxId);
                });

            migrationBuilder.CreateTable(
                name: "TblState",
                columns: table => new
                {
                    StateId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblState", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_TblState_TblCountry_CountryId",
                        column: x => x.CountryId,
                        principalTable: "TblCountry",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblCity",
                columns: table => new
                {
                    CityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCity", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_TblCity_TblState_StateId",
                        column: x => x.StateId,
                        principalTable: "TblState",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblStore",
                columns: table => new
                {
                    StoreId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CityId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblStore", x => x.StoreId);
                    table.ForeignKey(
                        name: "FK_TblStore_TblCity_CityId",
                        column: x => x.CityId,
                        principalTable: "TblCity",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblUser",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUser", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_TblUser_TblCity_CityId",
                        column: x => x.CityId,
                        principalTable: "TblCity",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblProduct",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductType = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StoreId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProduct", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_TblProduct_TblStore_StoreId",
                        column: x => x.StoreId,
                        principalTable: "TblStore",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblOrder",
                columns: table => new
                {
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Orderdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    StoreId = table.Column<long>(type: "bigint", nullable: false),
                    IsPaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOrder", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_TblOrder_TblStore_StoreId",
                        column: x => x.StoreId,
                        principalTable: "TblStore",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblOrder_TblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "TblUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblStoreReview",
                columns: table => new
                {
                    StoreReviewId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreId = table.Column<long>(type: "bigint", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblStoreReview", x => x.StoreReviewId);
                    table.ForeignKey(
                        name: "FK_TblStoreReview_TblStore_StoreId",
                        column: x => x.StoreId,
                        principalTable: "TblStore",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblStoreReview_TblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "TblUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblCart",
                columns: table => new
                {
                    CartId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    StoreId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCart", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_TblCart_TblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TblProduct",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblCart_TblStore_StoreId",
                        column: x => x.StoreId,
                        principalTable: "TblStore",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblCart_TblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "TblUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblPet",
                columns: table => new
                {
                    PetId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<long>(type: "bigint", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    PetTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PetFamilyId = table.Column<long>(type: "bigint", nullable: false),
                    PetDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPet", x => x.PetId);
                    table.ForeignKey(
                        name: "FK_TblPet_TblPetFamily_PetFamilyId",
                        column: x => x.PetFamilyId,
                        principalTable: "TblPetFamily",
                        principalColumn: "PetFamilyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblPet_TblPetType_PetTypeId",
                        column: x => x.PetTypeId,
                        principalTable: "TblPetType",
                        principalColumn: "PetTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblPet_TblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TblProduct",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblPetFood",
                columns: table => new
                {
                    FoodId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MfgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    GoodFoodAccordingToPetAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPetFood", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_TblPetFood_TblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TblProduct",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblPetProduct",
                columns: table => new
                {
                    PetProductId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MfgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    ProductDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPetProduct", x => x.PetProductId);
                    table.ForeignKey(
                        name: "FK_TblPetProduct_TblCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TblCategory",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblPetProduct_TblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TblProduct",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblProductReview",
                columns: table => new
                {
                    ProductReviewId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ReviewDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProductReview", x => x.ProductReviewId);
                    table.ForeignKey(
                        name: "FK_TblProductReview_TblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TblProduct",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblProductReview_TblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "TblUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblComplaint",
                columns: table => new
                {
                    ComplaintId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplaintDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComplaintDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblComplaint", x => x.ComplaintId);
                    table.ForeignKey(
                        name: "FK_TblComplaint_TblOrder_OrderId",
                        column: x => x.OrderId,
                        principalTable: "TblOrder",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblComplaint_TblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TblProduct",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblDispatchOrder",
                columns: table => new
                {
                    DispatchOrederId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    DispatchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocketNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DispatchAgencyId = table.Column<long>(type: "bigint", nullable: false),
                    ExpectedReachDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDispatchOrder", x => x.DispatchOrederId);
                    table.ForeignKey(
                        name: "FK_TblDispatchOrder_TblDispatchAgency_DispatchAgencyId",
                        column: x => x.DispatchAgencyId,
                        principalTable: "TblDispatchAgency",
                        principalColumn: "DispatchAgencyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblDispatchOrder_TblOrder_OrderId",
                        column: x => x.OrderId,
                        principalTable: "TblOrder",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblOrderDet",
                columns: table => new
                {
                    OrderDetID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOrderDet", x => x.OrderDetID);
                    table.ForeignKey(
                        name: "FK_TblOrderDet_TblOrder_OrderId",
                        column: x => x.OrderId,
                        principalTable: "TblOrder",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblOrderDet_TblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TblProduct",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblOrderPayment",
                columns: table => new
                {
                    OrderPaymentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentMode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOrderPayment", x => x.OrderPaymentId);
                    table.ForeignKey(
                        name: "FK_TblOrderPayment_TblOrder_OrderId",
                        column: x => x.OrderId,
                        principalTable: "TblOrder",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblReturn",
                columns: table => new
                {
                    ReturnId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnReason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblReturn", x => x.ReturnId);
                    table.ForeignKey(
                        name: "FK_TblReturn_TblOrder_OrderId",
                        column: x => x.OrderId,
                        principalTable: "TblOrder",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblReturn_TblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TblProduct",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblPetPhotos",
                columns: table => new
                {
                    PetPhotosId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<long>(type: "bigint", nullable: false),
                    PhotoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPetPhotos", x => x.PetPhotosId);
                    table.ForeignKey(
                        name: "FK_TblPetPhotos_TblPet_PetId",
                        column: x => x.PetId,
                        principalTable: "TblPet",
                        principalColumn: "PetId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblSolution",
                columns: table => new
                {
                    SolutionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolutionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SolutionDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplaintId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSolution", x => x.SolutionId);
                    table.ForeignKey(
                        name: "FK_TblSolution_TblComplaint_ComplaintId",
                        column: x => x.ComplaintId,
                        principalTable: "TblComplaint",
                        principalColumn: "ComplaintId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblRefund",
                columns: table => new
                {
                    RefundId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReturnId = table.Column<long>(type: "bigint", nullable: false),
                    RefundDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefundAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblRefund", x => x.RefundId);
                    table.ForeignKey(
                        name: "FK_TblRefund_TblReturn_ReturnId",
                        column: x => x.ReturnId,
                        principalTable: "TblReturn",
                        principalColumn: "ReturnId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TblAdmin",
                columns: new[] { "AdminId", "Address", "EmailId", "FirstName", "LastName", "MobileNo", "Password" },
                values: new object[] { 1L, "Pune", "priya@gmail.com", "Priyanka", "Chaure", "9876543210", "1234" });

            migrationBuilder.CreateIndex(
                name: "IX_TblCart_ProductId",
                table: "TblCart",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCart_StoreId",
                table: "TblCart",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCart_UserId",
                table: "TblCart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCity_StateId",
                table: "TblCity",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_TblComplaint_OrderId",
                table: "TblComplaint",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TblComplaint_ProductId",
                table: "TblComplaint",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblDispatchOrder_DispatchAgencyId",
                table: "TblDispatchOrder",
                column: "DispatchAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_TblDispatchOrder_OrderId",
                table: "TblDispatchOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrder_StoreId",
                table: "TblOrder",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrder_UserId",
                table: "TblOrder",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrderDet_OrderId",
                table: "TblOrderDet",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrderDet_ProductId",
                table: "TblOrderDet",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrderPayment_OrderId",
                table: "TblOrderPayment",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPet_PetFamilyId",
                table: "TblPet",
                column: "PetFamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPet_PetTypeId",
                table: "TblPet",
                column: "PetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPet_ProductId",
                table: "TblPet",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPetFood_ProductId",
                table: "TblPetFood",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPetPhotos_PetId",
                table: "TblPetPhotos",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPetProduct_CategoryId",
                table: "TblPetProduct",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPetProduct_ProductId",
                table: "TblPetProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblProduct_StoreId",
                table: "TblProduct",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_TblProductReview_ProductId",
                table: "TblProductReview",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblProductReview_UserId",
                table: "TblProductReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblRefund_ReturnId",
                table: "TblRefund",
                column: "ReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_TblReturn_OrderId",
                table: "TblReturn",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TblReturn_ProductId",
                table: "TblReturn",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TblSolution_ComplaintId",
                table: "TblSolution",
                column: "ComplaintId");

            migrationBuilder.CreateIndex(
                name: "IX_TblState_CountryId",
                table: "TblState",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TblStore_CityId",
                table: "TblStore",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_TblStoreReview_StoreId",
                table: "TblStoreReview",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_TblStoreReview_UserId",
                table: "TblStoreReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TblUser_CityId",
                table: "TblUser",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblAdmin");

            migrationBuilder.DropTable(
                name: "TblCart");

            migrationBuilder.DropTable(
                name: "TblDispatchOrder");

            migrationBuilder.DropTable(
                name: "TblOrderDet");

            migrationBuilder.DropTable(
                name: "TblOrderPayment");

            migrationBuilder.DropTable(
                name: "TblPetFood");

            migrationBuilder.DropTable(
                name: "TblPetPhotos");

            migrationBuilder.DropTable(
                name: "TblPetProduct");

            migrationBuilder.DropTable(
                name: "TblProductReview");

            migrationBuilder.DropTable(
                name: "TblRefund");

            migrationBuilder.DropTable(
                name: "TblSolution");

            migrationBuilder.DropTable(
                name: "TblStoreReview");

            migrationBuilder.DropTable(
                name: "TblTax");

            migrationBuilder.DropTable(
                name: "TblDispatchAgency");

            migrationBuilder.DropTable(
                name: "TblPet");

            migrationBuilder.DropTable(
                name: "TblCategory");

            migrationBuilder.DropTable(
                name: "TblReturn");

            migrationBuilder.DropTable(
                name: "TblComplaint");

            migrationBuilder.DropTable(
                name: "TblPetFamily");

            migrationBuilder.DropTable(
                name: "TblPetType");

            migrationBuilder.DropTable(
                name: "TblOrder");

            migrationBuilder.DropTable(
                name: "TblProduct");

            migrationBuilder.DropTable(
                name: "TblUser");

            migrationBuilder.DropTable(
                name: "TblStore");

            migrationBuilder.DropTable(
                name: "TblCity");

            migrationBuilder.DropTable(
                name: "TblState");

            migrationBuilder.DropTable(
                name: "TblCountry");
        }
    }
}
