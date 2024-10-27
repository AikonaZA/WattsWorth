using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WattsWorth.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SimplifiedSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ElectricityPurchases_TransactionId",
                table: "ElectricityPurchases");

            migrationBuilder.DropColumn(
                name: "Credit",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Debit",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "HourDifference",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "MinuteDifference",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "UnitCost",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "UnitDifference",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "UnitsPerHour",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Transactions");

            migrationBuilder.AlterColumn<decimal>(
                name: "Units",
                table: "Transactions",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TransactionDate",
                table: "ElectricityPurchases",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityPurchases_TransactionId",
                table: "ElectricityPurchases",
                column: "TransactionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ElectricityPurchases_TransactionId",
                table: "ElectricityPurchases");

            migrationBuilder.DropColumn(
                name: "TransactionDate",
                table: "ElectricityPurchases");

            migrationBuilder.AlterColumn<decimal>(
                name: "Units",
                table: "Transactions",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AddColumn<decimal>(
                name: "Credit",
                table: "Transactions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Debit",
                table: "Transactions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HourDifference",
                table: "Transactions",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinuteDifference",
                table: "Transactions",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "Transactions",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Transactions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitCost",
                table: "Transactions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitDifference",
                table: "Transactions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitsPerHour",
                table: "Transactions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityPurchases_TransactionId",
                table: "ElectricityPurchases",
                column: "TransactionId",
                unique: true);
        }
    }
}
