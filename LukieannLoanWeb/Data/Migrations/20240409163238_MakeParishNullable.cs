﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LukieannLoanWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakeParishNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Parishes_ParishId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "ParishId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Parishes_ParishId",
                table: "Customers",
                column: "ParishId",
                principalTable: "Parishes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Parishes_ParishId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "ParishId",
                table: "Customers",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Parishes_ParishId",
                table: "Customers",
                column: "ParishId",
                principalTable: "Parishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
