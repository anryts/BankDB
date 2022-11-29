using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDB.Migrations
{
    public partial class AddCheckAndDefaultValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Citizenship",
                table: "Client",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "Ukraine");

            migrationBuilder.AddUniqueConstraint(
                name: "ClientEmail",
                table: "Client",
                column: "EmailAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "ClientEmail",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Citizenship",
                table: "Client");
        }
    }
}
