using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDB.Migrations
{
    /// <inheritdoc />
    public partial class FixedServiceInBank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_service_in_bank_clients_client_person_id",
                table: "service_in_bank");

            migrationBuilder.DropIndex(
                name: "ix_service_in_bank_client_person_id",
                table: "service_in_bank");

            migrationBuilder.DropColumn(
                name: "client_person_id",
                table: "service_in_bank");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "client_person_id",
                table: "service_in_bank",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_service_in_bank_client_person_id",
                table: "service_in_bank",
                column: "client_person_id");

            migrationBuilder.AddForeignKey(
                name: "fk_service_in_bank_clients_client_person_id",
                table: "service_in_bank",
                column: "client_person_id",
                principalTable: "clients",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
