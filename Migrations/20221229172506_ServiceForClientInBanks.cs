using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDB.Migrations
{
    /// <inheritdoc />
    public partial class ServiceForClientInBanks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_service_for_client_in_bank_clients_client_id",
                table: "service_for_client_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_service_for_client_in_bank_service_in_bank_service_in_bank_",
                table: "service_for_client_in_bank");

            migrationBuilder.DropPrimaryKey(
                name: "pk_service_for_client_in_bank",
                table: "service_for_client_in_bank");

            migrationBuilder.RenameTable(
                name: "service_for_client_in_bank",
                newName: "service_for_client_in_banks");

            migrationBuilder.RenameIndex(
                name: "ix_service_for_client_in_bank_service_in_bank_id",
                table: "service_for_client_in_banks",
                newName: "ix_service_for_client_in_banks_service_in_bank_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_service_for_client_in_banks",
                table: "service_for_client_in_banks",
                columns: new[] { "client_id", "service_in_bank_id" });

            migrationBuilder.AddForeignKey(
                name: "fk_service_for_client_in_banks_clients_client_id",
                table: "service_for_client_in_banks",
                column: "client_id",
                principalTable: "clients",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_service_for_client_in_banks_service_in_bank_service_in_bank",
                table: "service_for_client_in_banks",
                column: "service_in_bank_id",
                principalTable: "service_in_bank",
                principalColumn: "service_in_bank_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_service_for_client_in_banks_clients_client_id",
                table: "service_for_client_in_banks");

            migrationBuilder.DropForeignKey(
                name: "fk_service_for_client_in_banks_service_in_bank_service_in_bank",
                table: "service_for_client_in_banks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_service_for_client_in_banks",
                table: "service_for_client_in_banks");

            migrationBuilder.RenameTable(
                name: "service_for_client_in_banks",
                newName: "service_for_client_in_bank");

            migrationBuilder.RenameIndex(
                name: "ix_service_for_client_in_banks_service_in_bank_id",
                table: "service_for_client_in_bank",
                newName: "ix_service_for_client_in_bank_service_in_bank_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_service_for_client_in_bank",
                table: "service_for_client_in_bank",
                columns: new[] { "client_id", "service_in_bank_id" });

            migrationBuilder.AddForeignKey(
                name: "fk_service_for_client_in_bank_clients_client_id",
                table: "service_for_client_in_bank",
                column: "client_id",
                principalTable: "clients",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_service_for_client_in_bank_service_in_bank_service_in_bank_",
                table: "service_for_client_in_bank",
                column: "service_in_bank_id",
                principalTable: "service_in_bank",
                principalColumn: "service_in_bank_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
