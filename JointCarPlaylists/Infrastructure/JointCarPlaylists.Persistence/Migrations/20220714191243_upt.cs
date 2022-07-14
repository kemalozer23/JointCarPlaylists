using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JointCarPlaylists.Persistence.Migrations
{
    public partial class upt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artists_Albums_AlbumId",
                table: "Artists");

            migrationBuilder.DropIndex(
                name: "IX_Artists_AlbumId",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Artists");

            migrationBuilder.AddColumn<Guid>(
                name: "ArtistId",
                table: "Albums",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistId",
                table: "Albums",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistId",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Albums");

            migrationBuilder.AddColumn<Guid>(
                name: "AlbumId",
                table: "Artists",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artists_AlbumId",
                table: "Artists",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artists_Albums_AlbumId",
                table: "Artists",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "AlbumId");
        }
    }
}
