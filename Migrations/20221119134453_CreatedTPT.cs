using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDB.Migrations
{
    public partial class CreatedTPT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountInBank_Client_ClientId",
                table: "AccountInBank");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Occupation_OccupationId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceForClientInBank_Client_ClientId",
                table: "ServiceForClientInBank");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInBank_Client_ClientId",
                table: "ServiceInBank");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInBank_Employee_EmployeeId",
                table: "ServiceInBank");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropUniqueConstraint(
                name: "ClientEmail",
                table: "Client");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "EmployeeEmail",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeeName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Client");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "ServiceInBank",
                newName: "EmployeePersonId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "ServiceInBank",
                newName: "ClientPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceInBank_EmployeeId",
                table: "ServiceInBank",
                newName: "IX_ServiceInBank_EmployeePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceInBank_ClientId",
                table: "ServiceInBank",
                newName: "IX_ServiceInBank_ClientPersonId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "AccountInBank",
                newName: "ClientPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_AccountInBank_ClientId",
                table: "AccountInBank",
                newName: "IX_AccountInBank_ClientPersonId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "person_id");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_OccupationId",
                table: "Employees",
                newName: "IX_Employees_OccupationId");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "Clients",
                newName: "person_id");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddres",
                table: "Employees",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirsName",
                table: "Employees",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Clients",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddres",
                table: "Clients",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirsName",
                table: "Clients",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "person_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "person_id");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_ServiceInBank_Clients_ClientPersonId",
                table: "ServiceInBank");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInBank_Employees_EmployeePersonId",
                table: "ServiceInBank");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "EmailAddres",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FirsName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmailAddres",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "FirsName",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.RenameColumn(
                name: "EmployeePersonId",
                table: "ServiceInBank",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "ClientPersonId",
                table: "ServiceInBank",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceInBank_EmployeePersonId",
                table: "ServiceInBank",
                newName: "IX_ServiceInBank_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceInBank_ClientPersonId",
                table: "ServiceInBank",
                newName: "IX_ServiceInBank_ClientId");

            migrationBuilder.RenameColumn(
                name: "ClientPersonId",
                table: "AccountInBank",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_AccountInBank_ClientPersonId",
                table: "AccountInBank",
                newName: "IX_AccountInBank_ClientId");

            migrationBuilder.RenameColumn(
                name: "person_id",
                table: "Employee",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_OccupationId",
                table: "Employee",
                newName: "IX_Employee_OccupationId");

            migrationBuilder.RenameColumn(
                name: "person_id",
                table: "Client",
                newName: "client_id");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeEmail",
                table: "Employee",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeName",
                table: "Employee",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Client",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Client",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Client",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeId");

            migrationBuilder.AddUniqueConstraint(
                name: "ClientEmail",
                table: "Client",
                column: "EmailAddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "client_id");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountInBank_Client_ClientId",
                table: "AccountInBank",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "client_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Occupation_OccupationId",
                table: "Employee",
                column: "OccupationId",
                principalTable: "Occupation",
                principalColumn: "OccupationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceForClientInBank_Client_ClientId",
                table: "ServiceForClientInBank",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "client_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceInBank_Client_ClientId",
                table: "ServiceInBank",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "client_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceInBank_Employee_EmployeeId",
                table: "ServiceInBank",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
