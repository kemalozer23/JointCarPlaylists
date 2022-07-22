using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JointCarPlaylists.Persistence.Migrations
{
    public partial class tieeestttoooo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistId1",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_ArtistId1",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "ArtistId1",
                table: "Albums");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Albums",
                newName: "ArtistForeignKey");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                newName: "IX_Albums_ArtistForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistForeignKey",
                table: "Albums",
                column: "ArtistForeignKey",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistForeignKey",
                table: "Albums");

            migrationBuilder.RenameColumn(
                name: "ArtistForeignKey",
                table: "Albums",
                newName: "ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_ArtistForeignKey",
                table: "Albums",
                newName: "IX_Albums_ArtistId");

            migrationBuilder.AddColumn<Guid>(
                name: "ArtistId1",
                table: "Albums",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId1",
                table: "Albums",
                column: "ArtistId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistId",
                table: "Albums",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistId1",
                table: "Albums",
                column: "ArtistId1",
                principalTable: "Artists",
                principalColumn: "ArtistId");
        }
    }
}
