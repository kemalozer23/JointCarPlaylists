using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JointCarPlaylists.Persistence.Migrations
{
    public partial class tieeesttttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackId", "DurationMS", "Explicit", "ExternalURL", "Name", "Popularity", "TrackNumber", "Type", "URI" },
                values: new object[] { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), 500, false, "sedasds.com", "Kane Miller", 74, 4, "Underground", "losdfdf.com" });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackId", "DurationMS", "Explicit", "ExternalURL", "Name", "Popularity", "TrackNumber", "Type", "URI" },
                values: new object[] { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), 5000, true, "sedasdas.com", "Sam Raiden", 34, 2, "Underground", "losakdfdf.com" });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackId", "DurationMS", "Explicit", "ExternalURL", "Name", "Popularity", "TrackNumber", "Type", "URI" },
                values: new object[] { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), 4000, true, "sewresdas.com", "Jana McLeaf", 64, 3, "Underground", "lossdsdfdfdf.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"));
        }
    }
}
