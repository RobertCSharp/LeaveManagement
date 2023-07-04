using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-281b-4262-a10f-a1872c4e2f08", "6eff5ae7-8be3-452a-8b3c-be6007e91fbf", "Administrator", "ADMINISTRATOR" },
                    { "cac43a6e-281b-4262-baaf-a1872c4eaf08", "c151d9b5-f5be-44d5-949d-6a2b085ef28c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "34565286-6452-4a26-a069-120b31427c39", 0, "a8357c63-672b-4324-8ede-359f6ef64585", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEJISnJ1cYdbDqGzNeFPBr36RJbylmhiCXHTRjMgCqcgZXdt2tUCwrvPxAlC1DqWngw==", null, false, "7f197525-0d91-4889-8662-b3290af12b87", null, false, null },
                    { "3c7ee887-281b-4262-a10f-a1872c4e2f08", 0, "d8ee68c4-a924-4d9b-8f3b-6f5e77a7c6da", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEKrtY/BAdlxskMIThJJQQoCcLiEOss0gKgbpbLVgHrbszARv6WZKoQSF3vgidVbV6g==", null, false, "6cc0d352-322a-4a52-9ff4-8f618c1b19c6", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-281b-4262-a10f-a1872c4e2f08", "34565286-6452-4a26-a069-120b31427c39" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-281b-4262-baaf-a1872c4eaf08", "3c7ee887-281b-4262-a10f-a1872c4e2f08" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-281b-4262-a10f-a1872c4e2f08", "34565286-6452-4a26-a069-120b31427c39" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-281b-4262-baaf-a1872c4eaf08", "3c7ee887-281b-4262-a10f-a1872c4e2f08" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-281b-4262-a10f-a1872c4e2f08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-281b-4262-baaf-a1872c4eaf08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34565286-6452-4a26-a069-120b31427c39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c7ee887-281b-4262-a10f-a1872c4e2f08");
        }
    }
}
