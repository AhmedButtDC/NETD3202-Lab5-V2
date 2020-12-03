using Microsoft.EntityFrameworkCore.Migrations;

namespace NETD3202_Lab5_V2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoGames",
                columns: table => new
                {
                    gameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gameName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    releaseYear = table.Column<int>(type: "int", nullable: false),
                    esrb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGames", x => x.gameID);
                });

            migrationBuilder.CreateTable(
                name: "MoreDetails",
                columns: table => new
                {
                    gID = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoreDetails", x => x.gID);
                    table.ForeignKey(
                        name: "FK_MoreDetails_VideoGames_gID",
                        column: x => x.gID,
                        principalTable: "VideoGames",
                        principalColumn: "gameID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoreDetails");

            migrationBuilder.DropTable(
                name: "VideoGames");
        }
    }
}
