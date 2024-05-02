using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LukieannLoanWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultLoanTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "LoanRequests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e74233a2-cffd-4af6-9c4d-6cfd54d93dc3", "AQAAAAIAAYagAAAAECqtVQ+aLhMErepmCmwYos5zu3COm2NjZc22hlpcD6ro+oDe0m3u+0QbZQ1ZPUfs8Q==", "188f4d4c-7182-490e-874f-8baf6b1c7757" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc511b42-6729-8b84-831a-97dff74352c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31d6684b-0a22-47a2-b82b-0db03b749ed4", "AQAAAAIAAYagAAAAELTOQVhGSbExm8nQ3sGJAkHjC5slpCq8lm0a5s0FqF0x1QV48bylyf8MWxPaWnj7sQ==", "a88121d8-7389-4318-9a26-e797e7b68c9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b854b7d-dc1f-4a57-9701-6dd6e2d4756e", "AQAAAAIAAYagAAAAEP/IfGFwLshtJvLMXyCNZEOagOn/9mtNbQSFZ8xqxnybuBCSd334DzkB17Wd8GwcLg==", "92434598-ed2b-4297-8fe6-34ed891377c7" });

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequests_UserId",
                table: "LoanRequests",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanRequests_AspNetUsers_UserId",
                table: "LoanRequests",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.InsertData(
                table: "LoanTypes",
                columns: new[] { "Id", "Name", "Interest" },
                values: new object[,]
                {
                    { 1, "Personal Loan", 25 },
                    { 2, "Auto Loan", 10 },
                    { 3, "Mortgage Loan", 6 },
                    { 4, "Student Loan", 12 },
                    { 5, "Pay Day Loan", 40 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LoanTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LoanTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LoanTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LoanTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LoanTypes",
                keyColumn: "Id",
                keyValue: 5);


            migrationBuilder.DropForeignKey(
                name: "FK_LoanRequests_AspNetUsers_UserId",
                table: "LoanRequests");

            migrationBuilder.DropIndex(
                name: "IX_LoanRequests_UserId",
                table: "LoanRequests");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "LoanRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dad9b81d-d931-4b98-8285-c09db7d88b9d", "AQAAAAIAAYagAAAAEPErn0hzjvIEpx5ZlApVlbg1T+Ws3JnriwK18CKM7ONo4UHWMTt/5enbupeYRTmxWQ==", "c2ec1ffa-eb1d-4544-81d5-78a70d9660e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc511b42-6729-8b84-831a-97dff74352c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9e2ea78-b2ed-43b2-b827-a975640559c7", "AQAAAAIAAYagAAAAENzj8ds0RdZhkHjJe9PmPr/lvruRWfpCvJnBq7xqCZa34Pj0kjzjC/B101EYojwyiA==", "6d5e0dfd-2c6b-45ea-b1f2-255c071fafdf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "439bd8cd-3152-4c45-b8b0-c7e44b7605b2", "AQAAAAIAAYagAAAAEK68+S6NDvmi3kUVxnnnLu2tNYUR8neD9nPTXO9Gj3lXx0thx2KMm/pPuPRZYv0RVw==", "5ce182ed-f12a-4b87-98ec-63ecaf62815a" });
        }
    }
}
