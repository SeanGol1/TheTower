using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTower.Migrations
{
    public partial class SeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Biome",
                columns: new[] { "ID", "Description", "Name", "RollNumber" },
                values: new object[,]
                {
                    { 12, "Arctic", "Arctic", 1 },
                    { 11, "DM Chooses", "DM Chooses", 12 },
                    { 10, "DM Chooses", "DM Chooses", 11 },
                    { 8, "Underwater", "Underdark", 9 },
                    { 7, "Swamp", "Swamp", 8 },
                    { 6, "Mountain", "Mountain", 7 },
                    { 9, "Urban", "Urban", 10 },
                    { 4, "Grassland", "Grassland", 5 },
                    { 3, "Forest", "Forest", 4 },
                    { 2, "Desert", "Desert", 3 },
                    { 1, "Coastal", "Coastal", 2 },
                    { 5, "Hill", "Hill", 6 }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "ID", "Description", "Name", "RollNumber" },
                values: new object[,]
                {
                    { 6, "Players shrink down one size", "Shrink", 7 },
                    { 8, "Players shrink down one size", "Shrink", 1 },
                    { 1, "Players grow one size up", "Grow", 2 },
                    { 2, "Players shrink down one size", "Event", 3 },
                    { 3, "Players shrink down one size", "Shrink", 4 },
                    { 4, "Players shrink down one size", "Shrink", 5 },
                    { 5, "Players shrink down one size", "Shrink", 6 },
                    { 7, "Players shrink down one size", "Shrink", 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Biome",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Biome",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Biome",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Biome",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Biome",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Biome",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Biome",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Biome",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Biome",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Biome",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Biome",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Biome",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 8);
        }
    }
}
