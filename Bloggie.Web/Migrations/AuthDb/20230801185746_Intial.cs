using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class Intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69875565-188f-483b-a978-40ae3d7b35aa", "AQAAAAIAAYagAAAAEA1Vzhntz7Q8DHN/0GMGrROZZtYx8iMLjskxGb3A2g3FSEXdZp19hIlX9tZMYWa0DA==", "8913edd2-9c44-4ae3-a23a-c878cb423fb5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b34b502-4d24-418c-9685-6ecc5b92f84a", "AQAAAAIAAYagAAAAED0HnnZg5BTzC6vBfWoRQNScX55RM0YMARMiwWfa81uBIz2aND0ptZSVN7KM8lJr/g==", "c2714ebb-1ea6-4679-ae35-3379f866210e" });
        }
    }
}
