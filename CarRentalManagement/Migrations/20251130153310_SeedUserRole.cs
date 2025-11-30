using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "e6d28e23-edc1-47a5-92b6-76d71ed4a9e8", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOsARrDS9yGMvDznHZprGR/srtH45ukQ+oclKLZDHYyXeEG/IRm/WOuc8Nrrdl6cxQ==", null, false, "5ea15144-2d5c-436f-ad8b-f8a3c36459d9", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(7968), new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(7981), new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(8138), new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(8140), new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(8198), new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(8200), new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(8202), new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(8203), new DateTime(2025, 11, 30, 23, 33, 10, 91, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(7974), new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(7985), new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(8122), new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(8124), new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(8180), new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(8182), new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(8183), new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(8185), new DateTime(2025, 11, 30, 23, 24, 49, 951, DateTimeKind.Local).AddTicks(8185) });
        }
    }
}
