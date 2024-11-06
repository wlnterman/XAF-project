using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySolution.Module.Migrations
{
    /// <inheritdoc />
    public partial class AdressRefProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AddressID",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AddressID",
                table: "Employees",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Address_AddressID",
                table: "Employees",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Address_AddressID",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Employees_AddressID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "Employees");
        }
    }
}
