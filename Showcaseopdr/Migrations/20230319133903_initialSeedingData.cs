using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Showcaseopdr.Migrations
{
    /// <inheritdoc />
    public partial class initialSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskNumberId", "Date", "EndTime", "Present", "StartTime", "TaskName" },
                values: new object[] { 1, new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), "Test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskNumberId",
                keyValue: 1);
        }
    }
}
