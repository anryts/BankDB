using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDB.Migrations
{
    public partial class ChangeClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClientName",
                table: "Client",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Client",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Client",
                newName: "ClientName");
        }
    }
}
