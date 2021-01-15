using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieData",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Actors = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Runtime = table.Column<int>(nullable: false),
                    Rating = table.Column<float>(nullable: false),
                    Votes = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieData", x => x.Title);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieData");
        }
    }
}
