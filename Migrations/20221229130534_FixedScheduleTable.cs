using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDB.Migrations
{
    /// <inheritdoc />
    public partial class FixedScheduleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_working_day_schedule_schedule_id",
                table: "working_day");

            migrationBuilder.DropColumn(
                name: "employee_id",
                table: "schedule");

            migrationBuilder.AlterColumn<int>(
                name: "schedule_id",
                table: "working_day",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "schedule",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "fk_working_day_schedule_schedule_id",
                table: "working_day",
                column: "schedule_id",
                principalTable: "schedule",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_working_day_schedule_schedule_id",
                table: "working_day");

            migrationBuilder.DropColumn(
                name: "name",
                table: "schedule");

            migrationBuilder.AlterColumn<int>(
                name: "schedule_id",
                table: "working_day",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "employee_id",
                table: "schedule",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "fk_working_day_schedule_schedule_id",
                table: "working_day",
                column: "schedule_id",
                principalTable: "schedule",
                principalColumn: "id");
        }
    }
}
