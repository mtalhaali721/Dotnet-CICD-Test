using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TKWebAPI.Migrations
{
    public partial class DropElectronicModelAndAddDevicesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    DevId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DevCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DevName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DevQuantity = table.Column<int>(type: "int", nullable: false),
                    DevRate = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.DevId);
                });
        }
    }
}
