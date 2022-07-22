using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JointCarPlaylists.Persistence.Migrations
{
    public partial class tieeeesttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumType", "ExternalUrl", "Name", "ReleaseDate", "TotalTracks", "Type" },
                values: new object[] { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Hip-Hop", "asds444adasd.com", "Admin_Solutions Ltd", "2005", 4, "Underground" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumType", "ExternalUrl", "Name", "ReleaseDate", "TotalTracks", "Type" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Hip-Hop", "asdsadasd.com", "IT_Solutions Ltd", "1999", 0, "Underground" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
