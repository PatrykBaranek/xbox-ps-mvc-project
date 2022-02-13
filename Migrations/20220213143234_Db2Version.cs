using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xbox_ps_mvc_project.Migrations
{
    public partial class Db2Version : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Games");

            migrationBuilder.CreateTable(
                name: "GenresEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenresEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games_Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games_Genres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Genres_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Genres_GenresEntity_GenreId",
                        column: x => x.GenreId,
                        principalTable: "GenresEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GenresEntity",
                columns: new[] { "Id", "GenreName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "GenresEntity",
                columns: new[] { "Id", "GenreName" },
                values: new object[] { 2, "Action role-playing" });

            migrationBuilder.InsertData(
                table: "GenresEntity",
                columns: new[] { "Id", "GenreName" },
                values: new object[] { 3, "Casual game" });

            migrationBuilder.InsertData(
                table: "Games_Genres",
                columns: new[] { "Id", "GameId", "GenreId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Games_Genres",
                columns: new[] { "Id", "GameId", "GenreId" },
                values: new object[] { 2, 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Games_Genres_GameId",
                table: "Games_Genres",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Genres_GenreId",
                table: "Games_Genres",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games_Genres");

            migrationBuilder.DropTable(
                name: "GenresEntity");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
