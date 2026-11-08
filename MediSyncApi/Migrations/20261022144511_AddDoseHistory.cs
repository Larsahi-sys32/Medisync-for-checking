using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediSyncApi.Migrations
{
    /// <inheritdoc />
    public partial class AddDoseHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoseHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MedicineId = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicineName = table.Column<string>(type: "TEXT", nullable: false),
                    ScheduledTime = table.Column<string>(type: "TEXT", nullable: false),
                    DoseDate = table.Column<string>(type: "TEXT", nullable: false),
                    IsTaken = table.Column<bool>(type: "INTEGER", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoseHistories", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoseHistories");
        }
    }
}
