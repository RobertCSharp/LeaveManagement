using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class SeedingDefaultUsersNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3027535d-a20c-4983-96e4-d657bfc56aeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "262b4d25-f435-437c-a413-15309bce3552");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34565286-6452-4a26-a069-120b31427c39",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8504b1ac-1121-4de8-8cab-525c2f27397c", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEMNpIy7MXACL7Tkceq6Lx3jCWGTvO/eSr69jmfRz/y3LcqKkfqaPkrh6hJpMWnWAsg==", "0db18d04-8460-4d27-b46b-a21d5142736e", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c7ee887-281b-4262-a10f-a1872c4e2f08",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0adf41d6-e281-420d-8c90-71ac6823e4db", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAENIBMGGkylMaa5bxoS4ucYlNrmKYFybFYND1BRYslnFrsY3c6K3tLfd0uSCe9F1etA==", "fbef1c03-6eeb-40cb-947e-22175fe2720d", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5275caed-ab20-4f29-b54d-1fbee613c3ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8a51450e-4350-4be7-8e0d-5d2d5f75fe27");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34565286-6452-4a26-a069-120b31427c39",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8b8ae5eb-4b4b-4527-872a-85d6f14f6318", null, "AQAAAAEAACcQAAAAEIORfWP3g/MTVwGZEsvBRFtkqfA6kt7GbXmsa45mmQA49PugIgB+0VVNi4mT90Q2Og==", "95e90e4f-0972-4d2b-90bd-37742325f48e", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c7ee887-281b-4262-a10f-a1872c4e2f08",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "841e2311-73b8-4df8-a0dc-4d857593508e", null, "AQAAAAEAACcQAAAAEAp90EqQkXyOe4Sh1XQVE0cUOtVtMG9RoBScph4L5DoPVWfBz/i5EtaLV85RCgPaZQ==", "7f1732af-4bc5-42c3-b119-374d11c153d5", null });
        }
    }
}
