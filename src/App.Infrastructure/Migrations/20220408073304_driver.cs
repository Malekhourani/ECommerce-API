using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructure.Migrations
{
    public partial class driver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "08e77241-006f-44f2-8b94-50f99ed6ae10", "01c58aec-8f23-4e5b-a5bb-bfe0078be41b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "477b9aee-b0a9-4dcc-bd59-168aa09f4efb", "4d80f441-b503-4ed0-857e-a0bba6bd77d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d024b66b-98e2-4599-a90a-0f4a07c25346", "f0befe3f-44a4-449f-a0b2-f29bafce7a21" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32283761L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53517543L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61195960L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63426096L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73793008L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75501977L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90946088L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140333168L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190166049L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194915481L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195063006L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215358545L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239089006L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271730697L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292297028L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300118136L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304992628L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 328640567L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338992314L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342128708L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 377681617L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 381542470L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 389678521L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 392784499L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 420556473L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 453655104L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 508237662L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 514355670L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 517934740L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 521879992L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 523659536L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 565847024L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 568710065L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 585704895L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 597091796L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 663339767L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 679852658L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 685312009L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 704905474L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 720964985L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 740350016L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 743680401L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 748384628L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 764975931L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 800300114L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 828329861L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 845126254L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 864672832L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 941657235L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 945849461L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 965422755L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 986109713L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1080182921L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1084076632L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1091458891L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1123807586L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1130796932L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1134093865L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1135287557L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1194473980L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1199807487L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1204044670L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1212757110L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1214116056L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1228188724L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1254926879L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1265081147L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1265597419L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1266917135L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1281397211L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1328078270L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1350325577L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1354729336L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1362457079L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1387074653L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1394289013L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1423919967L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1427378006L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1435289650L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1441036814L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1441771351L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1444935501L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1452546953L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1462537218L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1470384348L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1476224540L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1498688720L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1505479806L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1572132675L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1596696758L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1624504323L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1631695905L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1634417625L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1636120294L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1647734535L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1656763819L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1666019350L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1671580299L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1679790343L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1686545785L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1689122989L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1738961749L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1739519853L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1740861162L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1760953015L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1767835028L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1775984037L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1791402983L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1791756965L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1796033155L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1809660331L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1822782154L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1822970204L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1823132082L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1890727708L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1911851064L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1922152279L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1946653162L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1960677363L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1982481432L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2010901044L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2018608720L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2025373227L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2025597517L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2039051843L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2056800471L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2058461681L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2066222485L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2086803259L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2126034521L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2127654058L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2130681244L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2132895602L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2145431306L);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08e77241-006f-44f2-8b94-50f99ed6ae10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "477b9aee-b0a9-4dcc-bd59-168aa09f4efb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d024b66b-98e2-4599-a90a-0f4a07c25346");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01c58aec-8f23-4e5b-a5bb-bfe0078be41b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d80f441-b503-4ed0-857e-a0bba6bd77d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0befe3f-44a4-449f-a0b2-f29bafce7a21");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "49f8806a-bcaa-45c6-b271-18393790fa53", "475df997-3f39-4a59-8d41-2d24257fde56", "DRIVER_ROLE", "DRIVER_ROLE" },
                    { "559ec502-b660-455e-b7df-6142117ebc29", "23e494c1-152c-4c2e-b129-add4bffe4969", "CUSTOMER", "CUSTOMER" },
                    { "93330f0c-c8b3-4a56-950f-0922ec464747", "8e76b3a6-2135-4ead-88bf-ae40a559f602", "SHOP_OWNER", "SHOP_OWNER" },
                    { "abe6f984-3dcb-476d-8f75-31059488b506", "1c567c16-07bd-4103-85d1-8c3606335709", "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "143c07e6-e5a1-46b7-8488-1c132bc18d84", 0, "ec21dd88-1926-46c2-828f-7cc8a0185b1a", "shopOwner@email.com", true, false, null, "SHOPOWNER@EMAIL.COM", "SHOPOWNER", "AQAAAAEAACcQAAAAEBH5xKeyADTVKhytUVbdqmPe9TqCKqJNJ2mFhBkA35OdiL9bmLNVnZNCgcFiwLwbVw==", null, false, "20eb0deb-bba5-4cb2-a4a7-b7573da6814a", false, "shopOwner" },
                    { "83e4b023-0456-436a-8923-ae67d8fb7571", 0, "6cc5d64c-1d36-44b9-bb57-686ef10b6507", "driver@email.com", true, false, null, "DRIVER@EMAIL.COM", "DRIVER", "AQAAAAEAACcQAAAAEB7wCbBPLhOa1kVBC4V16Y/e8Dj/sNihrG4d8w7xeXhPI+WcN+MZjmUkNynQZxjyeQ==", null, false, "3b454ab6-daf3-4884-8959-ac7c0d993c9f", false, "driver" },
                    { "94e3c9f1-095e-4dd0-99ee-27a7eb42abb1", 0, "4159b89f-5651-4110-a497-ae3cc732a2b9", "admin@email.com", true, false, null, "ADMIN@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEJ3AS9WVxGKvt16tEH5xpqqMR8IdNwg4kWE3iyouS6zWSrrjrI1KMsVCDJm/gKdtgA==", null, false, "29804a22-4628-4f96-9b4c-6c2b918db15b", false, "admin" },
                    { "add2e569-1c0e-4450-9f59-5cf42f216575", 0, "3530da7d-893b-4395-9ab6-43b32a081b6d", "customer@email.com", true, false, null, "CUSTOMER@EMAIL.COM", "CUSTOMER", "AQAAAAEAACcQAAAAEFUbq1tAKVszVjj9gmUhKoJSUf1RabCzlbDDr0wBjZFEY0BDJMrvzosalby5arxerg==", null, false, "0a8a2477-37ce-4c63-ad15-28f6749e2f16", false, "customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "93330f0c-c8b3-4a56-950f-0922ec464747", "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { "49f8806a-bcaa-45c6-b271-18393790fa53", "83e4b023-0456-436a-8923-ae67d8fb7571" },
                    { "abe6f984-3dcb-476d-8f75-31059488b506", "94e3c9f1-095e-4dd0-99ee-27a7eb42abb1" },
                    { "559ec502-b660-455e-b7df-6142117ebc29", "add2e569-1c0e-4450-9f59-5cf42f216575" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "Quantity", "ShopOwnerId" },
                values: new object[,]
                {
                    { 21460567L, (short)3, "Soluta nisi quo natus ipsam maxime molestias officiis quae repellendus.", "Buddy", 5.4669999999999996, 754572909L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 33965445L, (short)3, "Culpa nihil et aut quia iure.", "Zella", 6.9260000000000002, 1892282644L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 56396054L, (short)1, "Quas ut quisquam ut dolor maiores sequi doloremque.", "Moriah", 10.601000000000001, 1491691028L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 67790465L, (short)4, "Eum eum deserunt magni sit repellendus esse debitis optio.", "Kelley", 10.079000000000001, 852790077L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 77486763L, (short)3, "Eaque dolorem illum aliquid cupiditate quis officia et dolor nam.", "Quinton", 4.6669999999999998, 544777374L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 80537180L, (short)4, "A voluptatem nihil sunt non vel architecto quam rerum nisi neque.", "Zachary", 6.4039999999999999, 2058350463L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 88568634L, (short)1, "Vero quasi est iusto et unde impedit est quia.", "Harry", 4.7750000000000004, 1500098157L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 94280288L, (short)2, "Accusamus vero fugiat quia enim.", "Marilou", 3.0630000000000002, 1342729452L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 94813752L, (short)1, "Cumque natus est eaque perferendis ut corporis possimus quisquam molestiae odio.", "Gaetano", 3.758, 1004993844L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 115632515L, (short)2, "Ut nisi reiciendis maiores quia ducimus autem dolor eum quo consectetur.", "Soledad", 4.3330000000000002, 1886572112L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 172911712L, (short)3, "Quisquam consectetur et perferendis tenetur.", "Misty", 12.454000000000001, 381378824L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 177584758L, (short)1, "Rem qui debitis illo voluptas omnis ratione sequi itaque.", "Kory", 7.5060000000000002, 221293280L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 186992853L, (short)3, "Similique optio minus sed doloremque accusantium in voluptate quod nihil.", "Lavern", 8.6150000000000002, 1594541484L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 191358466L, (short)2, "Dolorem dolor et dolorem iure.", "Leanna", 1.53, 881270516L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 207646260L, (short)3, "Omnis sed expedita deleniti id aut enim.", "Marisa", 12.704000000000001, 1866477277L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 223472821L, (short)3, "Quibusdam qui et ratione neque enim et quos.", "Susana", 11.75, 1742004196L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 240310340L, (short)4, "Fugiat sint voluptatibus aut eum qui repellat cupiditate rem soluta.", "Zackery", 8.3260000000000005, 559034314L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 246323194L, (short)2, "Id pariatur dicta magnam necessitatibus excepturi qui voluptates.", "Leatha", 7.1040000000000001, 1618313460L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 274100645L, (short)1, "Magnam in assumenda non earum non itaque molestias praesentium consequatur.", "Hunter", 1.375, 2096802736L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 274125982L, (short)2, "Rerum assumenda saepe voluptatem vero nulla incidunt ea amet iusto nisi.", "Beryl", 1.5089999999999999, 1984079081L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 277635967L, (short)1, "Aperiam beatae minus culpa tempora odit.", "Loma", 1.728, 1053196785L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 292216546L, (short)4, "Ipsam accusamus consequatur atque reprehenderit.", "Kali", 1.03, 1995429981L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 300309051L, (short)1, "Rerum occaecati molestiae expedita vel commodi fuga at.", "Frederique", 4.2619999999999996, 703035866L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 309075211L, (short)3, "Provident ipsam in maxime sed occaecati.", "Antwon", 1.0549999999999999, 1925391245L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 321145926L, (short)4, "Nam sint deserunt aspernatur nihil consequatur consequatur voluptas quaerat.", "Theodore", 0.89100000000000001, 889665304L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 329375235L, (short)4, "Adipisci est dignissimos eius vitae qui sequi ut.", "Etha", 10.491, 1856653260L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 342049467L, (short)3, "Magnam mollitia corporis voluptatem occaecati aut ipsa dolorem ea.", "Kennith", 6.8730000000000002, 723186873L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 398197700L, (short)2, "Ullam ipsum repellat aut sed consequatur aut iusto.", "Carmelo", 8.2219999999999995, 1782112643L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 403628711L, (short)3, "Ut voluptatem dolore in placeat aut.", "Maddison", 2.4620000000000002, 1532093713L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 409402260L, (short)4, "Veritatis sed omnis illum totam.", "Reta", 7.0529999999999999, 719783901L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 421851085L, (short)2, "Fugiat ipsam inventore aut itaque unde ea.", "Rigoberto", 12.234, 19986727L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 449747368L, (short)2, "Et consequatur mollitia molestiae voluptatum est.", "Bobbie", 6.7060000000000004, 1452592501L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 456140206L, (short)4, "Expedita quasi voluptatem repudiandae voluptas fugit aut.", "Stuart", 3.706, 116369329L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 473268657L, (short)4, "Ducimus voluptas qui ratione enim et alias qui omnis dolor.", "Phoebe", 1.4379999999999999, 436624181L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 493295999L, (short)2, "Non vero libero omnis vero qui modi voluptatum et.", "Lionel", 11.686999999999999, 32805963L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 503543700L, (short)2, "Voluptatum quia vero dolorem aperiam ipsam voluptatem.", "Dion", 9.5890000000000004, 504156045L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 522085996L, (short)1, "Voluptatem placeat sit et modi quia.", "Lizzie", 4.3029999999999999, 8514107L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 558044576L, (short)3, "Quia aut quo porro ut in saepe sapiente tenetur.", "Lois", 10.068, 949210446L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 568426682L, (short)3, "Dolores et quibusdam reprehenderit dolorum earum fugiat veniam fuga.", "Aiyana", 8.2189999999999994, 1948562925L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 587948936L, (short)3, "Modi nesciunt ea tempore maiores alias amet.", "Liza", 1.5109999999999999, 281919044L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 590024659L, (short)4, "Laudantium voluptas veniam eveniet adipisci pariatur et eos porro deleniti.", "Kaden", 7.9589999999999996, 715582136L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 602284659L, (short)1, "Cupiditate non neque ullam consequatur architecto qui et ut est et.", "Eriberto", 8.5830000000000002, 1353475417L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 609663485L, (short)4, "Rerum quis amet laudantium tempore neque asperiores.", "Wilbert", 3.7200000000000002, 734624158L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 617093992L, (short)2, "Qui officiis id velit ut sed pariatur cupiditate quam aut.", "Helen", 10.907, 4172867L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 622614702L, (short)3, "Quis aut aperiam sed architecto nobis tempore.", "Jaylin", 3.8839999999999999, 498218831L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 638716727L, (short)3, "Qui autem mollitia quis ratione.", "Itzel", 5.7370000000000001, 156077214L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 674848978L, (short)1, "Laboriosam neque nesciunt nobis distinctio exercitationem tenetur vel voluptas.", "Gregory", 4.54, 1783854899L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 685845007L, (short)4, "Minus dolorum aut optio sint et cum incidunt non debitis autem.", "Zena", 3.879, 214647709L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 695598213L, (short)3, "Aperiam rem quia dolore labore rem impedit.", "Margaretta", 2.8690000000000002, 1436006285L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 702992484L, (short)4, "Harum est consequatur perspiciatis ipsam delectus tempore.", "Emilie", 4.9509999999999996, 993004586L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 730283537L, (short)4, "Maiores quo cupiditate minima ut unde sit velit alias.", "Gabe", 4.0670000000000002, 1427398842L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 749874611L, (short)2, "Maiores delectus qui aperiam exercitationem et quaerat qui blanditiis est necessitatibus.", "Darius", 9.8200000000000003, 350473851L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 761820536L, (short)3, "Voluptatem eligendi sapiente voluptas consectetur libero rerum.", "Garth", 6.5119999999999996, 1499218059L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 773500185L, (short)4, "Assumenda aliquam et est aut.", "Minerva", 9.4459999999999997, 592496332L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 774438262L, (short)4, "Dolore vitae a non quasi pariatur aut.", "Clementina", 6.3120000000000003, 1400518787L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 780461407L, (short)2, "Aut voluptatum ut qui et dignissimos nam inventore architecto voluptatibus.", "Rita", 12.973000000000001, 503522533L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 821386418L, (short)2, "Quo dolor ab aut aspernatur modi distinctio neque.", "Garnet", 2.3300000000000001, 445884348L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 829609751L, (short)4, "Recusandae qui aliquid dolor voluptas.", "Kurtis", 1.179, 1738434662L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 856154189L, (short)1, "Velit sit rem nulla fuga nemo a voluptates harum perspiciatis.", "Kristy", 2.1320000000000001, 1184177429L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 864506850L, (short)3, "Quod ex quibusdam suscipit aut recusandae unde veniam natus id cupiditate.", "Lempi", 12.173999999999999, 363163902L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 867632581L, (short)3, "Sint reprehenderit asperiores sed eligendi ipsa cumque alias iure placeat fugiat.", "Tia", 0.86299999999999999, 150825638L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 894187852L, (short)2, "Voluptatibus voluptate quaerat saepe est esse adipisci doloribus qui qui.", "Ora", 6.6429999999999998, 1401392901L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 908426165L, (short)2, "Ut quisquam facere praesentium corporis voluptatibus veniam rem corrupti.", "Jamaal", 0.67800000000000005, 1082585363L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 918229328L, (short)1, "Aut et qui mollitia atque voluptatem ullam.", "Marquise", 12.382999999999999, 50210229L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 920080125L, (short)2, "Repudiandae in voluptatem ut et at omnis delectus eos quia.", "Ellsworth", 12.601000000000001, 268213433L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 965177566L, (short)3, "Eum eum repudiandae delectus quibusdam repellendus est non.", "Petra", 2.1269999999999998, 794949316L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 966725098L, (short)2, "Dolores dolores modi provident voluptate inventore incidunt voluptas eum.", "Eden", 7.883, 1493573989L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 987543534L, (short)2, "Ut et corrupti reprehenderit aut nulla.", "Vernice", 8.1600000000000001, 948884301L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1008062145L, (short)3, "Cum non quis cum aliquam omnis molestiae assumenda.", "Octavia", 2.016, 1521660089L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1020330818L, (short)1, "Incidunt cupiditate nemo nemo modi aliquam voluptates.", "Destiny", 6.9610000000000003, 1589941252L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1020938367L, (short)3, "Qui consequatur architecto ex vel optio.", "Brennan", 10.087, 984451115L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1063992380L, (short)2, "Consequuntur et placeat ab possimus et dolores veritatis odio voluptates nemo.", "Jarrell", 6.5990000000000002, 1232004131L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1072360005L, (short)3, "Aut tenetur quod repellat velit sed doloribus ad.", "Tanner", 11.753, 1394331167L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1075739972L, (short)2, "Molestias rerum sequi aut omnis.", "Terrell", 6.1360000000000001, 1328327836L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1115330996L, (short)4, "Quam necessitatibus et repellendus voluptatem quos odit vitae et assumenda.", "Chauncey", 9.6679999999999993, 1979190062L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1118740095L, (short)3, "Maiores similique velit totam temporibus occaecati.", "Kaitlyn", 6.9109999999999996, 1955812296L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1124223733L, (short)1, "Et distinctio delectus minus aut reiciendis labore corporis.", "Dee", 6.6369999999999996, 1997468671L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1144352163L, (short)1, "In sit omnis et quaerat.", "Amber", 2.149, 822960592L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1166769381L, (short)2, "Eum aliquid corporis cupiditate porro in soluta tempore blanditiis autem.", "Arvid", 10.565, 611940316L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1229056486L, (short)1, "Doloremque voluptas ratione dolor minus.", "Adele", 3.4329999999999998, 901675887L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1238172362L, (short)2, "Qui consectetur beatae est cum rerum omnis.", "Weldon", 6.8010000000000002, 44554681L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1247973071L, (short)3, "Expedita velit voluptatem temporibus maxime reprehenderit qui repellendus sed.", "Alysha", 12.755000000000001, 1983628310L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1306813233L, (short)4, "Nulla nihil fugit qui eum est.", "Rosalyn", 3.5640000000000001, 1545972449L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1350383081L, (short)4, "Quisquam deleniti in enim eius fugit qui natus voluptatem quia et.", "Alvina", 1.458, 1441169105L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1363690906L, (short)1, "Aut accusamus distinctio ad nam ullam architecto.", "Catalina", 9.5199999999999996, 1500067939L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1367630980L, (short)3, "Laboriosam nulla animi exercitationem minus animi.", "Herbert", 2.585, 963168858L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1377379220L, (short)3, "Et unde sapiente consequatur id debitis dignissimos vel perferendis.", "Carmela", 11.798999999999999, 1716070543L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1385946489L, (short)3, "Dolorum labore voluptas rerum accusantium fugiat ea.", "Jarrett", 9.0079999999999991, 279785210L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1405350324L, (short)3, "Delectus nisi est ut qui.", "Yadira", 9.3599999999999994, 566469676L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1415274972L, (short)3, "A aut similique sequi minima quia veritatis sint.", "Vaughn", 10.861000000000001, 305817461L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1458911629L, (short)2, "Ipsam modi iusto et quo in et praesentium.", "Tressie", 4.0270000000000001, 602263651L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1482499303L, (short)2, "Veritatis voluptate qui rerum dolores hic neque omnis iure.", "Modesto", 11.962, 600529714L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1489793793L, (short)2, "Omnis aliquid sapiente nobis fugit tempora.", "Turner", 9.5229999999999997, 2109700095L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1500042224L, (short)3, "Minus aliquid iste sunt officia sed.", "Jordan", 10.026, 142845937L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1505762577L, (short)3, "Est aut voluptas esse aut saepe occaecati harum necessitatibus.", "Josefina", 3.3119999999999998, 1415886932L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1534369756L, (short)2, "Nostrum earum est et iure quod reprehenderit esse.", "Carolyn", 3.339, 185954744L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1536025617L, (short)3, "Labore quibusdam quia maxime totam assumenda quia ab.", "Oren", 12.744, 1533061903L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1544072258L, (short)3, "Et magnam eos iure placeat voluptatem qui fuga.", "Sandra", 2.3239999999999998, 47455100L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1568512321L, (short)4, "Laboriosam voluptatem odit aut dolor qui vel quas accusantium eius voluptatem.", "Lyla", 9.2390000000000008, 352763240L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1585304578L, (short)2, "Quod minima consectetur expedita dolores perspiciatis dolores ex nihil.", "Judge", 2.4430000000000001, 686437784L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1588812336L, (short)2, "Omnis omnis dignissimos nihil quia ex.", "Finn", 12.849, 1775374793L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1590226912L, (short)2, "Error consequatur et velit minima nulla ipsa.", "Luther", 12.266999999999999, 2102263220L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1592560670L, (short)1, "Non molestias animi nihil et earum consequatur officiis magni.", "Blanca", 3.4209999999999998, 1361881020L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1604396762L, (short)1, "Recusandae quaerat esse voluptatem ad consectetur doloremque ab.", "Nelle", 3.3079999999999998, 65928023L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1608957229L, (short)3, "Magnam dolores et officiis tempora ullam quo ratione.", "Nestor", 3.4319999999999999, 1904855560L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1621793182L, (short)3, "Incidunt odit ipsa sunt est a voluptatem est eum et.", "Thelma", 6.2999999999999998, 815087820L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1626749781L, (short)1, "Dolores voluptatum perspiciatis non expedita necessitatibus earum debitis voluptatibus.", "Aurelie", 11.298999999999999, 1411113878L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1641831953L, (short)4, "Temporibus veniam incidunt quibusdam deleniti non.", "Merritt", 5.3570000000000002, 278078099L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1652803176L, (short)3, "Suscipit nostrum ea id voluptas asperiores sunt.", "Travis", 7.1879999999999997, 654519445L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1663140187L, (short)2, "Quae nam provident dolore rerum explicabo ipsa est quo odit id.", "Melvin", 10.050000000000001, 815393155L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1685781331L, (short)2, "Sed aut reiciendis et sint eius.", "Juliet", 9.6039999999999992, 1296696312L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1692331713L, (short)4, "Reiciendis distinctio amet cupiditate omnis ipsum tempore aut necessitatibus aut.", "Keven", 10.422000000000001, 1758281210L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1742125279L, (short)1, "Voluptatem aperiam eos quam quo.", "Augustine", 12.871, 1636519253L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1759123542L, (short)2, "Odio est sit quis quibusdam qui consequatur animi ducimus corporis velit.", "Pearline", 11.836, 2146720463L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1768561458L, (short)3, "Eos id ut non et qui veniam doloribus atque nobis.", "Michaela", 12.625, 438680836L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1792197742L, (short)3, "Magnam dolor dolorem maiores qui consequatur.", "Laurel", 11.496, 1234072339L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1794586244L, (short)2, "Amet voluptate qui omnis earum.", "Ashleigh", 6.79, 1654178429L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1825260065L, (short)3, "Aut consectetur iusto omnis earum porro expedita soluta.", "Gonzalo", 2.851, 617978179L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1833879024L, (short)1, "Architecto ullam eligendi recusandae nihil sed sint nobis.", "Chelsey", 5.2060000000000004, 1732612371L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1905401267L, (short)3, "Aliquam aut quis vitae et ea aut dolorum.", "Mason", 8.5220000000000002, 1748512884L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1922559917L, (short)1, "Veniam fugit sapiente dolorem distinctio.", "Jamaal", 6.9420000000000002, 441523069L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1928246449L, (short)1, "Repellendus explicabo enim illum dolore eius corporis aspernatur.", "Jakob", 1.3580000000000001, 2070146084L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1940809232L, (short)4, "Consequatur est et qui corrupti et.", "Edwardo", 2.1869999999999998, 1550720155L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1941731564L, (short)1, "Hic eligendi facere cumque quos magnam sed.", "Carmella", 10.223000000000001, 276165869L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1969427166L, (short)2, "Officia nemo quos voluptates enim et id hic dignissimos reiciendis eos.", "Tillman", 9.2989999999999995, 998551845L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 1992472094L, (short)1, "Repellendus quod perspiciatis quo unde quis officiis reiciendis quidem tenetur.", "Richmond", 3.4700000000000002, 1355468003L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 2004657601L, (short)2, "Et expedita nostrum nesciunt exercitationem sunt necessitatibus.", "Urban", 2.8109999999999999, 1754974441L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 2017480433L, (short)3, "Dolorem inventore ut recusandae numquam voluptas qui.", "Albert", 8.4659999999999993, 906162488L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 2022593753L, (short)3, "Facere vel beatae consectetur sunt qui quam officiis laborum non animi.", "Garnet", 9.3919999999999995, 2052337338L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 2031677945L, (short)3, "Natus omnis optio ipsam cumque quia dicta quam expedita harum cum.", "Jazmyne", 5.9550000000000001, 61953961L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 2053239465L, (short)2, "Fuga mollitia veritatis molestiae voluptas explicabo consequuntur doloribus nobis esse et.", "Jamaal", 4.2850000000000001, 747558010L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 2060170655L, (short)3, "Aut qui ex temporibus vel a aliquid eum quis.", "Olga", 6.0389999999999997, 814605306L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 2122403268L, (short)1, "Officia est et qui at quibusdam sed optio.", "Irma", 10.724, 441483891L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" },
                    { 2123381335L, (short)1, "Aut ex omnis consequatur laborum eum commodi asperiores quo labore.", "Cordie", 12.358000000000001, 1578115172L, "143c07e6-e5a1-46b7-8488-1c132bc18d84" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93330f0c-c8b3-4a56-950f-0922ec464747", "143c07e6-e5a1-46b7-8488-1c132bc18d84" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "49f8806a-bcaa-45c6-b271-18393790fa53", "83e4b023-0456-436a-8923-ae67d8fb7571" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "abe6f984-3dcb-476d-8f75-31059488b506", "94e3c9f1-095e-4dd0-99ee-27a7eb42abb1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "559ec502-b660-455e-b7df-6142117ebc29", "add2e569-1c0e-4450-9f59-5cf42f216575" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21460567L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33965445L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56396054L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67790465L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77486763L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80537180L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88568634L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94280288L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94813752L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115632515L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172911712L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177584758L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186992853L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191358466L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207646260L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223472821L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240310340L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246323194L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274100645L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274125982L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277635967L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292216546L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300309051L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 309075211L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 321145926L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 329375235L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342049467L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 398197700L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403628711L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 409402260L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 421851085L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 449747368L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 456140206L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 473268657L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 493295999L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 503543700L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 522085996L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 558044576L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 568426682L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 587948936L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 590024659L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 602284659L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 609663485L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 617093992L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 622614702L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 638716727L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 674848978L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 685845007L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 695598213L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 702992484L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 730283537L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 749874611L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 761820536L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 773500185L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 774438262L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 780461407L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 821386418L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 829609751L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 856154189L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 864506850L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 867632581L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 894187852L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 908426165L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 918229328L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 920080125L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 965177566L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 966725098L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 987543534L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1008062145L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1020330818L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1020938367L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1063992380L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1072360005L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1075739972L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1115330996L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1118740095L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1124223733L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1144352163L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1166769381L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1229056486L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1238172362L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1247973071L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1306813233L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1350383081L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1363690906L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1367630980L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1377379220L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1385946489L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1405350324L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1415274972L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1458911629L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1482499303L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1489793793L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1500042224L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1505762577L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1534369756L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1536025617L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1544072258L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1568512321L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1585304578L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1588812336L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1590226912L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1592560670L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1604396762L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1608957229L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1621793182L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1626749781L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1641831953L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1652803176L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1663140187L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1685781331L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1692331713L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1742125279L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1759123542L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1768561458L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1792197742L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1794586244L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1825260065L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1833879024L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1905401267L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1922559917L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1928246449L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1940809232L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1941731564L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1969427166L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1992472094L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2004657601L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2017480433L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2022593753L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2031677945L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2053239465L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2060170655L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2122403268L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2123381335L);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49f8806a-bcaa-45c6-b271-18393790fa53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "559ec502-b660-455e-b7df-6142117ebc29");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93330f0c-c8b3-4a56-950f-0922ec464747");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abe6f984-3dcb-476d-8f75-31059488b506");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143c07e6-e5a1-46b7-8488-1c132bc18d84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e4b023-0456-436a-8923-ae67d8fb7571");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94e3c9f1-095e-4dd0-99ee-27a7eb42abb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "add2e569-1c0e-4450-9f59-5cf42f216575");

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
        }
    }
}
