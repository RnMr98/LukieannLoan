using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LukieannLoanWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUserAndRoleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bf210b42 - 6889 - 4b74 - 833a - 97dff66352c5", null, "Administrator", "ADMINISTRATOR" },
                    { "dr210b42 - 8523 - 4b74 - 783a - 97dff66342c5", null, "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TRN", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "be210b42-8689-4b84-833a-97dff99352c5", 0, "2f56f943-6bf1-472b-944d-8cadf55733b7", null, null, "admin@test.com", true, "System", "Admin", false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEDEMP1/rSU7S07o7mJaRdcQro/o1ta4TmkL3grN4wc0i8cAN+fpVNHI+yooHrxRXRQ==", null, false, "4fe83248-e59c-49fc-a37e-54381a90abda", null, false, "admin@test.com" },
                    { "cf310b42-6529-8b84-831a-97dff74352c5", 0, "84640276-d8bf-4ead-862d-75e590a4766a", null, null, "user@test.com", true, "Simple", "User", false, null, "USER@TEST.COM", "USER@TEST.COM", "AQAAAAIAAYagAAAAEN9zt/B1NV0Fj5iDMCFRha3fh91GzlglPfh6fOcNWQw3x0baO/WSFjT5WQ7tUeUgcA==", null, false, "7d3cb33f-5353-4749-9dd4-478e89a40231", null, false, "user@test.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bf210b42 - 6889 - 4b74 - 833a - 97dff66352c5", "be210b42-8689-4b84-833a-97dff99352c5" },
                    { "dr210b42 - 8523 - 4b74 - 783a - 97dff66342c5", "cf310b42-6529-8b84-831a-97dff74352c5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf210b42 - 6889 - 4b74 - 833a - 97dff66352c5", "be210b42-8689-4b84-833a-97dff99352c5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dr210b42 - 8523 - 4b74 - 783a - 97dff66342c5", "cf310b42-6529-8b84-831a-97dff74352c5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf210b42 - 6889 - 4b74 - 833a - 97dff66352c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dr210b42 - 8523 - 4b74 - 783a - 97dff66342c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5");
        }
    }
}
