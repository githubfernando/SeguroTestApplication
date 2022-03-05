using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationSeguros.Migrations
{
    public partial class secondtMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "InsurancePolicies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "InsurancePolicies");
        }
    }
}
