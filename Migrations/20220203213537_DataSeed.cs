using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xbox_ps_mvc_project.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CoverImgUrl", "Description", "PosterUrl", "Title" },
                values: new object[] { 1, "https://wallpapercrafter.com/desktop/29964-Dying-Light-2-E3-2018-poster-4K.jpg", "Zombie Game", "https://image.api.playstation.com/vulcan/img/rnd/202106/2908/7aJhOMuJALdBPqZHVy3CgJsg.png", "Dying Light 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
