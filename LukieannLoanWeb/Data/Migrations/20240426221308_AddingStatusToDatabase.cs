using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LukieannLoanWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingStatusToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d71ed67-4ce1-4a1e-885c-34ddfad39291", "AQAAAAIAAYagAAAAEBr3Yzs2KENpZOIIU1xFrEPY7KdnZHgseTOfEQYd0WRgaUStT+taWhVSoO4S9+lmQQ==", "1f8f359e-4b7a-43db-9539-dd5e44abbffa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96479240-7200-4995-a142-d114c4ecaf91", "AQAAAAIAAYagAAAAEO68KRrJR3i5b3R0sSEG058QYcMPIjvZm/b8xTwc0hzh9MiF9+r7X/jOI56Ln5XVgQ==", "8ebd0121-0f1e-4881-8c76-76f706e106fa" });

            migrationBuilder.InsertData(
                table: "LoanStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Approved" },
                    { 3, "Cancelled" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LoanStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8711d6a0-de4a-42b5-8496-8531ea4dd156", "AQAAAAIAAYagAAAAEMfrZoQtYfhAJKx2PlY0Qlcnwv/jjMTt+kYtIYY5YWneDPVSSWckKG1HidHixJy85A==", "aac9891f-7743-4622-8d8f-15bdc5ac84f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47691091-f3f5-43d1-bac1-9ac0792a9777", "AQAAAAIAAYagAAAAEInN5zLBrJDtTP+2S0nXJ08rwmKp8HeNvcdWrrLiA5AAJauq3q2CibUg3pLQgEXsCg==", "586a6d50-4a6f-4d9b-9bda-c9de986835d4" });
        }
    }
}
