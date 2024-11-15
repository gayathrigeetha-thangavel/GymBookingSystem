using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymBookingSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDurationToGymClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "GymClasses",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "GymClasses");

            
        }
    }
}
