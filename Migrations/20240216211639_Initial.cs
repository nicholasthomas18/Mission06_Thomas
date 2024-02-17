using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie_Collection.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilmCategory = table.Column<string>(type: "TEXT", nullable: false),
                    FilmTitle = table.Column<string>(type: "TEXT", nullable: false),
                    FilmYear = table.Column<int>(type: "INTEGER", nullable: false),
                    FilmDirector = table.Column<string>(type: "TEXT", nullable: false),
                    FilmRating = table.Column<string>(type: "TEXT", nullable: false),
                    FilmEdited = table.Column<bool>(type: "INTEGER", nullable: true),
                    FilmLentTo = table.Column<string>(type: "TEXT", nullable: true),
                    FilmNotes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
