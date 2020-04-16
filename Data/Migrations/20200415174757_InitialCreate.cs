using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieAPI.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovID = table.Column<string>(nullable: false),
                    MovTitle = table.Column<string>(nullable: true),
                    ReleaseYear = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovID);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    DirID = table.Column<string>(nullable: false),
                    DirName = table.Column<string>(nullable: true),
                    MovieMovID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.DirID);
                    table.ForeignKey(
                        name: "FK_Directors_Movies_MovieMovID",
                        column: x => x.MovieMovID,
                        principalTable: "Movies",
                        principalColumn: "MovID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreID = table.Column<string>(nullable: false),
                    GenreType = table.Column<string>(nullable: true),
                    MovieMovID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreID);
                    table.ForeignKey(
                        name: "FK_Genres_Movies_MovieMovID",
                        column: x => x.MovieMovID,
                        principalTable: "Movies",
                        principalColumn: "MovID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Directors_MovieMovID",
                table: "Directors",
                column: "MovieMovID");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_MovieMovID",
                table: "Genres",
                column: "MovieMovID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
