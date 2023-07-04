using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class SeedingDefaultUsersData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "5275caed-ab20-4f29-b54d-1fbee613c3ca", "Administrator", "ADMINISTRATOR" },
                    { "2", "8a51450e-4350-4be7-8e0d-5d2d5f75fe27", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34565286-6452-4a26-a069-120b31427c39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b8ae5eb-4b4b-4527-872a-85d6f14f6318", "AQAAAAEAACcQAAAAEIORfWP3g/MTVwGZEsvBRFtkqfA6kt7GbXmsa45mmQA49PugIgB+0VVNi4mT90Q2Og==", "95e90e4f-0972-4d2b-90bd-37742325f48e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c7ee887-281b-4262-a10f-a1872c4e2f08",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "841e2311-73b8-4df8-a0dc-4d857593508e", "AQAAAAEAACcQAAAAEAp90EqQkXyOe4Sh1XQVE0cUOtVtMG9RoBScph4L5DoPVWfBz/i5EtaLV85RCgPaZQ==", "7f1732af-4bc5-42c3-b119-374d11c153d5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "34565286-6452-4a26-a069-120b31427c39" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "3c7ee887-281b-4262-a10f-a1872c4e2f08" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "34565286-6452-4a26-a069-120b31427c39" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "3c7ee887-281b-4262-a10f-a1872c4e2f08" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-281b-4262-a10f-a1872c4e2f08", "4a561bfb-a44d-4235-aa23-3184fa04b054", "Adminstrator", "ADMINISTRATOR" },
                    { "cac43a6e-281b-4262-baaf-a1872c4eaf08", "2418a651-3e97-4317-a3c0-1e73f0803728", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34565286-6452-4a26-a069-120b31427c39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0685e570-20f4-4088-8f91-93afa79efa67", "AQAAAAEAACcQAAAAEFi9FO9qw6iKLTDCJU7pWnvuInLVVscrHOe+UPCntHprKULPxXfQEo02MAFdkIUHEg==", "83136a45-340b-4586-b391-23a3a7b6da54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c7ee887-281b-4262-a10f-a1872c4e2f08",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c957cdfb-223c-43f2-a5e2-dafc9a793dca", "AQAAAAEAACcQAAAAEGOeZdK0q/hH68mMNIdMQ4XcJgaFLCYSZuHdpxZ37QPciqt+YF2wBk4UCkvBIzO7Ig==", "b5541184-1b02-4527-b58c-89152d0f590b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-281b-4262-a10f-a1872c4e2f08", "34565286-6452-4a26-a069-120b31427c39" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-281b-4262-baaf-a1872c4eaf08", "3c7ee887-281b-4262-a10f-a1872c4e2f08" });
        }
    }
}
