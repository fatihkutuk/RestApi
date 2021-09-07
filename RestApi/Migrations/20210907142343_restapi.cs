using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApi.Migrations
{
    public partial class restapi : Migration
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

            migrationBuilder.CreateTable(
                name: "Cties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cties", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    isActive = table.Column<ulong>(type: "bit", nullable: false),
                    isAuthentication = table.Column<ulong>(type: "bit", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CompanyAppointmentTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    TimeToStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    TimeToFinish = table.Column<DateTime>(type: "datetime", nullable: false),
                    isAvaible = table.Column<ulong>(type: "bit", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAppointmentTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_CompanyAppointmentTimes",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CompanyImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageDescription = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_CompanyImages",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CompanyWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Price = table.Column<double>(type: "double", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    DurationMin = table.Column<double>(type: "double", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_CompanyWorks",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Counties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CountyName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Counties_Cties",
                        column: x => x.CityId,
                        principalTable: "Cties",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CompanyComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Rank = table.Column<double>(type: "double", nullable: false),
                    isConfirmed = table.Column<ulong>(type: "bit", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_CompanyComments",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_CompanyComments",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CompanyAppointmentTimeId = table.Column<int>(type: "int", nullable: false),
                    isFinished = table.Column<ulong>(type: "bit", nullable: false),
                    isConfirmed = table.Column<ulong>(type: "bit", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAppointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyAppointmentTimes_UserAppointments",
                        column: x => x.CompanyAppointmentTimeId,
                        principalTable: "CompanyAppointmentTimes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_UserAppointments",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Neighborhoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NeighborhoodName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CountyId = table.Column<int>(type: "int", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Neighborhoods_Counties",
                        column: x => x.CountyId,
                        principalTable: "Counties",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserAppointmentsSelectedWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserAppointmentId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyWorkId = table.Column<int>(type: "int", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAppointmentsSelectedWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_PK_UserAppointmentsSelectedWorks",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyWork_PK_UserAppointmentsSelectedWorks",
                        column: x => x.CompanyWorkId,
                        principalTable: "CompanyWorks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_PK_UserAppointmentsSelectedWorks",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserAppointments_PK_UserAppointmentsSelectedWorks",
                        column: x => x.UserAppointmentId,
                        principalTable: "UserAppointments",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Streets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StreetName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NeighborhoodId = table.Column<int>(type: "int", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Streets_Neighborhoods",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAppointmentTimes_CompanyId",
                table: "CompanyAppointmentTimes",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyComments_CompanyId",
                table: "CompanyComments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyComments_UserId",
                table: "CompanyComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyImages_CompanyId",
                table: "CompanyImages",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyWorks_CompanyId",
                table: "CompanyWorks",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Counties_CityId",
                table: "Counties",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Neighborhoods_CountyId",
                table: "Neighborhoods",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_Streets_NeighborhoodId",
                table: "Streets",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAppointments_CompanyAppointmentTimeId",
                table: "UserAppointments",
                column: "CompanyAppointmentTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAppointments_UserId",
                table: "UserAppointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAppointmentsSelectedWorks_CompanyId",
                table: "UserAppointmentsSelectedWorks",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAppointmentsSelectedWorks_CompanyWorkId",
                table: "UserAppointmentsSelectedWorks",
                column: "CompanyWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAppointmentsSelectedWorks_UserAppointmentId",
                table: "UserAppointmentsSelectedWorks",
                column: "UserAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAppointmentsSelectedWorks_UserId",
                table: "UserAppointmentsSelectedWorks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyComments");

            migrationBuilder.DropTable(
                name: "CompanyGroups");

            migrationBuilder.DropTable(
                name: "CompanyImages");

            migrationBuilder.DropTable(
                name: "Streets");

            migrationBuilder.DropTable(
                name: "UserAppointmentsSelectedWorks");

            migrationBuilder.DropTable(
                name: "Neighborhoods");

            migrationBuilder.DropTable(
                name: "CompanyWorks");

            migrationBuilder.DropTable(
                name: "UserAppointments");

            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "CompanyAppointmentTimes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cties");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
