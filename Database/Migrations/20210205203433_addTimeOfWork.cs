using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class addTimeOfWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TimeOfWork",
                table: "Shops",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1,
                column: "TimeOfWork",
                value: "8:00-20:00");

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2,
                column: "TimeOfWork",
                value: "9:00-21:00");

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3,
                column: "TimeOfWork",
                value: "8:00-23:00");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeOfWork",
                table: "Shops");
        }
    }
}
