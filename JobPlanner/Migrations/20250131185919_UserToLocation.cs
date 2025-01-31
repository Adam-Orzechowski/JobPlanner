using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPlanner.Migrations
{
    /// <inheritdoc />
    public partial class UserToLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUserLocation",
                columns: table => new
                {
                    LocationsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UsersId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserLocation", x => new { x.LocationsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserLocation_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserLocation_Location_LocationsId",
                        column: x => x.LocationsId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22d1a66c-ccd8-4c1e-8763-a896c287ea2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed8422eb-c86d-450b-aec4-18a9698a0747", "AQAAAAIAAYagAAAAEEb+SpYOga6Foz0WtoFZuX8Cr2Kk5+kogO/kFoW5kSqr3lPY6bIDxbiIVv7pstDc8w==", "d6755e72-eee6-4a44-a6bf-4d8e3bc6d2e4" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserLocation_UsersId",
                table: "ApplicationUserLocation",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserLocation");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22d1a66c-ccd8-4c1e-8763-a896c287ea2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7dfd792-2ff4-46ba-90ee-5ce2989ff207", "AQAAAAIAAYagAAAAEIkd4TMlXnQz4XGnYvjc6VXHLevpjupAgHZYUl/eQlnQbWyTEkk5zSgIEZq+Z+xRwA==", "9a1d3bcf-7a87-4cbc-ac59-f85159782e21" });
        }
    }
}
