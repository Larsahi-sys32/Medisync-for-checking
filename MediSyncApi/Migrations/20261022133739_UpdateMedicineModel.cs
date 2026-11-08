using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediSyncApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMedicineModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dosage",
                table: "Medicines");

            migrationBuilder.RenameColumn(
                name: "ReminderTime",
                table: "Medicines",
                newName: "Times");

            migrationBuilder.RenameColumn(
                name: "Instructions",
                table: "Medicines",
                newName: "Notes");

            migrationBuilder.AddColumn<int>(
                name: "Qty",
                table: "Medicines",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qty",
                table: "Medicines");

            migrationBuilder.RenameColumn(
                name: "Times",
                table: "Medicines",
                newName: "ReminderTime");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Medicines",
                newName: "Instructions");

            migrationBuilder.AddColumn<string>(
                name: "Dosage",
                table: "Medicines",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
