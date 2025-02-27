using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37b2c5dc-e7c3-495e-b21a-426c3187f083",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7109d1e-1b1f-4bef-9ee6-d888494b40bf", new DateOnly(1990, 1, 1), "Default", "Admin", "AQAAAAIAAYagAAAAEDuB6CovwOk4nn8JA1sm1gaODEvJtt45IBLHtoLEmRgktFBpI2vOs2pvbiFLJ4ycXA==", "52cd0e05-62f6-40da-9170-68c3a322fdd8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37b2c5dc-e7c3-495e-b21a-426c3187f083",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4e81303-e578-41b8-84da-a081ef41b7ad", "AQAAAAIAAYagAAAAEMaMGofvbUFnRUer0roFTvsSQ6BAwtmcHMHa1812ao0Ipt9QL9QA+YJHDX8DuGPcdw==", "b648b4ae-75e5-43d9-b75c-ec78e81f5bdf" });
        }
    }
}
