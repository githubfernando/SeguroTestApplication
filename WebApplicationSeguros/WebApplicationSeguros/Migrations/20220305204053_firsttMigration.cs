using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationSeguros.Migrations
{
    public partial class firsttMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoverTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identification = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeRisks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameRisk = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeRisks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsurancePolicies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameCoverType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDatePoliceValidity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoveragePeriod = table.Column<int>(type: "int", nullable: false),
                    PolicyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NameTypeRisk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverTypeId = table.Column<int>(type: "int", nullable: true),
                    TypeRiskId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsurancePolicies", x => x.id);
                    table.ForeignKey(
                        name: "FK_InsurancePolicies_CoverTypes_CoverTypeId",
                        column: x => x.CoverTypeId,
                        principalTable: "CoverTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InsurancePolicies_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InsurancePolicies_TypeRisks_TypeRiskId",
                        column: x => x.TypeRiskId,
                        principalTable: "TypeRisks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_CoverTypeId",
                table: "InsurancePolicies",
                column: "CoverTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_CustomerId",
                table: "InsurancePolicies",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_TypeRiskId",
                table: "InsurancePolicies",
                column: "TypeRiskId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InsurancePolicies");

            migrationBuilder.DropTable(
                name: "CoverTypes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "TypeRisks");
        }
    }
}
