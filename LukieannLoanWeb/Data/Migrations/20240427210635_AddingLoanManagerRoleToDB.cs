using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LukieannLoanWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingLoanManagerRoleToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dr226c42 - 8723 - 4a74 - 763a - 97dff65342b4", null, "Loan Manager", "LOAN MANAGER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dad9b81d-d931-4b98-8285-c09db7d88b9d", "AQAAAAIAAYagAAAAEPErn0hzjvIEpx5ZlApVlbg1T+Ws3JnriwK18CKM7ONo4UHWMTt/5enbupeYRTmxWQ==", "c2ec1ffa-eb1d-4544-81d5-78a70d9660e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "439bd8cd-3152-4c45-b8b0-c7e44b7605b2", "AQAAAAIAAYagAAAAEK68+S6NDvmi3kUVxnnnLu2tNYUR8neD9nPTXO9Gj3lXx0thx2KMm/pPuPRZYv0RVw==", "5ce182ed-f12a-4b87-98ec-63ecaf62815a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address1", "Address2", "City", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "ParishId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TRN", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cc511b42-6729-8b84-831a-97dff74352c4", 0, null, null, null, "e9e2ea78-b2ed-43b2-b827-a975640559c7", null, null, "loanManager@test.com", true, "Loan", "Manager", false, null, null, "LOANMANAGER@TEST.COM", "LOANMANAGER@TEST.COM", null, "AQAAAAIAAYagAAAAENzj8ds0RdZhkHjJe9PmPr/lvruRWfpCvJnBq7xqCZa34Pj0kjzjC/B101EYojwyiA==", null, false, "6d5e0dfd-2c6b-45ea-b1f2-255c071fafdf", null, false, "loanManager@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dr226c42 - 8723 - 4a74 - 763a - 97dff65342b4", "cc511b42-6729-8b84-831a-97dff74352c4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dr226c42 - 8723 - 4a74 - 763a - 97dff65342b4", "cc511b42-6729-8b84-831a-97dff74352c4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dr226c42 - 8723 - 4a74 - 763a - 97dff65342b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc511b42-6729-8b84-831a-97dff74352c4");

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
        }
    }
}
