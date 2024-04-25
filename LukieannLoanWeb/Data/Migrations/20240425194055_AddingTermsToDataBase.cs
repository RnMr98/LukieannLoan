using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LukieannLoanWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingTermsToDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanRequests_LoanTerms_LoanTermID",
                table: "LoanRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanRequests_LoanTypes_LoanTypeId",
                table: "LoanRequests");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Parishes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LoanTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Interest",
                table: "LoanTypes",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Term",
                table: "LoanTerms",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "LoanStatuses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "LoanRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "LoanTypeId",
                table: "LoanRequests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LoanTermID",
                table: "LoanRequests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "LoanRequests",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

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


            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "MiddleName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b483949d-2d37-4edd-9546-ec6718f7474a", null, null, "AQAAAAIAAYagAAAAEOGcAWRkwi45XOgkm/d0pBW7aHyHoHGvQgGA6o5c0ySXXgyJtL5V+RV/IplU9xaojw==", "25417361-45a9-47e1-af85-bb6faa70e9c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "MiddleName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31ef3f13-627a-420e-9ce4-7982a8236197", null, null, "AQAAAAIAAYagAAAAEHTKgvM9Nlcl1TLpsV5FJoqElG0wk1ieHVj+wfrC5nDrugi/Ty8zHGvRJIRBauGAUA==", "20d3bf59-ba5a-49bd-8327-391f3ab23325" });

            migrationBuilder.InsertData(
                table: "LoanTerms",
                columns: new[] { "Id", "Term" },
                values: new object[,]
                {
                    { 1, 3m },
                    { 2, 6m },
                    { 3, 12m },
                    { 4, 18m },
                    { 5, 12m },
                    { 6, 30m },
                    { 7, 36m },
                    { 8, 48m },
                    { 9, 60m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_LoanRequests_LoanTerms_LoanTermID",
                table: "LoanRequests",
                column: "LoanTermID",
                principalTable: "LoanTerms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanRequests_LoanTypes_LoanTypeId",
                table: "LoanRequests",
                column: "LoanTypeId",
                principalTable: "LoanTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanRequests_LoanTerms_LoanTermID",
                table: "LoanRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanRequests_LoanTypes_LoanTypeId",
                table: "LoanRequests");

            migrationBuilder.DeleteData(
                table: "LoanTerms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LoanTerms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LoanTerms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LoanTerms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LoanTerms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LoanTerms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LoanTerms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LoanTerms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LoanTerms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Parishes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LoanTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Interest",
                table: "LoanTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Term",
                table: "LoanTerms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "LoanStatuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "LoanRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LoanTypeId",
                table: "LoanRequests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LoanTermID",
                table: "LoanRequests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "LoanRequests",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "896b3186-9072-446c-9acd-9eb6729be15f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAEGQXodJv9y1oA/OFXgXaE8EMtqYZV/FSM6V0Sgwdw7R4Ilgl8SeqpwLJiTiHxAdGuQ==", "7fe31b6a-35f4-4d0a-8751-61d05fd3a252" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e51b23f8-a4d0-4831-bdb3-f31712e82cde", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAEH9vFEZpQrQSfeITXSvsKc5bjUtO2kmQh4u3O7IWRt6eTltHac5BA1/V3mL9UDkXmw==", "1356985e-f30a-4a92-8f49-382560d05ac9" });

            migrationBuilder.AddForeignKey(
                name: "FK_LoanRequests_LoanTerms_LoanTermID",
                table: "LoanRequests",
                column: "LoanTermID",
                principalTable: "LoanTerms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanRequests_LoanTypes_LoanTypeId",
                table: "LoanRequests",
                column: "LoanTypeId",
                principalTable: "LoanTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
