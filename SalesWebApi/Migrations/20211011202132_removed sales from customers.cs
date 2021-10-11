using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebApi.Migrations
{
    public partial class removedsalesfromcustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sales",
                table: "Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Sales",
                table: "Customers",
                type: "decimal(11,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
