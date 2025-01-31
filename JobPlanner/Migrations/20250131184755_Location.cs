using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPlanner.Migrations
{
    /// <inheritdoc />
    public partial class Location : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Image = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22d1a66c-ccd8-4c1e-8763-a896c287ea2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7dfd792-2ff4-46ba-90ee-5ce2989ff207", "AQAAAAIAAYagAAAAEIkd4TMlXnQz4XGnYvjc6VXHLevpjupAgHZYUl/eQlnQbWyTEkk5zSgIEZq+Z+xRwA==", "9a1d3bcf-7a87-4cbc-ac59-f85159782e21" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22d1a66c-ccd8-4c1e-8763-a896c287ea2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b464f95a-dc40-4503-8be3-f5b104bedb64", "AQAAAAIAAYagAAAAENojqB2b9/fsN0xmr/5kcTdlwk0JjLePz/UiI9eArhYUSJ083OYcGR5SeC6Z/3Iclg==", "4480b7eb-9046-40a2-91b6-d752ab1f2b19" });
        }
    }
}
