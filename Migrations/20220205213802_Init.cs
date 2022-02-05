using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xbox_ps_mvc_project.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PosterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlatformId = table.Column<int>(type: "int", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "PlatformName" },
                values: new object[,]
                {
                    { 1, "PS5" },
                    { 2, "PS4" },
                    { 3, "XBOX SERIES X" },
                    { 4, "XBOX SERIES S" },
                    { 5, "XBOX ONE S" },
                    { 6, "XBOX ONE X" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Category", "CoverImgUrl", "Description", "PlatformId", "PosterUrl", "Title" },
                values: new object[] { 1, "Action Game", "https://wallpapercrafter.com/desktop/29964-Dying-Light-2-E3-2018-poster-4K.jpg", "Action Game", 1, "https://image.api.playstation.com/vulcan/img/rnd/202106/2908/7aJhOMuJALdBPqZHVy3CgJsg.png", "Dying Light 2" });

            migrationBuilder.CreateIndex(
                name: "IX_Games_PlatformId",
                table: "Games",
                column: "PlatformId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Platforms");
        }
    }
}
