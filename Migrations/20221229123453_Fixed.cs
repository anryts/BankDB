using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BankDB.Migrations
{
    /// <inheritdoc />
    public partial class Fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_account_in_bank_client_client_person_id",
                table: "account_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_bank_branch_bank_bank_id",
                table: "bank_branch");

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

            migrationBuilder.DropForeignKey(
                name: "fk_transaction_account_in_bank_account_in_bank_id",
                table: "transaction");

            migrationBuilder.DropPrimaryKey(
                name: "WorkingDay_id",
                table: "working_day");

            migrationBuilder.DropPrimaryKey(
                name: "pk_employee",
                table: "employee");

            migrationBuilder.DropPrimaryKey(
                name: "pk_client",
                table: "client");

            migrationBuilder.DropPrimaryKey(
                name: "pk_bank",
                table: "bank");

            migrationBuilder.DropPrimaryKey(
                name: "pk_account_in_bank",
                table: "account_in_bank");

            migrationBuilder.RenameTable(
                name: "employee",
                newName: "employees");

            migrationBuilder.RenameTable(
                name: "client",
                newName: "clients");

            migrationBuilder.RenameTable(
                name: "bank",
                newName: "banks");

            migrationBuilder.RenameTable(
                name: "account_in_bank",
                newName: "account_in_banks");

            migrationBuilder.RenameColumn(
                name: "firs_name",
                table: "employees",
                newName: "first_name");

            migrationBuilder.RenameIndex(
                name: "ix_employee_occupation_id",
                table: "employees",
                newName: "ix_employees_occupation_id");

            migrationBuilder.RenameIndex(
                name: "ix_employee_bank_branch_id",
                table: "employees",
                newName: "ix_employees_bank_branch_id");

            migrationBuilder.RenameColumn(
                name: "firs_name",
                table: "clients",
                newName: "first_name");

            migrationBuilder.RenameIndex(
                name: "ix_account_in_bank_client_person_id",
                table: "account_in_banks",
                newName: "ix_account_in_banks_client_person_id");

            migrationBuilder.AlterColumn<string>(
                name: "open_time",
                table: "working_day",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "close_time",
                table: "working_day",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "day_of_the_week",
                table: "working_day",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "schedule_id",
                table: "working_day",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "schedule_id",
                table: "employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "working_day_id",
                table: "working_day",
                columns: new[] { "working_day_id", "day_of_the_week" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_employees",
                table: "employees",
                column: "person_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_clients",
                table: "clients",
                column: "person_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_banks",
                table: "banks",
                column: "bank_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_account_in_banks",
                table: "account_in_banks",
                column: "account_id");

            migrationBuilder.CreateTable(
                name: "schedule",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employeeid = table.Column<int>(name: "employee_id", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_schedule", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "ix_working_day_schedule_id",
                table: "working_day",
                column: "schedule_id");

            migrationBuilder.CreateIndex(
                name: "ix_employees_schedule_id",
                table: "employees",
                column: "schedule_id");

            migrationBuilder.AddForeignKey(
                name: "fk_account_in_banks_clients_client_person_id",
                table: "account_in_banks",
                column: "client_person_id",
                principalTable: "clients",
                principalColumn: "person_id");

            migrationBuilder.AddForeignKey(
                name: "fk_bank_branch_banks_bank_id",
                table: "bank_branch",
                column: "bank_id",
                principalTable: "banks",
                principalColumn: "bank_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_employees_bank_branch_bank_branch_id",
                table: "employees",
                column: "bank_branch_id",
                principalTable: "bank_branch",
                principalColumn: "bank_branch_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_employees_occupation_occupation_id",
                table: "employees",
                column: "occupation_id",
                principalTable: "occupation",
                principalColumn: "occupation_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_employees_schedule_schedule_id",
                table: "employees",
                column: "schedule_id",
                principalTable: "schedule",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_service_for_client_in_bank_clients_client_id",
                table: "service_for_client_in_bank",
                column: "client_id",
                principalTable: "clients",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_service_in_bank_clients_client_person_id",
                table: "service_in_bank",
                column: "client_person_id",
                principalTable: "clients",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_service_in_bank_employees_employee_person_id",
                table: "service_in_bank",
                column: "employee_person_id",
                principalTable: "employees",
                principalColumn: "person_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_transaction_account_in_banks_account_in_bank_id",
                table: "transaction",
                column: "account_in_bank_id",
                principalTable: "account_in_banks",
                principalColumn: "account_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_working_day_schedule_schedule_id",
                table: "working_day",
                column: "schedule_id",
                principalTable: "schedule",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_account_in_banks_clients_client_person_id",
                table: "account_in_banks");

            migrationBuilder.DropForeignKey(
                name: "fk_bank_branch_banks_bank_id",
                table: "bank_branch");

            migrationBuilder.DropForeignKey(
                name: "fk_employees_bank_branch_bank_branch_id",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "fk_employees_occupation_occupation_id",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "fk_employees_schedule_schedule_id",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "fk_service_for_client_in_bank_clients_client_id",
                table: "service_for_client_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_service_in_bank_clients_client_person_id",
                table: "service_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_service_in_bank_employees_employee_person_id",
                table: "service_in_bank");

            migrationBuilder.DropForeignKey(
                name: "fk_transaction_account_in_banks_account_in_bank_id",
                table: "transaction");

            migrationBuilder.DropForeignKey(
                name: "fk_working_day_schedule_schedule_id",
                table: "working_day");

            migrationBuilder.DropTable(
                name: "schedule");

            migrationBuilder.DropPrimaryKey(
                name: "working_day_id",
                table: "working_day");

            migrationBuilder.DropIndex(
                name: "ix_working_day_schedule_id",
                table: "working_day");

            migrationBuilder.DropPrimaryKey(
                name: "pk_employees",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "ix_employees_schedule_id",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "pk_clients",
                table: "clients");

            migrationBuilder.DropPrimaryKey(
                name: "pk_banks",
                table: "banks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_account_in_banks",
                table: "account_in_banks");

            migrationBuilder.DropColumn(
                name: "schedule_id",
                table: "working_day");

            migrationBuilder.DropColumn(
                name: "schedule_id",
                table: "employees");

            migrationBuilder.RenameTable(
                name: "employees",
                newName: "employee");

            migrationBuilder.RenameTable(
                name: "clients",
                newName: "client");

            migrationBuilder.RenameTable(
                name: "banks",
                newName: "bank");

            migrationBuilder.RenameTable(
                name: "account_in_banks",
                newName: "account_in_bank");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "employee",
                newName: "firs_name");

            migrationBuilder.RenameIndex(
                name: "ix_employees_occupation_id",
                table: "employee",
                newName: "ix_employee_occupation_id");

            migrationBuilder.RenameIndex(
                name: "ix_employees_bank_branch_id",
                table: "employee",
                newName: "ix_employee_bank_branch_id");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "client",
                newName: "firs_name");

            migrationBuilder.RenameIndex(
                name: "ix_account_in_banks_client_person_id",
                table: "account_in_bank",
                newName: "ix_account_in_bank_client_person_id");

            migrationBuilder.AlterColumn<string>(
                name: "open_time",
                table: "working_day",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "close_time",
                table: "working_day",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "day_of_the_week",
                table: "working_day",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "WorkingDay_id",
                table: "working_day",
                columns: new[] { "working_day_id", "day_of_the_week" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_employee",
                table: "employee",
                column: "person_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_client",
                table: "client",
                column: "person_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_bank",
                table: "bank",
                column: "bank_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_account_in_bank",
                table: "account_in_bank",
                column: "account_id");

            migrationBuilder.AddForeignKey(
                name: "fk_account_in_bank_client_client_person_id",
                table: "account_in_bank",
                column: "client_person_id",
                principalTable: "client",
                principalColumn: "person_id");

            migrationBuilder.AddForeignKey(
                name: "fk_bank_branch_bank_bank_id",
                table: "bank_branch",
                column: "bank_id",
                principalTable: "bank",
                principalColumn: "bank_id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "fk_transaction_account_in_bank_account_in_bank_id",
                table: "transaction",
                column: "account_in_bank_id",
                principalTable: "account_in_bank",
                principalColumn: "account_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
