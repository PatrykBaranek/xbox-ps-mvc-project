using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xbox_ps_mvc_project.Migrations
{
    public partial class Db3Version : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Genres_GenresEntity_GenreId",
                table: "Games_Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GenresEntity",
                table: "GenresEntity");

            migrationBuilder.RenameTable(
                name: "GenresEntity",
                newName: "Genres");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Genres_Genres_GenreId",
                table: "Games_Genres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Genres_Genres_GenreId",
                table: "Games_Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "GenresEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenresEntity",
                table: "GenresEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Genres_GenresEntity_GenreId",
                table: "Games_Genres",
                column: "GenreId",
                principalTable: "GenresEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
