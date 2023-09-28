using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dentist.Migrations
{
    /// <inheritdoc />
    public partial class addappointmentandshedulev3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_AspNetUsers_DocotrId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_AspNetUsers_patientId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_AspNetUsers_DocotrId",
                table: "Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment");

            migrationBuilder.RenameTable(
                name: "Schedule",
                newName: "Schedules");

            migrationBuilder.RenameTable(
                name: "Appointment",
                newName: "Appointments");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_DocotrId",
                table: "Schedules",
                newName: "IX_Schedules_DocotrId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_patientId",
                table: "Appointments",
                newName: "IX_Appointments_patientId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_DocotrId",
                table: "Appointments",
                newName: "IX_Appointments_DocotrId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_DocotrId",
                table: "Appointments",
                column: "DocotrId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_patientId",
                table: "Appointments",
                column: "patientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_AspNetUsers_DocotrId",
                table: "Schedules",
                column: "DocotrId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_DocotrId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_patientId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_AspNetUsers_DocotrId",
                table: "Schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Schedules",
                newName: "Schedule");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "Appointment");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_DocotrId",
                table: "Schedule",
                newName: "IX_Schedule_DocotrId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_patientId",
                table: "Appointment",
                newName: "IX_Appointment_patientId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_DocotrId",
                table: "Appointment",
                newName: "IX_Appointment_DocotrId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_AspNetUsers_DocotrId",
                table: "Appointment",
                column: "DocotrId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_AspNetUsers_patientId",
                table: "Appointment",
                column: "patientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_AspNetUsers_DocotrId",
                table: "Schedule",
                column: "DocotrId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
