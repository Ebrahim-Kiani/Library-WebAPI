using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_practice.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDate",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedDate",
                value: new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedDate",
                value: new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedDate",
                value: new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedDate",
                value: new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedDate",
                value: new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedDate",
                value: new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedDate",
                value: new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDate",
                value: new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedDate",
                value: new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedDate",
                value: new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedDate",
                value: new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedDate",
                value: new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedDate",
                value: new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedDate",
                value: new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedDate",
                value: new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5913));
        }
    }
}
