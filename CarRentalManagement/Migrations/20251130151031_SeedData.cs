using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6104), new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6114), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6115), new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6116), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6279), new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6280), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6281), new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6281), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6329), new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6329), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6331), new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6331), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6332), new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6332), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6334), new DateTime(2025, 11, 30, 23, 10, 31, 127, DateTimeKind.Local).AddTicks(6334), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
