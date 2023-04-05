using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barclays.Migrations
{
    /// <inheritdoc />
    public partial class TaskTableUniqueName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Task_Name",
                schema: "App",
                table: "Task",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Task_Name",
                schema: "App",
                table: "Task");
        }
    }
}
