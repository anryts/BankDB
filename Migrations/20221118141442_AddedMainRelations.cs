using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BankDB.Migrations
{
    public partial class AddedMainRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OccupationId",
                table: "Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Occupation",
                columns: table => new
                {
                    OccupationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OccupationName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupation", x => x.OccupationId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceInBank",
                columns: table => new
                {
                    ServiceInBankId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameOfService = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    DateOfService = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceInBank", x => x.ServiceInBankId);
                    table.ForeignKey(
                        name: "FK_ServiceInBank_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "client_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceInBank_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionId = table.Column<string>(type: "text", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    TransactionName = table.Column<string>(type: "text", nullable: false),
                    AccountInBankAccountId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_Transaction_AccountInBank_AccountInBankAccountId",
                        column: x => x.AccountInBankAccountId,
                        principalTable: "AccountInBank",
                        principalColumn: "AccountId");
                });

            migrationBuilder.CreateTable(
                name: "ServiceForClientInBank",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "integer", nullable: false),
                    ServiceInBankId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceForClientInBank", x => new { x.ClientId, x.ServiceInBankId });
                    table.ForeignKey(
                        name: "FK_ServiceForClientInBank_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "client_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceForClientInBank_ServiceInBank_ServiceInBankId",
                        column: x => x.ServiceInBankId,
                        principalTable: "ServiceInBank",
                        principalColumn: "ServiceInBankId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_OccupationId",
                table: "Employee",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceForClientInBank_ServiceInBankId",
                table: "ServiceForClientInBank",
                column: "ServiceInBankId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInBank_ClientId",
                table: "ServiceInBank",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInBank_EmployeeId",
                table: "ServiceInBank",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_AccountInBankAccountId",
                table: "Transaction",
                column: "AccountInBankAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Occupation_OccupationId",
                table: "Employee",
                column: "OccupationId",
                principalTable: "Occupation",
                principalColumn: "OccupationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Occupation_OccupationId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Occupation");

            migrationBuilder.DropTable(
                name: "ServiceForClientInBank");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "ServiceInBank");

            migrationBuilder.DropIndex(
                name: "IX_Employee_OccupationId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "OccupationId",
                table: "Employee");
        }
    }
}
