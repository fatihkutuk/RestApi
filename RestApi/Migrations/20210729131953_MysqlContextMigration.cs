using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApi.Migrations
{
    public partial class MysqlContextMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CompanyGroupId = table.Column<int>(type: "int", nullable: false),
                    CompanyAdressCityId = table.Column<int>(type: "int", nullable: false),
                    CompanyAdressCountyId = table.Column<int>(type: "int", nullable: false),
                    CompanyAdressNeighborhoodId = table.Column<int>(type: "int", nullable: false),
                    CompanyAdressStreetId = table.Column<int>(type: "int", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    CompanyLocation = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompanyDelegateName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CompanyDelegatePhoneNumber = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    CompanyMail = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CompanyGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyGroupName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyGroups", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "CompanyGroups");
        }
    }
}
