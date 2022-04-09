using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructure.Migrations
{
    public partial class remove_unneeded_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "30dd2a75-8f4d-4a39-a67a-f4807f910309", "c119a6d5-899e-4fb6-b419-dfa3e2e95d00", "CUSTOMER", "CUSTOMER" },
                    { "31dcb0d3-4053-4fcc-b74c-7cd68e166947", "92723ae5-8aa8-4f37-b45d-550dedf9823e", "ADMIN", "ADMIN" },
                    { "33ccbd7d-5a32-417f-9abc-3da2528f20ea", "aa76633d-babf-44ba-8230-984977720232", "DRIVER_ROLE", "DRIVER_ROLE" },
                    { "5f3eb3f3-5d5e-4869-ae4e-aa40afeac913", "b20033cb-a6ab-4cb5-a18a-a788ee32acd6", "SHOP_OWNER", "SHOP_OWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "78a57554-0ff6-4451-8107-f34b232b6a92", 0, "e9c9caa9-3f81-4f5e-8491-80649c3e25dd", "admin@email.com", true, false, null, "ADMIN@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAECtGoOF40oI/IDMVA9CNxQgX06cNMc/1j5N/C7S3k8mZR0g+p5jx96P9As5KKXTM0Q==", null, false, "58dff278-d8bc-4546-a74a-6b57281b0d1c", false, "admin" },
                    { "8af7562f-de44-461f-b92e-a4f6945674c0", 0, "0e53a40a-f3ab-4773-9e54-6152679b6b61", "shopOwner@email.com", true, false, null, "SHOPOWNER@EMAIL.COM", "SHOPOWNER", "AQAAAAEAACcQAAAAEDPjtLUMlAY+CJ3ILJk/FAV9I244Cx9Ws3QR1aYCqXDtojprA2ZBoGcmoYKA7kbNUg==", null, false, "1407c757-3770-4757-8d1d-2b23e145a582", false, "shopOwner" },
                    { "a13e73ea-c429-4731-a77c-ef081bc999a9", 0, "65479d27-3cb5-4b90-b492-fbcb172e8778", "driver@email.com", true, false, null, "DRIVER@EMAIL.COM", "DRIVER", "AQAAAAEAACcQAAAAENo18DVAY1Bc0ybLXHvyXzRloky0tLs/k3bNUwub/gWJ3gVjuDB6hD/LfhqNzd4Itg==", null, false, "ca15fa10-02be-4d7f-afcc-ca322ddc7824", false, "driver" },
                    { "fb6dcd26-5263-45d9-8fd8-dec79443cb49", 0, "49327975-2470-466e-b00f-c14e7b73c9e6", "customer@email.com", true, false, null, "CUSTOMER@EMAIL.COM", "CUSTOMER", "AQAAAAEAACcQAAAAELmDVJuNfaCdn04te+ar7M8LWbb1wQVhCvm9+mDbKal/jF5p835Fqzi6z4V/Txtyag==", null, false, "50fa56f2-b356-4550-bce9-b4e0acb96a61", false, "customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "31dcb0d3-4053-4fcc-b74c-7cd68e166947", "78a57554-0ff6-4451-8107-f34b232b6a92" },
                    { "5f3eb3f3-5d5e-4869-ae4e-aa40afeac913", "8af7562f-de44-461f-b92e-a4f6945674c0" },
                    { "33ccbd7d-5a32-417f-9abc-3da2528f20ea", "a13e73ea-c429-4731-a77c-ef081bc999a9" },
                    { "30dd2a75-8f4d-4a39-a67a-f4807f910309", "fb6dcd26-5263-45d9-8fd8-dec79443cb49" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31dcb0d3-4053-4fcc-b74c-7cd68e166947", "78a57554-0ff6-4451-8107-f34b232b6a92" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5f3eb3f3-5d5e-4869-ae4e-aa40afeac913", "8af7562f-de44-461f-b92e-a4f6945674c0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33ccbd7d-5a32-417f-9abc-3da2528f20ea", "a13e73ea-c429-4731-a77c-ef081bc999a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "30dd2a75-8f4d-4a39-a67a-f4807f910309", "fb6dcd26-5263-45d9-8fd8-dec79443cb49" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30dd2a75-8f4d-4a39-a67a-f4807f910309");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31dcb0d3-4053-4fcc-b74c-7cd68e166947");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33ccbd7d-5a32-417f-9abc-3da2528f20ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f3eb3f3-5d5e-4869-ae4e-aa40afeac913");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78a57554-0ff6-4451-8107-f34b232b6a92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8af7562f-de44-461f-b92e-a4f6945674c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a13e73ea-c429-4731-a77c-ef081bc999a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb6dcd26-5263-45d9-8fd8-dec79443cb49");

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
    }
}
