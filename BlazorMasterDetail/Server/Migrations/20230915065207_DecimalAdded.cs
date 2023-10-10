using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorMasterDetail.Server.Migrations
{
    public partial class DecimalAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Fees",
                table: "Students",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fees",
                table: "Students");
        }
    }
}
