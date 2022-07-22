using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JointCarPlaylists.Persistence.Migrations
{
    public partial class tieeeestt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "ExternalUrl", "Followers", "Name", "Popularity", "Type", "URI" },
                values: new object[] { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "ted.com", 1232312, "Kendrick", 9, "Hip-Hop", "dsasdasdasd.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));
        }
    }
}
