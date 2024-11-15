using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymBookingSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumnInAspNetUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "age",
                table: "AspNetUsers",
                newName: "Age");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "AspNetUsers",
                newName: "age");
        }
    }
}
