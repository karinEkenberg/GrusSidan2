using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrusSidan.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoriesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO Categories (Name, ImageUrl)
                VALUES ('Sand', '~/images/sten-kopiera.jpg'),
                       ('Sten', '~/images/sten-kopiera.jpg'),
                       ('Grus', '~/images/sten-kopiera.jpg');
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
