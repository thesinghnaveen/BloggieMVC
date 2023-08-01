using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b34b502-4d24-418c-9685-6ecc5b92f84a", "AQAAAAIAAYagAAAAED0HnnZg5BTzC6vBfWoRQNScX55RM0YMARMiwWfa81uBIz2aND0ptZSVN7KM8lJr/g==", "c2714ebb-1ea6-4679-ae35-3379f866210e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02dcd5f7-a690-45e5-95d4-d2706865a55a", "AQAAAAIAAYagAAAAEAv/okdecnfYm+tdXFAarHPtq8vkpGhFZQD+B7E9GrxWzpWmeOoLPvoad1NUUX8s7A==", "22993975-2e15-4a4e-9476-37b5ca1adbea" });
        }
    }
}
