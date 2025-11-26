using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement2.Migrations
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
                    { 1, "System", new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(4956), new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(4970), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(4973), new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(4973), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(5142), new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(5143), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(5145), new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(5146), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(5208), new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(5209), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(5210), new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(5211), "x5", "System" },
                    { 3, "System", new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(5213), new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(5214), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(5215), new DateTime(2025, 11, 26, 8, 42, 21, 181, DateTimeKind.Local).AddTicks(5216), "C-HR", "System" }
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
