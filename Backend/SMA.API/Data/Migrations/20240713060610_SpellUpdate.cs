using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMA.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class SpellUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PAsswordSalt",
                table: "Users",
                newName: "PasswordSalt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordSalt",
                table: "Users",
                newName: "PAsswordSalt");
        }
    }
}
