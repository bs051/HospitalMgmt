﻿// <auto-generated />
using System;
using HospitalMgmt.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalMgmt.Migrations
{
    [DbContext(typeof(HospitalMgmtContext))]
    [Migration("20201210051937_HospitalMgmt")]
    partial class HospitalMgmt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalMgmt.Models.Appointments", b =>
                {
                    b.Property<int>("Appointment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Doctor_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patient_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Appointment_Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("HospitalMgmt.Models.Doctor", b =>
                {
                    b.Property<int>("Doctor_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Availability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Patient_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Patient_objPatient_Id")
                        .HasColumnType("int");

                    b.Property<string>("Specialists")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Doctor_Id");

                    b.HasIndex("Patient_objPatient_Id");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("HospitalMgmt.Models.Medicines", b =>
                {
                    b.Property<int>("Medicine_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Disease")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Doctor_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Doctor_objDoctor_Id")
                        .HasColumnType("int");

                    b.Property<string>("Medicine_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Medicine_Id");

                    b.HasIndex("Doctor_objDoctor_Id");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("HospitalMgmt.Models.PatientDetails", b =>
                {
                    b.Property<int>("Patient_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Appointment_objAppointment_Id")
                        .HasColumnType("int");

                    b.Property<int>("Appointments_ID")
                        .HasColumnType("int");

                    b.Property<string>("Patient_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patient_Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patient_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patient_Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patient_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Patient_Id");

                    b.HasIndex("Appointment_objAppointment_Id");

                    b.ToTable("PatientDetails");
                });

            modelBuilder.Entity("HospitalMgmt.Models.Doctor", b =>
                {
                    b.HasOne("HospitalMgmt.Models.PatientDetails", "Patient_obj")
                        .WithMany()
                        .HasForeignKey("Patient_objPatient_Id");
                });

            modelBuilder.Entity("HospitalMgmt.Models.Medicines", b =>
                {
                    b.HasOne("HospitalMgmt.Models.Doctor", "Doctor_obj")
                        .WithMany()
                        .HasForeignKey("Doctor_objDoctor_Id");
                });

            modelBuilder.Entity("HospitalMgmt.Models.PatientDetails", b =>
                {
                    b.HasOne("HospitalMgmt.Models.Appointments", "Appointment_obj")
                        .WithMany()
                        .HasForeignKey("Appointment_objAppointment_Id");
                });
#pragma warning restore 612, 618
        }
    }
}
