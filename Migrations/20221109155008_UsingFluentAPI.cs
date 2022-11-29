using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDB.Migrations
{
    public partial class UsingFluentAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Client",
                newName: "client_id");

            migrationBuilder.AddColumn<string>(
                name: "BankAddress",
                table: "Bank",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "integer", nullable: false),
                    EmployeeName = table.Column<string>(type: "text", nullable: false),
                    EmployeePhone = table.Column<string>(type: "text", nullable: false),
                    EmployeeEmail = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropColumn(
                name: "BankAddress",
                table: "Bank");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "Client",
                newName: "ClientId");
        }
    }
}
