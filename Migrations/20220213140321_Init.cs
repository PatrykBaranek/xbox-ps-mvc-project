using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xbox_ps_mvc_project.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games_Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games_Platforms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Platforms_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Platforms_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Category", "CoverImgUrl", "Description", "PosterUrl", "Title" },
                values: new object[] { 1, null, "https://wallpapercrafter.com/desktop/29964-Dying-Light-2-E3-2018-poster-4K.jpg", "Action Game", "https://image.api.playstation.com/vulcan/img/rnd/202106/2908/7aJhOMuJALdBPqZHVy3CgJsg.png", "Dying Light 2" });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "PlatformName" },
                values: new object[,]
                {
                    { 1, "PC" },
                    { 2, "PS5" },
                    { 3, "PS4" },
                    { 4, "XBOX_SERIES_X" },
                    { 5, "XBOX_SERIES_S" },
                    { 6, "XBOX_ONE_X" },
                    { 7, "XBOX_ONE_S" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_Platforms_GameId",
                table: "Games_Platforms",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Platforms_PlatformId",
                table: "Games_Platforms",
                column: "PlatformId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games_Platforms");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Platforms");
        }
    }
}
