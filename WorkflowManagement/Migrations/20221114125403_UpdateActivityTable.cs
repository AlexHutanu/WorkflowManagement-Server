using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowManagement.Migrations
{
    /// <inheritdoc />
    public partial class UpdateActivityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Activity",
                type: "varchar(200)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Activity");
        }
    }
}
