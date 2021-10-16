using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Reflection.Metadata;
using TheTower.Models;

namespace TheTower.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Biome",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RollNumber = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biome", x => x.ID);
                });


            migrationBuilder.CreateTable(
                name: "CRRoll",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RollNumber = table.Column<int>(nullable: false),
                    MonsterQTY = table.Column<int>(nullable: false),
                    XP = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false),
                    MonsterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRRoll", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RollNumber = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemName = table.Column<string>(nullable: true),
                    ItemCost = table.Column<string>(nullable: true),
                    Vendor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Monster",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChallengeRating = table.Column<int>(nullable: false),
                    XP = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    RollNumber = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monster", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MonsterCR",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MonsterId = table.Column<int>(nullable: false),
                    CRRollId = table.Column<int>(nullable: false),
                    RollNo = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterCR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Char = table.Column<string>(nullable: true),
                    Init = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoomRoll",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DiceRoll = table.Column<int>(nullable: false),
                    RoomMove = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomRoll", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DMName = table.Column<string>(nullable: true),
                    PlayerLevel = table.Column<int>(nullable: false),
                    PlayerQty = table.Column<int>(nullable: false),
                    CurrentLevel = table.Column<int>(nullable: false),
                    XP = table.Column<int>(nullable: false),
                    SessionCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MonsterID = table.Column<int>(nullable: false),
                    RoomLevel = table.Column<int>(nullable: false),
                    BiomeID = table.Column<int>(nullable: false),
                    EventID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CRLevel = table.Column<int>(nullable: false),
                    SessionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Level_Session_SessionID",
                        column: x => x.SessionID,
                        principalTable: "Session",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Level_SessionID",
                table: "Level",
                column: "SessionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biome");

            migrationBuilder.DropTable(
                name: "CRRoll");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Level");

            migrationBuilder.DropTable(
                name: "Monster");

            migrationBuilder.DropTable(
                name: "MonsterCR");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "RoomRoll");

            migrationBuilder.DropTable(
                name: "Session");
        }
        /*
        protected void Seed(TowerContext context)
        {

            context.Database.EnsureCreated();

            context.Biome.Add(
                new Biome() { ID = 1, Name = "Moster Biome", RollNumber = 1, Description = "DM Chooses the closest Monster Biome" },
                new Biome() { ID = 2, Name = "Cave", RollNumber = 2, Description = "Mostly Empty Room, Lava Flowing From The Roof" },
                new Biome() { ID = 3, Name = "Empty Room", RollNumber = 3, Description = "As per the name, the room looks to be empty!" },
                new Biome() { ID = 4, Name = "Swamp", RollNumber = 4, Description = "Area's have clusters of trees" },
                new Biome() { ID = 5, Name = "Desert", RollNumber = 5, Description = "Sandy Scenery with pools of Quicksand" },
                new Biome() { ID = 6, Name = "Aquatic", RollNumber = 6, Description = "30ft of water fills the room, Pillars are at water level all around the room" },
                new Biome() { ID = 6, Name = "Underdark", RollNumber = 7, Description = "Darkness, Need darkvision to see" },
                new Biome() { ID = 6, Name = "Jungle", RollNumber = 8, Description = "Tree's and vines in clusters" },
                new Biome() { ID = 6, Name = "Urban", RollNumber = 9, Description = "Buildings about the place" },
                new Biome() { ID = 6, Name = "10x10", RollNumber = 10, Description = "Empty 10x10 room" },
                new Biome() { ID = 6, Name = "Arctic", RollNumber = 11, Description = "Snowy Environment with 15ft glaciers around the map " },
                new Biome() { ID = 6, Name = "Monster Biome", RollNumber = 12, Description = "DM Chooses the closest Monster Biome" },
                new Biome() { ID = 6, Name = "Rest Room", RollNumber = -1, Description = "Rest Room" },
                new Biome() { ID = 6, Name = "Loot Room", RollNumber = -2, Description = "Loot Room" }
                );


            context.SaveChanges();

        }
        */
    }
}
