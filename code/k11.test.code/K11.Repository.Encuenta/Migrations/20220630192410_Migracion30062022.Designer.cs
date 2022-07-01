﻿// <auto-generated />
using System;
using K11.Repository.Encuenta.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace K11.Repository.Encuenta.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220630192410_Migracion30062022")]
    partial class Migracion30062022
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("K11.Repository.Encuenta.Entities.Encuestas", b =>
                {
                    b.Property<int>("IdEncuesta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCrea")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModifica")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioCrea")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioModifica")
                        .HasColumnType("int");

                    b.HasKey("IdEncuesta");

                    b.ToTable("Encuestas", "trsobj");
                });

            modelBuilder.Entity("K11.Repository.Encuenta.Entities.PreguntasEncuestas", b =>
                {
                    b.Property<int>("IdPreguntaEncuesta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCrea")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModifica")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEncuesta")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioCrea")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioModifica")
                        .HasColumnType("int");

                    b.HasKey("IdPreguntaEncuesta");

                    b.HasIndex("IdEncuesta");

                    b.ToTable("PreguntasEncuestas", "trsobj");
                });

            modelBuilder.Entity("K11.Repository.Encuenta.Entities.RespuestasEncuestas", b =>
                {
                    b.Property<int>("IdRespuestaEncuenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionRespuesta")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCrea")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModifica")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdPreguntaEncuesta")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioCrea")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioModifica")
                        .HasColumnType("int");

                    b.HasKey("IdRespuestaEncuenta");

                    b.HasIndex("IdPreguntaEncuesta");

                    b.ToTable("RespuestasEncuestas", "trsobj");
                });

            modelBuilder.Entity("K11.Repository.Encuenta.Entities.PreguntasEncuestas", b =>
                {
                    b.HasOne("K11.Repository.Encuenta.Entities.Encuestas", "Encuestas")
                        .WithMany("PreguntasEncuestas")
                        .HasForeignKey("IdEncuesta")
                        .IsRequired();

                    b.Navigation("Encuestas");
                });

            modelBuilder.Entity("K11.Repository.Encuenta.Entities.RespuestasEncuestas", b =>
                {
                    b.HasOne("K11.Repository.Encuenta.Entities.PreguntasEncuestas", "PreguntasEncuestas")
                        .WithMany("RespuestasEncuestas")
                        .HasForeignKey("IdPreguntaEncuesta")
                        .IsRequired();

                    b.Navigation("PreguntasEncuestas");
                });

            modelBuilder.Entity("K11.Repository.Encuenta.Entities.Encuestas", b =>
                {
                    b.Navigation("PreguntasEncuestas");
                });

            modelBuilder.Entity("K11.Repository.Encuenta.Entities.PreguntasEncuestas", b =>
                {
                    b.Navigation("RespuestasEncuestas");
                });
#pragma warning restore 612, 618
        }
    }
}
