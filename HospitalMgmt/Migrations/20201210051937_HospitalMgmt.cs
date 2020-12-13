using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalMgmt.Migrations
{
    public partial class HospitalMgmt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Appointment_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_Name = table.Column<string>(nullable: true),
                    Doctor_Name = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Appointment_Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientDetails",
                columns: table => new
                {
                    Patient_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_Name = table.Column<string>(nullable: true),
                    Patient_Address = table.Column<string>(nullable: true),
                    Patient_Mobile = table.Column<string>(nullable: true),
                    Patient_Email = table.Column<string>(nullable: true),
                    Patient_Age = table.Column<string>(nullable: true),
                    Appointments_ID = table.Column<int>(nullable: false),
                    Appointment_objAppointment_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDetails", x => x.Patient_Id);
                    table.ForeignKey(
                        name: "FK_PatientDetails_Appointments_Appointment_objAppointment_Id",
                        column: x => x.Appointment_objAppointment_Id,
                        principalTable: "Appointments",
                        principalColumn: "Appointment_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Doctor_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doctor_Name = table.Column<string>(nullable: true),
                    Specialists = table.Column<string>(nullable: true),
                    Availability = table.Column<string>(nullable: true),
                    Patient_ID = table.Column<int>(nullable: false),
                    Patient_objPatient_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Doctor_Id);
                    table.ForeignKey(
                        name: "FK_Doctor_PatientDetails_Patient_objPatient_Id",
                        column: x => x.Patient_objPatient_Id,
                        principalTable: "PatientDetails",
                        principalColumn: "Patient_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Medicine_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicine_Name = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    Disease = table.Column<string>(nullable: true),
                    Doctor_ID = table.Column<int>(nullable: false),
                    Doctor_objDoctor_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Medicine_Id);
                    table.ForeignKey(
                        name: "FK_Medicines_Doctor_Doctor_objDoctor_Id",
                        column: x => x.Doctor_objDoctor_Id,
                        principalTable: "Doctor",
                        principalColumn: "Doctor_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Patient_objPatient_Id",
                table: "Doctor",
                column: "Patient_objPatient_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_Doctor_objDoctor_Id",
                table: "Medicines",
                column: "Doctor_objDoctor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDetails_Appointment_objAppointment_Id",
                table: "PatientDetails",
                column: "Appointment_objAppointment_Id");

            var sqlFile = Path.Combine(".\\DataScript", @"SQLQuery1.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "PatientDetails");

            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
