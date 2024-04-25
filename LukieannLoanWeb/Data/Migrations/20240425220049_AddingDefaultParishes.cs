using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LukieannLoanWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingDefaultParishes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Parishes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Clarendon" },
                    { 2, "Hanover" },
                    { 3, "Kingston" },
                    { 4, "Manchester" },
                    { 5, "Portland" },
                    { 6, "St Andrew" },
                    { 7, "St Ann" },
                    { 8, "Saint Catherine" },
                    { 9, "Saint Elizabeth" },
                    { 10, "Saint James" },
                    { 11, "Saint Mary" },
                    { 12, "St Thomas" },
                    { 13, "Trelawny" },
                    { 14, "Westmoreland" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parishes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be210b42-8689-4b84-833a-97dff99352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66b3c018-ae3f-4366-9bc4-cfca9b0d4226", "AQAAAAIAAYagAAAAEAauEIrjHGpu3FYpt5NZ2ztbujvkanAa+dKs7izQTxtrO7YkR9HVhPPWsVvq8guloQ==", "55cdc0b4-2861-40b1-ac59-840214cd5dcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf310b42-6529-8b84-831a-97dff74352c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64b0e6fb-2968-472c-a7ba-fa010672dbc3", "AQAAAAIAAYagAAAAELoD5rR7sN+VpivTGgP6/whu67rQIJ6i67v+UqLygmK/t/za9fOlBDIk8MeKMnSsCg==", "85973386-8c14-487e-880c-edffacc7d7ef" });
        }
    }
}
