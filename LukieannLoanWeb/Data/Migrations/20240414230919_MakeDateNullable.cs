using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LukieannLoanWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakeDateNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "LoanRequests",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "896b3186-9072-446c-9acd-9eb6729be15f", "AQAAAAIAAYagAAAAEGQXodJv9y1oA/OFXgXaE8EMtqYZV/FSM6V0Sgwdw7R4Ilgl8SeqpwLJiTiHxAdGuQ==", "7fe31b6a-35f4-4d0a-8751-61d05fd3a252" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e51b23f8-a4d0-4831-bdb3-f31712e82cde", "AQAAAAIAAYagAAAAEH9vFEZpQrQSfeITXSvsKc5bjUtO2kmQh4u3O7IWRt6eTltHac5BA1/V3mL9UDkXmw==", "1356985e-f30a-4a92-8f49-382560d05ac9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "LoanRequests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "889ceca3-ce29-40a4-99ce-8957b0fad308", "AQAAAAIAAYagAAAAEEIN0u9Oc+cKO3eMJiwoctp7t8LwX6bZVjwlpSyQkKaW4RXV6gVKQDcyr7NWYQSgIw==", "9a6d6335-7e94-40fa-807c-9b50c411dcb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34a93b92-2b9c-460d-bfcd-d166c23673a3", "AQAAAAIAAYagAAAAEI+twKT3we/DUTKY2oTTE8LWDs7lNzo1gMtAH2L5gJP1u5e62C+kerz1e29Ec5t2hg==", "042c77b8-11f6-4069-9353-05225fee4466" });
        }
    }
}
