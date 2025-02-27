using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "068ada9a-871e-45ea-abea-d17d246c865d", null, "Employee", "EMPLOYEE" },
                    { "3028cec0-d14e-4bad-822b-f406ff5c8337", null, "Supervisor", "SUPERVISOR" },
                    { "866bca51-26a7-41c7-9702-04d33608299c", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "37b2c5dc-e7c3-495e-b21a-426c3187f083", 0, "d4e81303-e578-41b8-84da-a081ef41b7ad", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMaMGofvbUFnRUer0roFTvsSQ6BAwtmcHMHa1812ao0Ipt9QL9QA+YJHDX8DuGPcdw==", null, false, "b648b4ae-75e5-43d9-b75c-ec78e81f5bdf", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "866bca51-26a7-41c7-9702-04d33608299c", "37b2c5dc-e7c3-495e-b21a-426c3187f083" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "068ada9a-871e-45ea-abea-d17d246c865d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3028cec0-d14e-4bad-822b-f406ff5c8337");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "866bca51-26a7-41c7-9702-04d33608299c", "37b2c5dc-e7c3-495e-b21a-426c3187f083" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866bca51-26a7-41c7-9702-04d33608299c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37b2c5dc-e7c3-495e-b21a-426c3187f083");
        }
    }
}
