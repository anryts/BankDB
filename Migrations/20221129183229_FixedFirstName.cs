using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDB.Migrations
{
    /// <inheritdoc />
    public partial class FixedFirstName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "firs_name",
                table: "employee",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "firs_name",
                table: "client",
                newName: "first_name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "employee",
                newName: "firs_name");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "client",
                newName: "firs_name");
        }
    }
}
