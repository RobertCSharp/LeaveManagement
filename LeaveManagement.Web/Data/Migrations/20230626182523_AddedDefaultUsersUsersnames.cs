using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsersnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-281b-4262-a10f-a1872c4e2f08",
                column: "ConcurrencyStamp",
                value: "4a561bfb-a44d-4235-aa23-3184fa04b054");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-281b-4262-baaf-a1872c4eaf08",
                column: "ConcurrencyStamp",
                value: "2418a651-3e97-4317-a3c0-1e73f0803728");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34565286-6452-4a26-a069-120b31427c39",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0685e570-20f4-4088-8f91-93afa79efa67", true, "AQAAAAEAACcQAAAAEFi9FO9qw6iKLTDCJU7pWnvuInLVVscrHOe+UPCntHprKULPxXfQEo02MAFdkIUHEg==", "83136a45-340b-4586-b391-23a3a7b6da54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c7ee887-281b-4262-a10f-a1872c4e2f08",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c957cdfb-223c-43f2-a5e2-dafc9a793dca", true, "AQAAAAEAACcQAAAAEGOeZdK0q/hH68mMNIdMQ4XcJgaFLCYSZuHdpxZ37QPciqt+YF2wBk4UCkvBIzO7Ig==", "b5541184-1b02-4527-b58c-89152d0f590b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-281b-4262-a10f-a1872c4e2f08",
                column: "ConcurrencyStamp",
                value: "6eff5ae7-8be3-452a-8b3c-be6007e91fbf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-281b-4262-baaf-a1872c4eaf08",
                column: "ConcurrencyStamp",
                value: "c151d9b5-f5be-44d5-949d-6a2b085ef28c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34565286-6452-4a26-a069-120b31427c39",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8357c63-672b-4324-8ede-359f6ef64585", false, "AQAAAAEAACcQAAAAEJISnJ1cYdbDqGzNeFPBr36RJbylmhiCXHTRjMgCqcgZXdt2tUCwrvPxAlC1DqWngw==", "7f197525-0d91-4889-8662-b3290af12b87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c7ee887-281b-4262-a10f-a1872c4e2f08",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8ee68c4-a924-4d9b-8f3b-6f5e77a7c6da", false, "AQAAAAEAACcQAAAAEKrtY/BAdlxskMIThJJQQoCcLiEOss0gKgbpbLVgHrbszARv6WZKoQSF3vgidVbV6g==", "6cc0d352-322a-4a52-9ff4-8f618c1b19c6" });
        }
    }
}
