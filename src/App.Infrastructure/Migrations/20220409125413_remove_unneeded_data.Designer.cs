﻿// <auto-generated />
using System;
using App.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace App.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220409125413_remove_unneeded_data")]
    partial class remove_unneeded_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("App.Domain.Models.Auctions.Auction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("InitialPrice")
                        .HasColumnType("double precision");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<double?>("MinOfferPrice")
                        .HasColumnType("double precision");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("WinnerOfferId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WinnerOfferId");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("App.Domain.Models.Auctions.AuctionOffers.AuctionOffer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("AuctionId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("AuctionId");

                    b.ToTable("AuctionOffers");
                });

            modelBuilder.Entity("App.Domain.Models.Auctions.AuctionParticipants.AuctionParticipant", b =>
                {
                    b.Property<Guid>("AuctionId")
                        .HasColumnType("uuid");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("text");

                    b.HasKey("AuctionId", "ApplicationUserId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("AuctionParticipants");
                });

            modelBuilder.Entity("App.Domain.Models.Discounts.Discount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<short>("DiscountTypeId")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DiscountTypeId");

                    b.HasIndex("ProductId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("App.Domain.Models.Discounts.DiscountActivationInfo.ActivationInfo", b =>
                {
                    b.Property<short>("ActivateConditionId")
                        .HasColumnType("smallint");

                    b.Property<long>("DiscountId")
                        .HasColumnType("bigint");

                    b.Property<int>("MinValueToActivateDiscount")
                        .HasColumnType("integer");

                    b.HasIndex("ActivateConditionId");

                    b.HasIndex("DiscountId");

                    b.ToTable("ActivationInfo");
                });

            modelBuilder.Entity("App.Domain.Models.Discounts.DiscountActivationInfo.DiscountActivateCondition.ActivateCondition", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<short>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.HasKey("Id");

                    b.ToTable("ActivateConditions");
                });

            modelBuilder.Entity("App.Domain.Models.Discounts.DiscountTypes.DiscountType", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<short>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.HasKey("Id");

                    b.ToTable("DiscountTypes");
                });

            modelBuilder.Entity("App.Domain.Models.Discounts.UserDiscounts.UserDiscount", b =>
                {
                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("text");

                    b.Property<long>("DiscountId")
                        .HasColumnType("bigint");

                    b.HasKey("ApplicationUserId", "DiscountId");

                    b.HasIndex("DiscountId");

                    b.ToTable("UserDiscounts");
                });

            modelBuilder.Entity("App.Domain.Models.Orders.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Cost")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("App.Domain.Models.Orders.OrderProducts.OrderProduct", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<double>("PricePerPiece")
                        .HasColumnType("double precision");

                    b.Property<long>("Quantity")
                        .HasColumnType("bigint");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("App.Domain.Models.Products.Categories.Category", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<short>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = (short)1,
                            Name = "Clothes"
                        },
                        new
                        {
                            Id = (short)2,
                            Name = "Grocery"
                        },
                        new
                        {
                            Id = (short)3,
                            Name = "Barkery"
                        },
                        new
                        {
                            Id = (short)4,
                            Name = "Makeup"
                        },
                        new
                        {
                            Id = (short)5,
                            Name = "Bags"
                        },
                        new
                        {
                            Id = (short)6,
                            Name = "Furniture"
                        });
                });

            modelBuilder.Entity("App.Domain.Models.Products.Media.Media", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("boolean");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("App.Domain.Models.Products.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<short>("CategoryId")
                        .HasColumnType("smallint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<long>("Quantity")
                        .HasColumnType("bigint");

                    b.Property<string>("ShopOwnerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ShopOwnerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("App.Domain.Models.Users.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "78a57554-0ff6-4451-8107-f34b232b6a92",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e9c9caa9-3f81-4f5e-8491-80649c3e25dd",
                            Email = "admin@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAECtGoOF40oI/IDMVA9CNxQgX06cNMc/1j5N/C7S3k8mZR0g+p5jx96P9As5KKXTM0Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "58dff278-d8bc-4546-a74a-6b57281b0d1c",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "fb6dcd26-5263-45d9-8fd8-dec79443cb49",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "49327975-2470-466e-b00f-c14e7b73c9e6",
                            Email = "customer@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER@EMAIL.COM",
                            NormalizedUserName = "CUSTOMER",
                            PasswordHash = "AQAAAAEAACcQAAAAELmDVJuNfaCdn04te+ar7M8LWbb1wQVhCvm9+mDbKal/jF5p835Fqzi6z4V/Txtyag==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "50fa56f2-b356-4550-bce9-b4e0acb96a61",
                            TwoFactorEnabled = false,
                            UserName = "customer"
                        },
                        new
                        {
                            Id = "8af7562f-de44-461f-b92e-a4f6945674c0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0e53a40a-f3ab-4773-9e54-6152679b6b61",
                            Email = "shopOwner@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SHOPOWNER@EMAIL.COM",
                            NormalizedUserName = "SHOPOWNER",
                            PasswordHash = "AQAAAAEAACcQAAAAEDPjtLUMlAY+CJ3ILJk/FAV9I244Cx9Ws3QR1aYCqXDtojprA2ZBoGcmoYKA7kbNUg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1407c757-3770-4757-8d1d-2b23e145a582",
                            TwoFactorEnabled = false,
                            UserName = "shopOwner"
                        },
                        new
                        {
                            Id = "a13e73ea-c429-4731-a77c-ef081bc999a9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "65479d27-3cb5-4b90-b492-fbcb172e8778",
                            Email = "driver@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DRIVER@EMAIL.COM",
                            NormalizedUserName = "DRIVER",
                            PasswordHash = "AQAAAAEAACcQAAAAENo18DVAY1Bc0ybLXHvyXzRloky0tLs/k3bNUwub/gWJ3gVjuDB6hD/LfhqNzd4Itg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ca15fa10-02be-4d7f-afcc-ca322ddc7824",
                            TwoFactorEnabled = false,
                            UserName = "driver"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "30dd2a75-8f4d-4a39-a67a-f4807f910309",
                            ConcurrencyStamp = "c119a6d5-899e-4fb6-b419-dfa3e2e95d00",
                            Name = "CUSTOMER",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "31dcb0d3-4053-4fcc-b74c-7cd68e166947",
                            ConcurrencyStamp = "92723ae5-8aa8-4f37-b45d-550dedf9823e",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "5f3eb3f3-5d5e-4869-ae4e-aa40afeac913",
                            ConcurrencyStamp = "b20033cb-a6ab-4cb5-a18a-a788ee32acd6",
                            Name = "SHOP_OWNER",
                            NormalizedName = "SHOP_OWNER"
                        },
                        new
                        {
                            Id = "33ccbd7d-5a32-417f-9abc-3da2528f20ea",
                            ConcurrencyStamp = "aa76633d-babf-44ba-8230-984977720232",
                            Name = "DRIVER_ROLE",
                            NormalizedName = "DRIVER_ROLE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "78a57554-0ff6-4451-8107-f34b232b6a92",
                            RoleId = "31dcb0d3-4053-4fcc-b74c-7cd68e166947"
                        },
                        new
                        {
                            UserId = "fb6dcd26-5263-45d9-8fd8-dec79443cb49",
                            RoleId = "30dd2a75-8f4d-4a39-a67a-f4807f910309"
                        },
                        new
                        {
                            UserId = "8af7562f-de44-461f-b92e-a4f6945674c0",
                            RoleId = "5f3eb3f3-5d5e-4869-ae4e-aa40afeac913"
                        },
                        new
                        {
                            UserId = "a13e73ea-c429-4731-a77c-ef081bc999a9",
                            RoleId = "33ccbd7d-5a32-417f-9abc-3da2528f20ea"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("App.Domain.Models.Auctions.Auction", b =>
                {
                    b.HasOne("App.Domain.Models.Users.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Models.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Models.Auctions.AuctionOffers.AuctionOffer", "WinnerOffer")
                        .WithMany()
                        .HasForeignKey("WinnerOfferId");

                    b.Navigation("Creator");

                    b.Navigation("Product");

                    b.Navigation("WinnerOffer");
                });

            modelBuilder.Entity("App.Domain.Models.Auctions.AuctionOffers.AuctionOffer", b =>
                {
                    b.HasOne("App.Domain.Models.Users.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Models.Auctions.Auction", "Auction")
                        .WithMany("AuctionOffers")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Auction");
                });

            modelBuilder.Entity("App.Domain.Models.Auctions.AuctionParticipants.AuctionParticipant", b =>
                {
                    b.HasOne("App.Domain.Models.Users.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Models.Auctions.Auction", "Auction")
                        .WithMany("AuctionParticipants")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Auction");
                });

            modelBuilder.Entity("App.Domain.Models.Discounts.Discount", b =>
                {
                    b.HasOne("App.Domain.Models.Discounts.DiscountTypes.DiscountType", "DiscountType")
                        .WithMany()
                        .HasForeignKey("DiscountTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Models.Products.Product", "Product")
                        .WithMany("Discounts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiscountType");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("App.Domain.Models.Discounts.DiscountActivationInfo.ActivationInfo", b =>
                {
                    b.HasOne("App.Domain.Models.Discounts.DiscountActivationInfo.DiscountActivateCondition.ActivateCondition", "ActivateCondition")
                        .WithMany()
                        .HasForeignKey("ActivateConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Models.Discounts.Discount", "Discount")
                        .WithMany()
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActivateCondition");

                    b.Navigation("Discount");
                });

            modelBuilder.Entity("App.Domain.Models.Discounts.UserDiscounts.UserDiscount", b =>
                {
                    b.HasOne("App.Domain.Models.Users.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Models.Discounts.Discount", "Discount")
                        .WithMany()
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Discount");
                });

            modelBuilder.Entity("App.Domain.Models.Orders.Order", b =>
                {
                    b.HasOne("App.Domain.Models.Users.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("App.Domain.Models.Orders.OrderProducts.OrderProduct", b =>
                {
                    b.HasOne("App.Domain.Models.Orders.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Models.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("App.Domain.Models.Products.Media.Media", b =>
                {
                    b.HasOne("App.Domain.Models.Products.Product", "Product")
                        .WithMany("Media")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("App.Domain.Models.Products.Product", b =>
                {
                    b.HasOne("App.Domain.Models.Products.Categories.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Models.Users.ApplicationUser", "ShopOwner")
                        .WithMany()
                        .HasForeignKey("ShopOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("ShopOwner");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("App.Domain.Models.Users.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("App.Domain.Models.Users.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Models.Users.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("App.Domain.Models.Users.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("App.Domain.Models.Auctions.Auction", b =>
                {
                    b.Navigation("AuctionOffers");

                    b.Navigation("AuctionParticipants");
                });

            modelBuilder.Entity("App.Domain.Models.Orders.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("App.Domain.Models.Products.Product", b =>
                {
                    b.Navigation("Discounts");

                    b.Navigation("Media");
                });
#pragma warning restore 612, 618
        }
    }
}
