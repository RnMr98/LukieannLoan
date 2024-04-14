using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LukieannLoanWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakeParishAList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Parishes_ParishId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ParishId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Parishes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parishes_CustomerId",
                table: "Parishes",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parishes_Customers_CustomerId",
                table: "Parishes",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parishes_Customers_CustomerId",
                table: "Parishes");

            migrationBuilder.DropIndex(
                name: "IX_Parishes_CustomerId",
                table: "Parishes");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Parishes");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ParishId",
                table: "Customers",
                column: "ParishId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Parishes_ParishId",
                table: "Customers",
                column: "ParishId",
                principalTable: "Parishes",
                principalColumn: "Id");
        }
    }
}
