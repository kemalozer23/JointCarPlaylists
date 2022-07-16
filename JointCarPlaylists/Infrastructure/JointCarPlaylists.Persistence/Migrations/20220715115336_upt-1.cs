using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JointCarPlaylists.Persistence.Migrations
{
    public partial class upt1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DurationMS",
                table: "Tracks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Explicit",
                table: "Tracks",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalURL",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Popularity",
                table: "Tracks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URI",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalUrl",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Followers",
                table: "Artists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Popularity",
                table: "Artists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URI",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlbumType",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalUrl",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationMS",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Explicit",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "ExternalURL",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Popularity",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "URI",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "ExternalUrl",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "Followers",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "Popularity",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "URI",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "AlbumType",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "ExternalUrl",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Albums");
        }
    }
}
