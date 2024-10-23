using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class asda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClassName",
                table: "Student",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Student",
                newName: "StudentId");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentPhone",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    FirstName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.FirstName);
                });

            migrationBuilder.CreateTable(
                name: "Kitchen",
                columns: table => new
                {
                    MenuDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Food = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CouponId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitchen", x => x.MenuDate);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    SchoolName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SchoolAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.SchoolName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Kitchen");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ParentPhone",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Student",
                newName: "ClassName");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Student",
                newName: "Id");
        }
    }
}
