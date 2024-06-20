using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MypulseWebapi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatEPG17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Availabilities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SlotDuration = table.Column<int>(type: "integer", nullable: false),
                    PaymentCharges = table.Column<int>(type: "integer", nullable: false),
                    Timezone = table.Column<string>(type: "text", nullable: false),
                    MeetLocationId = table.Column<string>(type: "text", nullable: false),
                    PaymentStatus = table.Column<string>(type: "text", nullable: false),
                    AdditionalInstructions = table.Column<string>(type: "text", nullable: false),
                    MaxBookedSlots = table.Column<string>(type: "text", nullable: false),
                    AvailabilityJSON = table.Column<string>(type: "text", nullable: false),
                    ExcludedDateConfig = table.Column<string>(type: "text", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "text", nullable: false),
                    AppointmentModes = table.Column<int[]>(type: "integer[]", nullable: false),
                    BookingPeriod = table.Column<string>(type: "text", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: false),
                    ManagerID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Availabilities_Managers_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Availabilities_ManagerID",
                table: "Availabilities",
                column: "ManagerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Availabilities");
        }
    }
}
