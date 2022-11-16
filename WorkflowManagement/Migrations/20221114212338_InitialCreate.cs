using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkflowManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Owner = table.Column<string>(type: "varchar(200)", nullable: true),
                    TimeCreated = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OwnerName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    NoOfTickets = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "BugTicket",
                columns: table => new
                {
                    stepstoreproduce = table.Column<string>(name: "steps_to_reproduce", type: "varchar(200)", nullable: false),
                    expectedresult = table.Column<string>(name: "expected_result", type: "varchar(200)", nullable: false),
                    actualresult = table.Column<string>(name: "actual_result", type: "varchar(200)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "varchar(200)", nullable: true),
                    asignee = table.Column<string>(type: "varchar(200)", nullable: true),
                    reporter = table.Column<string>(type: "varchar(200)", nullable: true),
                    description = table.Column<string>(type: "varchar(200)", nullable: true),
                    deadline = table.Column<string>(type: "varchar(200)", nullable: false),
                    status = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropTable(
                name: "BugTicket");
        }
    }
}
