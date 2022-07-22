using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JointCarPlaylists.Persistence.Migrations
{
    public partial class testtttssoooo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistId",
                table: "Albums",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistId",
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
    }
}
