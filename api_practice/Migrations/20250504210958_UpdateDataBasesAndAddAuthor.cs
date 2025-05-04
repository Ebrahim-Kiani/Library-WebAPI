using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_practice.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataBasesAndAddAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PointsOfInterest");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Bio = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Nationality = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false),
                    ISBN = table.Column<string>(type: "TEXT", maxLength: 13, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Bio", "DateOfBirth", "FullName", "Nationality" },
                values: new object[,]
                {
                    { 1, null, null, "F. Scott Fitzgerald", null },
                    { 2, null, null, "Harper Lee", null },
                    { 3, null, null, "Stephen Hawking", null },
                    { 4, null, null, "Carl Sagan", null },
                    { 5, null, null, "Yuval Noah Harari", null },
                    { 6, null, null, "Jared Diamond", null },
                    { 7, null, null, "J.K. Rowling", null },
                    { 8, null, null, "E.B. White", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fiction" },
                    { 2, "Science" },
                    { 3, "History" },
                    { 4, "Children" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "ISBN", "Price", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "A novel about the American dream set in the 1920s.", "9780743273565", 12.99m, new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5760), "The Great Gatsby" },
                    { 2, 2, 1, "A powerful story on racism and justice.", "9780060935467", 10.50m, new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5905), "To Kill a Mockingbird" },
                    { 3, 3, 2, "A landmark volume in scientific writing.", "9780553380163", 18.00m, new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5906), "A Brief History of Time" },
                    { 4, 4, 2, "Exploration of space and time.", "9780345539434", 20.00m, new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5907), "Cosmos" },
                    { 5, 5, 3, "A global history of humankind.", "9780062316110", 16.75m, new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5909), "Sapiens: A Brief History of Humankind" },
                    { 6, 6, 3, "How civilizations developed differently across continents.", "9780393317558", 17.50m, new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5911), "Guns, Germs, and Steel" },
                    { 7, 7, 4, "The magical beginning of the Harry Potter series.", "9780590353427", 9.99m, new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5912), "Harry Potter and the Sorcerer’s Stone" },
                    { 8, 8, 4, "A story of friendship between a pig and a spider.", "9780061124952", 7.99m, new DateTime(2025, 5, 4, 21, 9, 57, 438, DateTimeKind.Utc).AddTicks(5913), "Charlotte’s Web" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PointsOfInterest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityId = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointsOfInterest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PointsOfInterest_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "The capital of Iran", "Tehran" },
                    { 2, "City of poets", "Shiraz" },
                    { 3, "Historic city in northwest Iran", "Tabriz" },
                    { 4, "is the best city of iran", "Esfahan" }
                });

            migrationBuilder.InsertData(
                table: "PointsOfInterest",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 4, "The best bridge of Iran", "33 pol" },
                    { 2, 4, "the biggest squar in isfahan", "imam squar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PointsOfInterest_CityId",
                table: "PointsOfInterest",
                column: "CityId");
        }
    }
}
