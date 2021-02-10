using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    ShopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopId);
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Adress", "Email", "Name", "Phone" },
                values: new object[] { 1, "adress1", "asqw@mail.com", "SmallShop", "123 456 789" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Adress", "Email", "Name", "Phone" },
                values: new object[] { 2, "adress2", "zxas@mail.com", "MediumShop", "789 456 123" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Adress", "Email", "Name", "Phone" },
                values: new object[] { 3, "adress3", "qwzx@mail.com", "BigShop", "789 456 123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}
