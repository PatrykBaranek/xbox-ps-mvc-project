using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xbox_ps_mvc_project.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games_Platforms",
                columns: new[] { "Id", "GameId", "PlatformId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Games_Platforms",
                columns: new[] { "Id", "GameId", "PlatformId" },
                values: new object[] { 2, 1, 2 });

            migrationBuilder.InsertData(
                table: "Games_Platforms",
                columns: new[] { "Id", "GameId", "PlatformId" },
                values: new object[] { 3, 1, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games_Platforms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games_Platforms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games_Platforms",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
