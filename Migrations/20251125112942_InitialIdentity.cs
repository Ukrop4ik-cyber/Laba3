using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class InitialIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 11, 29, 40, 13, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 11, 29, 40, 13, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 11, 29, 40, 13, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 11, 29, 40, 13, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 11, 29, 40, 13, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 11, 29, 40, 13, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 25, 11, 29, 40, 13, DateTimeKind.Utc).AddTicks(7006), new DateTime(2025, 11, 25, 11, 29, 40, 13, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 25, 11, 29, 40, 13, DateTimeKind.Utc).AddTicks(7015), new DateTime(2025, 11, 25, 11, 29, 40, 13, DateTimeKind.Utc).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 25, 11, 29, 40, 13, DateTimeKind.Utc).AddTicks(7019), new DateTime(2025, 11, 25, 11, 29, 40, 13, DateTimeKind.Utc).AddTicks(7019) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 11, 29, 5, 529, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 11, 29, 5, 529, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 11, 29, 5, 529, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 11, 29, 5, 529, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 11, 29, 5, 529, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 11, 29, 5, 529, DateTimeKind.Utc).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 19, 11, 29, 5, 529, DateTimeKind.Utc).AddTicks(7118), new DateTime(2025, 11, 19, 11, 29, 5, 529, DateTimeKind.Utc).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 19, 11, 29, 5, 529, DateTimeKind.Utc).AddTicks(7126), new DateTime(2025, 11, 19, 11, 29, 5, 529, DateTimeKind.Utc).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 19, 11, 29, 5, 529, DateTimeKind.Utc).AddTicks(7128), new DateTime(2025, 11, 19, 11, 29, 5, 529, DateTimeKind.Utc).AddTicks(7128) });
        }
    }
}
