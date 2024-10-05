﻿// <auto-generated />
using System;
using HealthMed.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HealthMed.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241005011459_MigrationHeathMedHorariosDisp")]
    partial class MigrationHeathMedHorariosDisp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HealthMed.Domain.Entities.HorariosDisponiveisMedicoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiaSemana")
                        .HasColumnType("int");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("HorarioFim")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HorarioInicio")
                        .HasColumnType("time");

                    b.Property<int>("MedicoId")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId", "DiaSemana", "HorarioInicio")
                        .IsUnique()
                        .HasDatabaseName("IX_Horarios_Medico_Dia_Horario");

                    b.ToTable("HM_HORARIOS_DISPONIVEIS", (string)null);
                });

            modelBuilder.Entity("HealthMed.Domain.Entities.MedicoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("VARCHAR(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("NumeroCrm")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<int>("Permissao")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("UfCrm")
                        .IsRequired()
                        .HasColumnType("VARCHAR(2)");

                    b.HasKey("Id");

                    b.ToTable("HM_MEDICO", (string)null);
                });

            modelBuilder.Entity("HealthMed.Domain.Entities.PacienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("VARCHAR(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("Permissao")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.HasKey("Id");

                    b.ToTable("HM_PACIENTE", (string)null);
                });

            modelBuilder.Entity("HealthMed.Domain.Entities.HorariosDisponiveisMedicoModel", b =>
                {
                    b.HasOne("HealthMed.Domain.Entities.MedicoModel", "Medico")
                        .WithMany("HorariosDisponiveis")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("HealthMed.Domain.Entities.MedicoModel", b =>
                {
                    b.Navigation("HorariosDisponiveis");
                });
#pragma warning restore 612, 618
        }
    }
}