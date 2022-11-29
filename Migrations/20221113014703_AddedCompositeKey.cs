using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDB.Migrations
{
    public partial class AddedCompositeKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkingDay",
                columns: table => new
                {
                    DayOfTheWeek = table.Column<string>(type: "text", nullable: false),
                    WorkingDayId = table.Column<int>(type: "integer", nullable: false),
                    OpenTime = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CloseTime = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("WorkingDay_id", x => new { x.WorkingDayId, x.DayOfTheWeek });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkingDay");
        }
    }
}
