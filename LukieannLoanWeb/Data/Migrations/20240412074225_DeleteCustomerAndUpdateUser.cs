using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LukieannLoanWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeleteCustomerAndUpdateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanRequests_Customers_CustomerID",
                table: "LoanRequests");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_LoanRequests_CustomerID",
                table: "LoanRequests");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "LoanRequests");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "LoanRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParishId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dr210b42 - 8523 - 4b74 - 783a - 97dff66342c5",
                column: "Name",
                value: "User");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5",
                columns: new[] { "Address1", "Address2", "City", "ConcurrencyStamp", "DateOfBirth", "ParishId", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, null, null, "889ceca3-ce29-40a4-99ce-8957b0fad308", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "AQAAAAIAAYagAAAAEEIN0u9Oc+cKO3eMJiwoctp7t8LwX6bZVjwlpSyQkKaW4RXV6gVKQDcyr7NWYQSgIw==", "9a6d6335-7e94-40fa-807c-9b50c411dcb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5",
                columns: new[] { "Address1", "Address2", "City", "ConcurrencyStamp", "DateOfBirth", "ParishId", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, null, null, "34a93b92-2b9c-460d-bfcd-d166c23673a3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "AQAAAAIAAYagAAAAEI+twKT3we/DUTKY2oTTE8LWDs7lNzo1gMtAH2L5gJP1u5e62C+kerz1e29Ec5t2hg==", "042c77b8-11f6-4069-9353-05225fee4466" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ParishId",
                table: "AspNetUsers",
                column: "ParishId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Parishes_ParishId",
                table: "AspNetUsers",
                column: "ParishId",
                principalTable: "Parishes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Parishes_ParishId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ParishId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LoanRequests");

            migrationBuilder.DropColumn(
                name: "Address1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ParishId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "LoanRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParishId = table.Column<int>(type: "int", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Parishes_ParishId",
                        column: x => x.ParishId,
                        principalTable: "Parishes",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dr210b42 - 8523 - 4b74 - 783a - 97dff66342c5",
                column: "Name",
                value: "user");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f56f943-6bf1-472b-944d-8cadf55733b7", null, "AQAAAAIAAYagAAAAEDEMP1/rSU7S07o7mJaRdcQro/o1ta4TmkL3grN4wc0i8cAN+fpVNHI+yooHrxRXRQ==", "4fe83248-e59c-49fc-a37e-54381a90abda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84640276-d8bf-4ead-862d-75e590a4766a", null, "AQAAAAIAAYagAAAAEN9zt/B1NV0Fj5iDMCFRha3fh91GzlglPfh6fOcNWQw3x0baO/WSFjT5WQ7tUeUgcA==", "7d3cb33f-5353-4749-9dd4-478e89a40231" });

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequests_CustomerID",
                table: "LoanRequests",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ParishId",
                table: "Customers",
                column: "ParishId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanRequests_Customers_CustomerID",
                table: "LoanRequests",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
