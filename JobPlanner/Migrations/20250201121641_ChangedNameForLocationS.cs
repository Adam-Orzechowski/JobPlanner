using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPlanner.Migrations
{
    /// <inheritdoc />
    public partial class ChangedNameForLocationS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserLocation_Location_LocationsId",
                table: "ApplicationUserLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22d1a66c-ccd8-4c1e-8763-a896c287ea2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07df1a68-d0b0-4b38-b155-ff68ce8b2882", "AQAAAAIAAYagAAAAEIwQ/LKVVWi5p43MgDSHPTeRnocGfXAqdsGIHaihNHgREKiihUINybp+uO9wEY9T7Q==", "dc058efe-9f5c-45cc-a746-a30a33cf031c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfe1a10b-5d53-4080-a2a3-156782522593",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20bad8b5-a9c4-456d-aae4-3638f194583b", "AQAAAAIAAYagAAAAEIw99GdZbOJwttdn3iLFZP/RB2PrWn9Xtup8PQu34/3gFRGTSFl7eD3s+mXR+GeTLA==", "85715ebd-8e80-4243-9411-49203b566fa1" });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserLocation_Locations_LocationsId",
                table: "ApplicationUserLocation",
                column: "LocationsId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserLocation_Locations_LocationsId",
                table: "ApplicationUserLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22d1a66c-ccd8-4c1e-8763-a896c287ea2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c22fcb32-3a24-4f4b-8623-74e200bf6f5e", "AQAAAAIAAYagAAAAEP7LlLJkBCKRG8cFMmy1WHkq8EVhIDgt7685b45Kr5qyz/+S2I0xzK0Fkqo74nXLRg==", "7ba326bd-e754-4bb5-b041-26d2407e6e28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfe1a10b-5d53-4080-a2a3-156782522593",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb718e21-1086-4bb9-9a48-2d61f11d9d0e", "AQAAAAIAAYagAAAAEAZ+FUVUEUENZWE66ceD5icbAJQJgrG+ARAAzkBd21EJN6PhUGGQK0XFsvAd5j6sSw==", "b2616ecb-684a-46a9-8082-f67e64c6ba38" });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserLocation_Location_LocationsId",
                table: "ApplicationUserLocation",
                column: "LocationsId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
