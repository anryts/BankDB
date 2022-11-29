using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BankDB.Migrations
{
    /// <inheritdoc />
    public partial class SnakeNamingConvention : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountInBank_Clients_ClientPersonId",
                table: "AccountInBank");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Occupation_OccupationId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceForClientInBank_Clients_ClientId",
                table: "ServiceForClientInBank");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceForClientInBank_ServiceInBank_ServiceInBankId",
                table: "ServiceForClientInBank");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInBank_Clients_ClientPersonId",
                table: "ServiceInBank");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInBank_Employees_EmployeePersonId",
                table: "ServiceInBank");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_AccountInBank_AccountInBankAccountId",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_AccountInBankAccountId",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Occupation",
                table: "Occupation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bank",
                table: "Bank");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceInBank",
                table: "ServiceInBank");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceForClientInBank",
                table: "ServiceForClientInBank");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountInBank",
                table: "AccountInBank");

            migrationBuilder.DropColumn(
                name: "AccountInBankAccountId",
                table: "Transaction");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "transaction");

            migrationBuilder.RenameTable(
                name: "Occupation",
                newName: "occupation");

            migrationBuilder.RenameTable(
                name: "Bank",
                newName: "bank");

            migrationBuilder.RenameTable(
                name: "WorkingDay",
                newName: "working_day");

            migrationBuilder.RenameTable(
                name: "ServiceInBank",
                newName: "service_in_bank");

            migrationBuilder.RenameTable(
                name: "ServiceForClientInBank",
                newName: "service_for_client_in_bank");

            migrationBuilder.RenameTable(
                name: "AccountInBank",
                newName: "account_in_bank");

            migrationBuilder.RenameColumn(
                name: "TransactionName",
                table: "transaction",
                newName: "transaction_name");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "transaction",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "transaction",
                newName: "account_id");

            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "transaction",
                newName: "transaction_id");

            migrationBuilder.RenameColumn(
                name: "OccupationName",
                table: "occupation",
                newName: "occupation_name");

            migrationBuilder.RenameColumn(
                name: "OccupationId",
                table: "occupation",
                newName: "occupation_id");

            migrationBuilder.RenameColumn(
                name: "OccupationId",
                table: "Employees",
                newName: "occupation_id");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Employees",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirsName",
                table: "Employees",
                newName: "firs_name");

            migrationBuilder.RenameColumn(
                name: "EmployeePhone",
                table: "Employees",
                newName: "employee_phone");

            migrationBuilder.RenameColumn(
                name: "EmailAddres",
                table: "Employees",
                newName: "email_addres");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_OccupationId",
                table: "Employees",
                newName: "ix_employees_occupation_id");

            migrationBuilder.RenameColumn(
                name: "Citizenship",
                table: "Clients",
                newName: "citizenship");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Clients",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirsName",
                table: "Clients",
                newName: "firs_name");

            migrationBuilder.RenameColumn(
                name: "EmailAddres",
                table: "Clients",
                newName: "email_addres");

            migrationBuilder.RenameColumn(
                name: "BankName",
                table: "bank",
                newName: "bank_name");

            migrationBuilder.RenameColumn(
                name: "BankAddress",
                table: "bank",
                newName: "bank_address");

            migrationBuilder.RenameColumn(
                name: "BankId",
                table: "bank",
                newName: "bank_id");

            migrationBuilder.RenameColumn(
                name: "OpenTime",
                table: "working_day",
                newName: "open_time");

            migrationBuilder.RenameColumn(
                name: "CloseTime",
                table: "working_day",
                newName: "close_time");

            migrationBuilder.RenameColumn(
                name: "DayOfTheWeek",
                table: "working_day",
                newName: "day_of_the_week");

            migrationBuilder.RenameColumn(
                name: "WorkingDayId",
                table: "working_day",
                newName: "working_day_id");

            migrationBuilder.RenameColumn(
                name: "NameOfService",
                table: "service_in_bank",
                newName: "name_of_service");

            migrationBuilder.RenameColumn(
                name: "EmployeePersonId",
                table: "service_in_bank",
                newName: "employee_person_id");

            migrationBuilder.RenameColumn(
                name: "DateOfService",
                table: "service_in_bank",
                newName: "date_of_service");

            migrationBuilder.RenameColumn(
                name: "ClientPersonId",
                table: "service_in_bank",
                newName: "client_person_id");

            migrationBuilder.RenameColumn(
                name: "ServiceInBankId",
                table: "service_in_bank",
                newName: "service_in_bank_id");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceInBank_EmployeePersonId",
                table: "service_in_bank",
                newName: "ix_service_in_bank_employee_person_id");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceInBank_ClientPersonId",
                table: "service_in_bank",
                newName: "ix_service_in_bank_client_person_id");

            migrationBuilder.RenameColumn(
                name: "ServiceInBankId",
                table: "service_for_client_in_bank",
                newName: "service_in_bank_id");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "service_for_client_in_bank",
                newName: "client_id");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceForClientInBank_ServiceInBankId",
                table: "service_for_client_in_bank",
                newName: "ix_service_for_client_in_bank_service_in_bank_id");

            migrationBuilder.RenameColumn(
                name: "Currency",
                table: "account_in_bank",
                newName: "currency");

            migrationBuilder.RenameColumn(
                name: "ClientPersonId",
                table: "account_in_bank",
                newName: "client_person_id");

            migrationBuilder.RenameColumn(
                name: "AmountOnAccount",
                table: "account_in_bank",
                newName: "amount_on_account");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "account_in_bank",
                newName: "account_id");

            migrationBuilder.RenameIndex(
                name: "IX_AccountInBank_ClientPersonId",
                table: "account_in_bank",
                newName: "ix_account_in_bank_client_person_id");

            migrationBuilder.AddColumn<int>(
                name: "account_in_bank_id",
                table: "transaction",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "bank_branch_id",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "pk_transaction",
                table: "transaction",
                column: "transaction_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_occupation",
                table: "occupation",
                column: "occupation_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_employees",
                table: "Employees",
                column: "person_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_clients",
                table: "Clients",
                column: "person_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_bank",
                table: "bank",
                column: "bank_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_service_in_bank",
                table: "service_in_bank",
                column: "service_in_bank_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_service_for_client_in_bank",
                table: "service_for_client_in_bank",
                columns: new[] { "client_id", "service_in_bank_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_account_in_bank",
                table: "account_in_bank",
                column: "account_id");

            migrationBuilder.CreateTable(
                name: "bank_branch",
                columns: table => new
                {
                    bankbranchid = table.Column<int>(name: "bank_branch_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bankbranchname = table.Column<string>(name: "bank_branch_name", type: "text", nullable: false),
                    bankid = table.Column<int>(name: "bank_id", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_bank_branch", x => x.bankbranchid);
                    table.ForeignKey(
                        name: "fk_bank_branch_bank_bank_id",
                        column: x => x.bankid,
                        principalTable: "bank",
                        principalColumn: "bank_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_transaction_account_in_bank_id",
                table: "transaction",
                column: "account_in_bank_id");

            migrationBuilder.CreateIndex(
                name: "ix_employees_bank_branch_id",
                table: "Employees",
                column: "bank_branch_id");

            migrationBuilder.CreateIndex(
                name: "ix_bank_branch_bank_id",
                table: "bank_branch",
                column: "bank_id");

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
                name: "fk_service_for_client_in_bank_service_in_bank_service_in_bank_",
                table: "service_for_client_in_bank",
                column: "service_in_bank_id",
                principalTable: "service_in_bank",
                principalColumn: "service_in_bank_id",
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

            migrationBuilder.AddForeignKey(
                name: "fk_transaction_account_in_bank_account_in_bank_id",
                table: "transaction",
                column: "account_in_bank_id",
                principalTable: "account_in_bank",
                principalColumn: "account_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "fk_service_for_client_in_bank_service_in_bank_service_in_bank_",
                table: "service_for_client_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_service_in_bank_clients_client_person_id",
                table: "service_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_service_in_bank_employees_employee_person_id",
                table: "service_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_transaction_account_in_bank_account_in_bank_id",
                table: "transaction");

            migrationBuilder.DropTable(
                name: "bank_branch");

            migrationBuilder.DropPrimaryKey(
                name: "pk_transaction",
                table: "transaction");

            migrationBuilder.DropIndex(
                name: "ix_transaction_account_in_bank_id",
                table: "transaction");

            migrationBuilder.DropPrimaryKey(
                name: "pk_occupation",
                table: "occupation");

            migrationBuilder.DropPrimaryKey(
                name: "pk_employees",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "ix_employees_bank_branch_id",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "pk_clients",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "pk_bank",
                table: "bank");

            migrationBuilder.DropPrimaryKey(
                name: "pk_service_in_bank",
                table: "service_in_bank");

            migrationBuilder.DropPrimaryKey(
                name: "pk_service_for_client_in_bank",
                table: "service_for_client_in_bank");

            migrationBuilder.DropPrimaryKey(
                name: "pk_account_in_bank",
                table: "account_in_bank");

            migrationBuilder.DropColumn(
                name: "account_in_bank_id",
                table: "transaction");

            migrationBuilder.DropColumn(
                name: "bank_branch_id",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "transaction",
                newName: "Transaction");

            migrationBuilder.RenameTable(
                name: "occupation",
                newName: "Occupation");

            migrationBuilder.RenameTable(
                name: "bank",
                newName: "Bank");

            migrationBuilder.RenameTable(
                name: "working_day",
                newName: "WorkingDay");

            migrationBuilder.RenameTable(
                name: "service_in_bank",
                newName: "ServiceInBank");

            migrationBuilder.RenameTable(
                name: "service_for_client_in_bank",
                newName: "ServiceForClientInBank");

            migrationBuilder.RenameTable(
                name: "account_in_bank",
                newName: "AccountInBank");

            migrationBuilder.RenameColumn(
                name: "transaction_name",
                table: "Transaction",
                newName: "TransactionName");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "Transaction",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "account_id",
                table: "Transaction",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "transaction_id",
                table: "Transaction",
                newName: "TransactionId");

            migrationBuilder.RenameColumn(
                name: "occupation_name",
                table: "Occupation",
                newName: "OccupationName");

            migrationBuilder.RenameColumn(
                name: "occupation_id",
                table: "Occupation",
                newName: "OccupationId");

            migrationBuilder.RenameColumn(
                name: "occupation_id",
                table: "Employees",
                newName: "OccupationId");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Employees",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firs_name",
                table: "Employees",
                newName: "FirsName");

            migrationBuilder.RenameColumn(
                name: "employee_phone",
                table: "Employees",
                newName: "EmployeePhone");

            migrationBuilder.RenameColumn(
                name: "email_addres",
                table: "Employees",
                newName: "EmailAddres");

            migrationBuilder.RenameIndex(
                name: "ix_employees_occupation_id",
                table: "Employees",
                newName: "IX_Employees_OccupationId");

            migrationBuilder.RenameColumn(
                name: "citizenship",
                table: "Clients",
                newName: "Citizenship");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Clients",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firs_name",
                table: "Clients",
                newName: "FirsName");

            migrationBuilder.RenameColumn(
                name: "email_addres",
                table: "Clients",
                newName: "EmailAddres");

            migrationBuilder.RenameColumn(
                name: "bank_name",
                table: "Bank",
                newName: "BankName");

            migrationBuilder.RenameColumn(
                name: "bank_address",
                table: "Bank",
                newName: "BankAddress");

            migrationBuilder.RenameColumn(
                name: "bank_id",
                table: "Bank",
                newName: "BankId");

            migrationBuilder.RenameColumn(
                name: "open_time",
                table: "WorkingDay",
                newName: "OpenTime");

            migrationBuilder.RenameColumn(
                name: "close_time",
                table: "WorkingDay",
                newName: "CloseTime");

            migrationBuilder.RenameColumn(
                name: "day_of_the_week",
                table: "WorkingDay",
                newName: "DayOfTheWeek");

            migrationBuilder.RenameColumn(
                name: "working_day_id",
                table: "WorkingDay",
                newName: "WorkingDayId");

            migrationBuilder.RenameColumn(
                name: "name_of_service",
                table: "ServiceInBank",
                newName: "NameOfService");

            migrationBuilder.RenameColumn(
                name: "employee_person_id",
                table: "ServiceInBank",
                newName: "EmployeePersonId");

            migrationBuilder.RenameColumn(
                name: "date_of_service",
                table: "ServiceInBank",
                newName: "DateOfService");

            migrationBuilder.RenameColumn(
                name: "client_person_id",
                table: "ServiceInBank",
                newName: "ClientPersonId");

            migrationBuilder.RenameColumn(
                name: "service_in_bank_id",
                table: "ServiceInBank",
                newName: "ServiceInBankId");

            migrationBuilder.RenameIndex(
                name: "ix_service_in_bank_employee_person_id",
                table: "ServiceInBank",
                newName: "IX_ServiceInBank_EmployeePersonId");

            migrationBuilder.RenameIndex(
                name: "ix_service_in_bank_client_person_id",
                table: "ServiceInBank",
                newName: "IX_ServiceInBank_ClientPersonId");

            migrationBuilder.RenameColumn(
                name: "service_in_bank_id",
                table: "ServiceForClientInBank",
                newName: "ServiceInBankId");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "ServiceForClientInBank",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "ix_service_for_client_in_bank_service_in_bank_id",
                table: "ServiceForClientInBank",
                newName: "IX_ServiceForClientInBank_ServiceInBankId");

            migrationBuilder.RenameColumn(
                name: "currency",
                table: "AccountInBank",
                newName: "Currency");

            migrationBuilder.RenameColumn(
                name: "client_person_id",
                table: "AccountInBank",
                newName: "ClientPersonId");

            migrationBuilder.RenameColumn(
                name: "amount_on_account",
                table: "AccountInBank",
                newName: "AmountOnAccount");

            migrationBuilder.RenameColumn(
                name: "account_id",
                table: "AccountInBank",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "ix_account_in_bank_client_person_id",
                table: "AccountInBank",
                newName: "IX_AccountInBank_ClientPersonId");

            migrationBuilder.AddColumn<int>(
                name: "AccountInBankAccountId",
                table: "Transaction",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "TransactionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Occupation",
                table: "Occupation",
                column: "OccupationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "person_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "person_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bank",
                table: "Bank",
                column: "BankId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceInBank",
                table: "ServiceInBank",
                column: "ServiceInBankId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceForClientInBank",
                table: "ServiceForClientInBank",
                columns: new[] { "ClientId", "ServiceInBankId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountInBank",
                table: "AccountInBank",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_AccountInBankAccountId",
                table: "Transaction",
                column: "AccountInBankAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountInBank_Clients_ClientPersonId",
                table: "AccountInBank",
                column: "ClientPersonId",
                principalTable: "Clients",
                principalColumn: "person_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Occupation_OccupationId",
                table: "Employees",
                column: "OccupationId",
                principalTable: "Occupation",
                principalColumn: "OccupationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceForClientInBank_Clients_ClientId",
                table: "ServiceForClientInBank",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceForClientInBank_ServiceInBank_ServiceInBankId",
                table: "ServiceForClientInBank",
                column: "ServiceInBankId",
                principalTable: "ServiceInBank",
                principalColumn: "ServiceInBankId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceInBank_Clients_ClientPersonId",
                table: "ServiceInBank",
                column: "ClientPersonId",
                principalTable: "Clients",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceInBank_Employees_EmployeePersonId",
                table: "ServiceInBank",
                column: "EmployeePersonId",
                principalTable: "Employees",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_AccountInBank_AccountInBankAccountId",
                table: "Transaction",
                column: "AccountInBankAccountId",
                principalTable: "AccountInBank",
                principalColumn: "AccountId");
        }
    }
}
