using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Coordinator.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("478ce80e-2575-490c-a89f-41fd4dca2004"), "Order.API" },
                    { new Guid("be105094-a24d-4cc4-850b-af18c023ad84"), "Stock.API" },
                    { new Guid("df556ba7-de0a-421b-a781-f5dec43cc99c"), "Payment.API" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("478ce80e-2575-490c-a89f-41fd4dca2004"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("be105094-a24d-4cc4-850b-af18c023ad84"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("df556ba7-de0a-421b-a781-f5dec43cc99c"));
        }
    }
}
