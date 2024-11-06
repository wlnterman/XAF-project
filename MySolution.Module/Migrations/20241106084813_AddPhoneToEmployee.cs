using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySolution.Module.Migrations
{
    /// <inheritdoc />
    public partial class AddPhoneToEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_EmployeeID",
                table: "PhoneNumber",
                column: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneNumber");
        }
    }
}
