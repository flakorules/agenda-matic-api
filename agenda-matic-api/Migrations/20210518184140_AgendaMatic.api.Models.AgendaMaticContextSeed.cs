using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaMatic.api.Migrations
{
    public partial class AgendaMaticapiModelsAgendaMaticContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentDate", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, new DateTime(2021, 5, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, new DateTime(2021, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, new DateTime(2021, 5, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, new DateTime(2021, 5, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, new DateTime(2021, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, new DateTime(2021, 5, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, new DateTime(2021, 5, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, new DateTime(2021, 5, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, new DateTime(2021, 5, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, new DateTime(2021, 5, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, new DateTime(2021, 5, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, new DateTime(2021, 5, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, new DateTime(2021, 5, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[,]
                {
                    { 1, "flakorules@gmail.com", "123456" },
                    { 2, "gbustamante@chilesystems.com", "123456" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, new DateTime(2021, 5, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, new DateTime(2021, 5, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2021, 5, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, new DateTime(2021, 5, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, new DateTime(2021, 5, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
