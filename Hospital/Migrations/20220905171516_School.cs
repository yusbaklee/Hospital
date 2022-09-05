using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    public partial class School : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "school",
                columns: table => new
                {
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(name: "School Name", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SchoolAddress = table.Column<string>(name: "School Address", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SchoolEmail = table.Column<string>(name: "School Email", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SchoolPhoneNumber = table.Column<int>(name: "School PhoneNumber", type: "int", nullable: false),
                    FoundedYear = table.Column<DateTime>(name: "Founded Year", type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_school", x => x.SchoolId);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    StaffName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "school");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
