using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LukieannLoanWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingStatusIdToLoanRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoanStatusId",
                table: "LoanRequests",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65cc2976-0075-4f53-9b6b-f761b94f98b5", "AQAAAAIAAYagAAAAEHL9te/7vl3WdV1T0omV7rWPW2igLOZckdpROSL2MTjrwLTlv/zazjCz+inDCVD2ng==", "cd2f1a7d-6373-4c0f-a3f9-b845ed0a313e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1427d570-48fa-4baa-ab23-1f1f5fe8fb5e", "AQAAAAIAAYagAAAAEKKdkP0wMURdwUl+bHzHK9aefhiZZwodbhUElO4zyJcseyoKF3+lN80VZceFOrpMJQ==", "4d02c338-e9ce-45cb-ab73-280729b53317" });

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequests_LoanStatusId",
                table: "LoanRequests",
                column: "LoanStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanRequests_LoanStatuses_LoanStatusId",
                table: "LoanRequests",
                column: "LoanStatusId",
                principalTable: "LoanStatuses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanRequests_LoanStatuses_LoanStatusId",
                table: "LoanRequests");

            migrationBuilder.DropIndex(
                name: "IX_LoanRequests_LoanStatusId",
                table: "LoanRequests");

            migrationBuilder.DropColumn(
                name: "LoanStatusId",
                table: "LoanRequests");

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
        }
    }
}
