using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDB.Migrations
{
    /// <inheritdoc />
    public partial class SnakeConventionsFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_account_in_bank_clients_client_person_id",
                table: "account_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_employees_bank_branch_bank_branch_id",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "fk_employees_occupation_occupation_id",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "fk_service_for_client_in_bank_clients_client_id",
                table: "service_for_client_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_service_in_bank_clients_client_person_id",
                table: "service_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_service_in_bank_employees_employee_person_id",
                table: "service_in_bank");

            migrationBuilder.DropPrimaryKey(
                name: "pk_employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "pk_clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "employee");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "client");

            migrationBuilder.RenameIndex(
                name: "ix_employees_occupation_id",
                table: "employee",
                newName: "ix_employee_occupation_id");

            migrationBuilder.RenameIndex(
                name: "ix_employees_bank_branch_id",
                table: "employee",
                newName: "ix_employee_bank_branch_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_employee",
                table: "employee",
                column: "person_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_client",
                table: "client",
                column: "person_id");

            migrationBuilder.AddForeignKey(
                name: "fk_account_in_bank_client_client_person_id",
                table: "account_in_bank",
                column: "client_person_id",
                principalTable: "client",
                principalColumn: "person_id");

            migrationBuilder.AddForeignKey(
                name: "fk_employee_bank_branch_bank_branch_id",
                table: "employee",
                column: "bank_branch_id",
                principalTable: "bank_branch",
                principalColumn: "bank_branch_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_employee_occupation_occupation_id",
                table: "employee",
                column: "occupation_id",
                principalTable: "occupation",
                principalColumn: "occupation_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_service_for_client_in_bank_client_client_id",
                table: "service_for_client_in_bank",
                column: "client_id",
                principalTable: "client",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_service_in_bank_client_client_person_id",
                table: "service_in_bank",
                column: "client_person_id",
                principalTable: "client",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_service_in_bank_employee_employee_person_id",
                table: "service_in_bank",
                column: "employee_person_id",
                principalTable: "employee",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_account_in_bank_client_client_person_id",
                table: "account_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_employee_bank_branch_bank_branch_id",
                table: "employee");

            migrationBuilder.DropForeignKey(
                name: "fk_employee_occupation_occupation_id",
                table: "employee");

            migrationBuilder.DropForeignKey(
                name: "fk_service_for_client_in_bank_client_client_id",
                table: "service_for_client_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_service_in_bank_client_client_person_id",
                table: "service_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_service_in_bank_employee_employee_person_id",
                table: "service_in_bank");

            migrationBuilder.DropPrimaryKey(
                name: "pk_employee",
                table: "employee");

            migrationBuilder.DropPrimaryKey(
                name: "pk_client",
                table: "client");

            migrationBuilder.RenameTable(
                name: "employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "client",
                newName: "Clients");

            migrationBuilder.RenameIndex(
                name: "ix_employee_occupation_id",
                table: "Employees",
                newName: "ix_employees_occupation_id");

            migrationBuilder.RenameIndex(
                name: "ix_employee_bank_branch_id",
                table: "Employees",
                newName: "ix_employees_bank_branch_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_employees",
                table: "Employees",
                column: "person_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_clients",
                table: "Clients",
                column: "person_id");

            migrationBuilder.AddForeignKey(
                name: "fk_account_in_bank_clients_client_person_id",
                table: "account_in_bank",
                column: "client_person_id",
                principalTable: "Clients",
                principalColumn: "person_id");

            migrationBuilder.AddForeignKey(
                name: "fk_employees_bank_branch_bank_branch_id",
                table: "Employees",
                column: "bank_branch_id",
                principalTable: "bank_branch",
                principalColumn: "bank_branch_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_employees_occupation_occupation_id",
                table: "Employees",
                column: "occupation_id",
                principalTable: "occupation",
                principalColumn: "occupation_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_service_for_client_in_bank_clients_client_id",
                table: "service_for_client_in_bank",
                column: "client_id",
                principalTable: "Clients",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_service_in_bank_clients_client_person_id",
                table: "service_in_bank",
                column: "client_person_id",
                principalTable: "Clients",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_service_in_bank_employees_employee_person_id",
                table: "service_in_bank",
                column: "employee_person_id",
                principalTable: "Employees",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
