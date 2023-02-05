using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceApp.Persistence.Migrations
{
    public partial class v14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "FinancialInstitutions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "FinancialInstitutions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "FinancialInstitutions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "FinancialInstitutions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxId",
                table: "FinancialInstitutions",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "FinancialInstitutions");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "FinancialInstitutions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "FinancialInstitutions");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "FinancialInstitutions");

            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "FinancialInstitutions");
        }
    }
}
