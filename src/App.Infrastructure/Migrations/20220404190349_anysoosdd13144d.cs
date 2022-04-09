using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace App.Infrastructure.Migrations
{
    public partial class anysoosdd13144d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivateConditions",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivateConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscountTypes",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Cost = table.Column<double>(type: "double precision", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OrderStatus = table.Column<int>(type: "integer", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    CategoryId = table.Column<short>(type: "smallint", nullable: false),
                    ShopOwnerId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_ShopOwnerId",
                        column: x => x.ShopOwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false),
                    DiscountTypeId = table.Column<short>(type: "smallint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounts_DiscountTypes_DiscountTypeId",
                        column: x => x.DiscountTypeId,
                        principalTable: "DiscountTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Discounts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Path = table.Column<string>(type: "text", nullable: false),
                    IsPrimary = table.Column<bool>(type: "boolean", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    PricePerPiece = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivationInfo",
                columns: table => new
                {
                    MinValueToActivateDiscount = table.Column<int>(type: "integer", nullable: false),
                    DiscountId = table.Column<long>(type: "bigint", nullable: false),
                    ActivateConditionId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ActivationInfo_ActivateConditions_ActivateConditionId",
                        column: x => x.ActivateConditionId,
                        principalTable: "ActivateConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivationInfo_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDiscounts",
                columns: table => new
                {
                    DiscountId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDiscounts", x => new { x.ApplicationUserId, x.DiscountId });
                    table.ForeignKey(
                        name: "FK_UserDiscounts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDiscounts_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuctionOffers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: false),
                    AuctionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuctionOffers_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auctions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsClosed = table.Column<bool>(type: "boolean", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    WinnerOfferId = table.Column<Guid>(type: "uuid", nullable: true),
                    InitialPrice = table.Column<double>(type: "double precision", nullable: false),
                    MinOfferPrice = table.Column<double>(type: "double precision", nullable: true),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auctions_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Auctions_AuctionOffers_WinnerOfferId",
                        column: x => x.WinnerOfferId,
                        principalTable: "AuctionOffers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Auctions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuctionParticipants",
                columns: table => new
                {
                    AuctionId = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionParticipants", x => new { x.AuctionId, x.ApplicationUserId });
                    table.ForeignKey(
                        name: "FK_AuctionParticipants_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuctionParticipants_Auctions_AuctionId",
                        column: x => x.AuctionId,
                        principalTable: "Auctions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08e77241-006f-44f2-8b94-50f99ed6ae10", "0dc6d3e5-5cde-4133-97fc-f39e7fbf08b7", "SHOP_OWNER", "SHOP_OWNER" },
                    { "477b9aee-b0a9-4dcc-bd59-168aa09f4efb", "a2c6b058-2b7e-4ff4-b242-3bbc01234120", "CUSTOMER", "CUSTOMER" },
                    { "d024b66b-98e2-4599-a90a-0f4a07c25346", "21cafe53-1dc6-4640-873e-0bd590a46fb9", "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01c58aec-8f23-4e5b-a5bb-bfe0078be41b", 0, "89f5208f-ace8-4e7c-ad04-c88c709da5f3", "shopOwner@email.com", true, false, null, "SHOPOWNER@EMAIL.COM", "SHOPOWNER", "AQAAAAEAACcQAAAAEEwhp9F19u6hIBavYaa0W+Fk/mwyxg9C5tMG7IvNefi7jgt4stRpYbBbZrRqE2Hadw==", null, false, "38b12638-645f-4b25-951f-7435000f8ab1", false, "shopOwner" },
                    { "4d80f441-b503-4ed0-857e-a0bba6bd77d6", 0, "2d966bb1-ed88-4838-acbb-c9dd23766fab", "customer@email.com", true, false, null, "CUSTOMER@EMAIL.COM", "CUSTOMER", "AQAAAAEAACcQAAAAELzcNxJNxUK6a9bwvCjUC8N7jIqMplBkXB+HZu7yWpenTmp/A5ppnbUuokHHwn5oUg==", null, false, "e0725ef4-36be-41f1-8f3b-b3a2b47fa445", false, "customer" },
                    { "f0befe3f-44a4-449f-a0b2-f29bafce7a21", 0, "2fc52c0b-3f1e-4560-bef1-f0f372998845", "admin@email.com", true, false, null, "ADMIN@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEDhXj2xvrSUtxUBZ1miuDtv4xmtKcb0tHlWn9MqUKJDCPeme+p/tnc6L0KsywaHV0A==", null, false, "1b0fda36-6b38-49f0-b7c6-1e9c2667083d", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { (short)1, "Clothes" },
                    { (short)2, "Grocery" },
                    { (short)3, "Barkery" },
                    { (short)4, "Makeup" },
                    { (short)5, "Bags" },
                    { (short)6, "Furniture" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "08e77241-006f-44f2-8b94-50f99ed6ae10", "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { "477b9aee-b0a9-4dcc-bd59-168aa09f4efb", "4d80f441-b503-4ed0-857e-a0bba6bd77d6" },
                    { "d024b66b-98e2-4599-a90a-0f4a07c25346", "f0befe3f-44a4-449f-a0b2-f29bafce7a21" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "Quantity", "ShopOwnerId" },
                values: new object[,]
                {
                    { 32283761L, (short)2, "Ex nam et possimus rerum id culpa consequatur labore quia.", "Betsy", 3.8399999999999999, 1775191186L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 53517543L, (short)1, "Aperiam nulla odio ut enim ea labore.", "Hettie", 0.20399999999999999, 30221854L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 61195960L, (short)4, "Officia pariatur necessitatibus aut deserunt tempore voluptatem cum.", "Liliana", 1.0049999999999999, 1175310402L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 63426096L, (short)1, "Assumenda et id ut omnis expedita adipisci aut quis enim enim.", "Jeffery", 4.8680000000000003, 335732076L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 73793008L, (short)4, "Sint dicta nisi tempora perspiciatis accusantium ut ut.", "Destiny", 1.0669999999999999, 1003875984L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 75501977L, (short)3, "Possimus quibusdam odio voluptas qui similique eos repudiandae voluptates possimus.", "Keely", 12.599, 1185659670L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 90946088L, (short)1, "Nam vel aut culpa aut est veritatis autem dolores.", "Erik", 1.768, 1436157034L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 140333168L, (short)3, "Fugit quis quis soluta sunt natus aut dolore.", "Julianne", 0.14499999999999999, 243109250L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 190166049L, (short)3, "Est a sequi voluptas minus pariatur.", "Axel", 0.79000000000000004, 389407943L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 194915481L, (short)4, "Rem et omnis animi eum.", "Lily", 6.1379999999999999, 520476588L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 195063006L, (short)3, "Nemo eum quaerat rerum magni aut hic alias.", "Marvin", 7.9820000000000002, 1156565984L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 215358545L, (short)2, "Qui nobis qui enim autem minus odit quaerat qui dolorum.", "Davion", 12.379, 844901865L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 239089006L, (short)2, "Enim fugit rerum nulla cum velit non odio pariatur ipsa.", "Bria", 0.64300000000000002, 1108067120L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 271730697L, (short)3, "Est porro est consectetur ut vero rerum eaque eligendi est quasi.", "Timmothy", 5.7400000000000002, 1533902429L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 292297028L, (short)1, "Occaecati cumque aut molestiae et cum laudantium nihil rerum.", "Reece", 12.823, 1362547984L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 300118136L, (short)3, "Sunt id consectetur occaecati fugiat et commodi ullam.", "Zackary", 3.7050000000000001, 342362288L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 304992628L, (short)1, "Vero est quidem sit magnam.", "Henri", 1.3160000000000001, 1949942957L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 328640567L, (short)3, "Officia saepe officiis eaque corrupti aut.", "Lula", 8.5280000000000005, 735672052L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 338992314L, (short)4, "Sed placeat ut autem incidunt nesciunt eaque.", "Reymundo", 10.487, 367588413L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 342128708L, (short)1, "Atque reprehenderit quo deserunt sint.", "Alexane", 6.1559999999999997, 1287957499L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 377681617L, (short)1, "Qui culpa voluptatum recusandae sed dolorem.", "Lenore", 6.8840000000000003, 1638424209L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 381542470L, (short)2, "Dolore odio sit facere incidunt fugit enim sed dolor.", "Ilene", 8.3949999999999996, 485954457L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 389678521L, (short)2, "Quasi id quis cumque quo.", "Larue", 3.8940000000000001, 1046430724L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 392784499L, (short)1, "Officia dolor aut aperiam odio omnis consequuntur rem voluptatibus nulla occaecati.", "Luther", 0.79800000000000004, 1691788819L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 420556473L, (short)3, "Autem placeat odit ut sed accusantium minus animi asperiores rerum.", "Eladio", 7.399, 1669274364L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 453655104L, (short)2, "Officiis velit sunt veniam harum maxime enim ab et.", "Alfred", 9.0719999999999992, 859590059L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 508237662L, (short)3, "Ab autem accusantium earum libero suscipit quasi ipsa.", "Marilyne", 4.0419999999999998, 242701063L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 514355670L, (short)4, "Excepturi commodi autem eum aut qui qui voluptas provident quis.", "Cindy", 4.0289999999999999, 1509269692L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 517934740L, (short)2, "Harum alias sed ipsa alias vitae enim.", "Scarlett", 7.7210000000000001, 350024374L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 521879992L, (short)1, "Et labore quis sed ratione consequatur praesentium.", "Ali", 1.403, 1821682206L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 523659536L, (short)4, "Dolor aspernatur sequi qui exercitationem est fuga.", "Wilford", 0.78400000000000003, 888690524L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 565847024L, (short)1, "Aut est at dolor et fugit.", "Ferne", 12.683, 1410272962L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 568710065L, (short)4, "Est eligendi porro adipisci quod animi ut eum et et.", "Augustus", 7.4770000000000003, 1655063702L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 585704895L, (short)3, "Voluptatem voluptates sint enim nihil corrupti nobis.", "Forrest", 12.555, 1503341166L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 597091796L, (short)1, "Repudiandae aspernatur suscipit est non et.", "Lila", 9.6029999999999998, 2025039289L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 663339767L, (short)2, "Minus quia quia vel ea.", "Cristobal", 2.1549999999999998, 1404591931L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 679852658L, (short)3, "Doloribus perferendis voluptatem optio culpa eum dolore nobis.", "Martine", 3.915, 158319825L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 685312009L, (short)1, "Aspernatur provident quia reprehenderit at.", "Una", 11.314, 275725978L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 704905474L, (short)3, "Vero explicabo consequatur animi quos sunt.", "Mozell", 4.5949999999999998, 2144386470L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 720964985L, (short)4, "Pariatur provident cumque maxime et quos asperiores deserunt ex assumenda unde.", "Angelina", 2.54, 824268788L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 740350016L, (short)3, "Ratione sit id beatae magni optio ullam.", "Nichole", 12.449, 1760855605L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 743680401L, (short)1, "Tenetur accusamus vero nihil perspiciatis ea illo.", "Cleve", 9.3900000000000006, 1616610368L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 748384628L, (short)2, "Eos hic mollitia rem expedita quibusdam.", "Lambert", 12.586, 1926161559L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 764975931L, (short)1, "Voluptas non ullam nemo voluptatem occaecati.", "Christine", 4.3579999999999997, 437225648L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 800300114L, (short)1, "Non distinctio cum velit dolorem consectetur quia qui.", "Mohammad", 9.9849999999999994, 1781601923L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 828329861L, (short)2, "Saepe dolorem eveniet voluptatem mollitia est.", "Jacklyn", 0.67100000000000004, 1606721292L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 845126254L, (short)1, "Aut quibusdam nisi impedit debitis sequi totam corporis.", "Leonora", 0.48399999999999999, 1241627567L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 864672832L, (short)1, "Laborum et aliquid optio qui id voluptas at aut natus.", "Roscoe", 4.7599999999999998, 1209081479L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 941657235L, (short)2, "Illum quae aperiam debitis iure sequi sunt vero eos sint alias.", "Zander", 0.69199999999999995, 1833239733L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 945849461L, (short)1, "Ipsum animi quia ullam doloribus porro odio.", "Corbin", 9.7029999999999994, 320764401L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 965422755L, (short)3, "Ipsum et ratione voluptatem provident commodi rerum rerum dicta recusandae voluptates.", "Wilford", 5.5540000000000003, 803929509L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 986109713L, (short)3, "Illo porro et provident minima quas et ratione officiis.", "Justice", 5.0940000000000003, 1301212122L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1080182921L, (short)2, "Iste adipisci aut eum quisquam modi tempora explicabo explicabo.", "Hildegard", 7.702, 695508094L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1084076632L, (short)2, "Est commodi cupiditate rerum nam sed sit adipisci.", "Bradford", 9.3379999999999992, 303458375L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1091458891L, (short)3, "In atque saepe cupiditate ut nobis id architecto.", "Abdiel", 11.898, 2022979717L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1123807586L, (short)3, "Nam explicabo debitis nobis rerum odio reiciendis ipsum quia enim quis.", "Maynard", 10.055999999999999, 845866134L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1130796932L, (short)4, "Possimus officia fugit dolor non atque in est sapiente facilis quae.", "Sylvia", 10.471, 1766724345L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1134093865L, (short)3, "Modi id odio incidunt aliquid cumque.", "Mittie", 0.52400000000000002, 563364204L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1135287557L, (short)4, "Enim quam laboriosam saepe aspernatur.", "Garrett", 11.154, 1535096615L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1194473980L, (short)3, "Quo voluptatem aut ut sed enim.", "Kory", 10.848000000000001, 1077625409L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1199807487L, (short)3, "Eos impedit alias delectus non ipsa sequi architecto asperiores et.", "Bernie", 3.4409999999999998, 1105148746L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1204044670L, (short)3, "Expedita esse nulla natus iste quae.", "Dorian", 12.042999999999999, 752799148L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1212757110L, (short)2, "Distinctio nisi amet unde eius sint dolore eius rem.", "King", 4.0199999999999996, 2041305352L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1214116056L, (short)3, "Libero nulla est incidunt tenetur cumque voluptas qui quibusdam vero libero.", "Jayne", 1.6060000000000001, 957505619L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1228188724L, (short)4, "Et consequatur reiciendis at dolor voluptatem illum ad harum delectus fugit.", "Laurine", 9.5399999999999991, 988998774L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1254926879L, (short)4, "Ut nulla beatae et qui repudiandae ut quas occaecati labore nisi.", "Jamey", 9.2409999999999997, 992679266L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1265081147L, (short)2, "Incidunt placeat similique voluptatibus soluta rerum debitis sint harum voluptatem.", "Clemens", 1.5469999999999999, 578195331L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1265597419L, (short)2, "Eligendi accusamus ut fugiat enim velit.", "Kurtis", 1.125, 646046474L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1266917135L, (short)1, "Sint voluptatibus est enim atque esse quis possimus est.", "Boris", 7.8410000000000002, 1804066777L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1281397211L, (short)2, "Eum repellat ullam harum error libero quia est aliquam eaque rerum.", "Lemuel", 9.7910000000000004, 1057788700L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1328078270L, (short)2, "Aut maiores esse doloremque cum sunt sit ut quis.", "Davonte", 0.57499999999999996, 175490877L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1350325577L, (short)2, "Dolore cumque incidunt sed quibusdam doloribus vitae ut.", "Louisa", 8.0250000000000004, 246298755L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1354729336L, (short)4, "Id laboriosam sunt est quas et in sint expedita consectetur.", "Trisha", 4.2770000000000001, 1440452634L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1362457079L, (short)1, "Quasi sint quis omnis et sunt quia quae illum omnis porro.", "Syble", 12.988, 524098992L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1387074653L, (short)4, "Perspiciatis sequi quia fugit voluptas quo.", "Clinton", 4.5090000000000003, 943648656L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1394289013L, (short)4, "Corporis veniam perspiciatis sit a eum totam.", "Linwood", 2.0219999999999998, 1146510405L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1423919967L, (short)1, "Veniam consequuntur illo non saepe eius qui neque occaecati eum.", "Twila", 8.6609999999999996, 354604677L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1427378006L, (short)1, "Qui autem totam nihil quia voluptatem illum dolorem.", "Keaton", 8.4649999999999999, 2003092197L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1435289650L, (short)3, "Autem rerum incidunt et qui accusamus.", "Dejuan", 10.561999999999999, 1529252074L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1441036814L, (short)2, "Dolorum sapiente rerum saepe rem quo blanditiis aut amet consectetur eum.", "Daija", 10.0, 800521944L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1441771351L, (short)1, "Quo deserunt similique aperiam nisi doloremque.", "Serenity", 10.472, 1558800762L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1444935501L, (short)3, "Repellat rerum tenetur delectus amet asperiores ut.", "Lawson", 4.5119999999999996, 1383643053L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1452546953L, (short)3, "Est et accusantium laborum quae vel hic placeat ea odio dolorem.", "Sabryna", 0.016, 1274324315L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1462537218L, (short)2, "Et et quia corrupti sed atque aut est consequatur asperiores odit.", "Manuela", 11.119999999999999, 393951205L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1470384348L, (short)3, "Officiis et recusandae voluptate fugiat iure veritatis.", "Lizzie", 11.257999999999999, 504150366L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1476224540L, (short)3, "Culpa officiis vitae et facere adipisci repellat eligendi sint et.", "Celestine", 3.403, 1055071179L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1498688720L, (short)4, "Alias et placeat est ipsum molestias iure voluptatibus aspernatur explicabo iusto.", "Katarina", 7.2270000000000003, 1941339717L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1505479806L, (short)1, "Necessitatibus at sequi similique qui ut.", "Daphney", 12.09, 607696174L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1572132675L, (short)1, "A ipsam corrupti pariatur quidem.", "Daphnee", 7.0510000000000002, 201173935L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1596696758L, (short)2, "Ut sunt consectetur officiis sint atque quo omnis.", "Sonya", 4.101, 1690967436L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1624504323L, (short)4, "Quasi aut natus veritatis fugiat enim dolorem recusandae consequatur tenetur amet.", "Waldo", 9.1620000000000008, 1173916503L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1631695905L, (short)4, "Sunt hic tempore illum a possimus aut quia libero porro.", "Mathilde", 4.8860000000000001, 568074923L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1634417625L, (short)4, "Quod nisi autem tempora id aliquid numquam.", "Salvatore", 12.122, 259746509L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1636120294L, (short)2, "Expedita distinctio doloribus ea deleniti minus vel placeat doloribus dolore et.", "Hortense", 2.919, 1724933231L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1647734535L, (short)4, "A illo sed illum sit labore.", "Jalen", 9.1950000000000003, 1146151368L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1656763819L, (short)2, "Maxime quam consectetur consequatur quas est sed perferendis.", "Madaline", 11.967000000000001, 655039101L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1666019350L, (short)2, "Qui sed placeat ex commodi voluptates.", "Marietta", 12.32, 1914432213L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1671580299L, (short)1, "Commodi velit laboriosam qui explicabo maiores nemo.", "Stuart", 1.3420000000000001, 987369070L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1679790343L, (short)4, "Eaque enim assumenda qui repellendus odio nam molestias nam blanditiis aut.", "Kade", 11.189, 1334181029L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1686545785L, (short)3, "Inventore alias et aperiam voluptatem harum nisi rerum.", "Eudora", 11.132, 170335528L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1689122989L, (short)3, "Ut necessitatibus qui tempore reprehenderit vero voluptatibus.", "Lurline", 12.048999999999999, 2064311427L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1738961749L, (short)1, "Soluta deleniti a exercitationem quasi illo non omnis.", "Willis", 2.177, 367534819L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1739519853L, (short)4, "Ab consequuntur ipsa sit a.", "Ismael", 2.9710000000000001, 37887761L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1740861162L, (short)3, "Fuga quia sed maiores dolor.", "Connie", 11.987, 1565262126L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1760953015L, (short)3, "Aut et id molestias sequi vel.", "Art", 12.914, 1789174991L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1767835028L, (short)4, "Rerum recusandae dolorem in voluptas animi vitae illo explicabo ab.", "Liliane", 5.8840000000000003, 1882547612L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1775984037L, (short)1, "In consequatur doloribus nostrum et qui esse.", "Adonis", 9.2460000000000004, 384611056L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1791402983L, (short)1, "Tenetur blanditiis aspernatur rem voluptatem quam enim atque.", "Xavier", 4.6299999999999999, 621008067L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1791756965L, (short)3, "Aliquam aut omnis ullam facilis.", "Deontae", 1.9199999999999999, 173968668L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1796033155L, (short)3, "A ut repellat enim quam.", "Colt", 9.0289999999999999, 1344951530L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1809660331L, (short)4, "Numquam autem eos delectus quae rerum.", "Jeanie", 8.9459999999999997, 1395994811L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1822782154L, (short)2, "Qui eveniet nihil consequatur aliquid modi occaecati incidunt deleniti et hic.", "Ruthe", 10.301, 1130600878L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1822970204L, (short)1, "Mollitia nam omnis doloribus perferendis aperiam.", "Lenore", 2.0339999999999998, 1826704179L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1823132082L, (short)1, "Corrupti in magnam ullam esse ex consequatur harum.", "Chesley", 3.1909999999999998, 347713707L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1890727708L, (short)1, "Dolorum perferendis iure mollitia voluptates impedit at.", "Ocie", 12.318, 1871681279L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1911851064L, (short)3, "Alias eum adipisci sunt harum mollitia alias libero.", "Jackie", 4.8220000000000001, 1387780170L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1922152279L, (short)1, "Sapiente odio ut in quaerat iusto eius.", "Jaqueline", 10.223000000000001, 1396872325L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1946653162L, (short)3, "Est sit cumque voluptas qui voluptate et dolorum laborum ea.", "Kristy", 10.868, 335209093L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1960677363L, (short)4, "Dolore aut dolores non consequuntur consequuntur repellendus consequuntur.", "Deondre", 9.5150000000000006, 936257076L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 1982481432L, (short)2, "Facilis sit fugit accusamus voluptas.", "Chad", 5.4930000000000003, 1280707512L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2010901044L, (short)2, "Distinctio nam cupiditate quas sit placeat dolores dolorem quo asperiores.", "Loraine", 8.0060000000000002, 237784796L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2018608720L, (short)3, "Et quod doloribus quo a aut rerum et dolor consequatur doloribus.", "Otis", 5.8559999999999999, 455097135L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2025373227L, (short)1, "Blanditiis libero eius deleniti fugiat veniam odit quibusdam.", "Kari", 3.847, 170884394L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2025597517L, (short)1, "Quaerat soluta suscipit saepe placeat qui dolores deleniti.", "Julien", 6.7510000000000003, 1594317521L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2039051843L, (short)1, "Eius itaque tenetur aut sint aspernatur odit quis quas ut.", "Reilly", 10.093, 1241488907L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2056800471L, (short)2, "Velit adipisci repellat assumenda molestiae.", "Jamey", 7.1719999999999997, 217268006L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2058461681L, (short)4, "Id commodi ea aut cupiditate.", "Krystel", 12.872999999999999, 1860160372L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2066222485L, (short)3, "Fugit totam perspiciatis necessitatibus fugit quas expedita odit reprehenderit a.", "Jason", 3.9900000000000002, 440629252L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2086803259L, (short)3, "Eveniet et quaerat animi eum id.", "Gerhard", 5.4720000000000004, 1225326071L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2126034521L, (short)3, "Voluptatem saepe qui saepe debitis omnis.", "Maximus", 5.9359999999999999, 180967159L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2127654058L, (short)3, "Libero repellendus voluptatem ullam id id aut et ut beatae.", "Julia", 0.42199999999999999, 35627650L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2130681244L, (short)3, "Molestias tenetur iste eos praesentium quo consequatur nemo fugiat modi.", "Krystina", 9.2400000000000002, 249999761L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2132895602L, (short)4, "Unde excepturi labore dolore ipsam aut asperiores.", "Anika", 1.514, 1250990349L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" },
                    { 2145431306L, (short)2, "Eaque cum debitis veritatis sit officiis molestias unde ea.", "Terrance", 4.6280000000000001, 179486966L, "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivationInfo_ActivateConditionId",
                table: "ActivationInfo",
                column: "ActivateConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivationInfo_DiscountId",
                table: "ActivationInfo",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuctionOffers_ApplicationUserId",
                table: "AuctionOffers",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionOffers_AuctionId",
                table: "AuctionOffers",
                column: "AuctionId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionParticipants_ApplicationUserId",
                table: "AuctionParticipants",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_CreatorId",
                table: "Auctions",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_ProductId",
                table: "Auctions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_WinnerOfferId",
                table: "Auctions",
                column: "WinnerOfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_DiscountTypeId",
                table: "Discounts",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_ProductId",
                table: "Discounts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_ProductId",
                table: "Media",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShopOwnerId",
                table: "Products",
                column: "ShopOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDiscounts_DiscountId",
                table: "UserDiscounts",
                column: "DiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionOffers_Auctions_AuctionId",
                table: "AuctionOffers",
                column: "AuctionId",
                principalTable: "Auctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuctionOffers_Auctions_AuctionId",
                table: "AuctionOffers");

            migrationBuilder.DropTable(
                name: "ActivationInfo");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AuctionParticipants");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "UserDiscounts");

            migrationBuilder.DropTable(
                name: "ActivateConditions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "DiscountTypes");

            migrationBuilder.DropTable(
                name: "Auctions");

            migrationBuilder.DropTable(
                name: "AuctionOffers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
