﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial1_2Aplicada2.Data;

namespace Parcial1_2Aplicada2.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("Parcial1_2Aplicada2.Models.Inscripciones", b =>
                {
                    b.Property<int>("InscripcionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Disponibles")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Limite")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Semestre")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(99);

                    b.Property<int>("Tomados")
                        .HasColumnType("INTEGER");

                    b.HasKey("InscripcionId");

                    b.ToTable("Inscripciones");
                });
#pragma warning restore 612, 618
        }
    }
}
