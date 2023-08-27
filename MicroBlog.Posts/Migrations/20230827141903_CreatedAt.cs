using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MicroBlog.Posts.Migrations
{
    /// <inheritdoc />
    public partial class CreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Posts",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Categories",
                newName: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Posts",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Categories",
                newName: "CreatedDate");
        }
    }
}
