using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymBookingSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateApplicationUserIdType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the foreign key constraint dependent on ApplicationUserId1
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGymClasses_AspNetUsers_ApplicationUserId1",
                table: "ApplicationUserGymClasses");

            // Drop the index dependent on ApplicationUserId1
            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserGymClasses_ApplicationUserId1",
                table: "ApplicationUserGymClasses");

            // Drop the unnecessary column ApplicationUserId1
            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "ApplicationUserGymClasses");

            // Remove the primary key constraint on ApplicationUserId and GymClassId
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserGymClasses",
                table: "ApplicationUserGymClasses");

            // Alter the ApplicationUserId column to change its type
            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "ApplicationUserGymClasses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            // Re-add the primary key constraint with the new data type for ApplicationUserId
            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserGymClasses",
                table: "ApplicationUserGymClasses",
                columns: new[] { "ApplicationUserId", "GymClassId" });

            // Re-add the correct foreign key constraint for ApplicationUserId
            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGymClasses_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserGymClasses",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove the foreign key constraint
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGymClasses_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserGymClasses");

            // Remove the primary key
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserGymClasses",
                table: "ApplicationUserGymClasses");

            // Revert the column type change
            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "ApplicationUserGymClasses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            // Re-add the primary key
            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserGymClasses",
                table: "ApplicationUserGymClasses",
                columns: new[] { "ApplicationUserId", "GymClassId" });

            // Re-add the 'ApplicationUserId1' column in case of rollback
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "ApplicationUserGymClasses",
                type: "nvarchar(450)",
                nullable: true);

            // Re-create the index for ApplicationUserId1
            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserGymClasses_ApplicationUserId1",
                table: "ApplicationUserGymClasses",
                column: "ApplicationUserId1");

            // Re-establish the old foreign key relationship
            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGymClasses_AspNetUsers_ApplicationUserId1",
                table: "ApplicationUserGymClasses",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

    }
}
