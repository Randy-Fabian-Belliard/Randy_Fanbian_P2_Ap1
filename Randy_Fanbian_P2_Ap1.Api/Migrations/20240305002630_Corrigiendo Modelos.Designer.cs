﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Randy_Fanbian_P2_Ap1.Api.DAL;

#nullable disable

namespace Randy_Fanbian_P2_Ap1.Api.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240305002630_Corrigiendo Modelos")]
    partial class CorrigiendoModelos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Randy_Fanbian_P2_Ap1.Models.Accesorios", b =>
                {
                    b.Property<int>("AccesorioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccesorioId");

                    b.ToTable("Accesorios");

                    b.HasData(
                        new
                        {
                            AccesorioId = 1,
                            Descripcion = "Camara Tracera"
                        },
                        new
                        {
                            AccesorioId = 2,
                            Descripcion = "Pantalla interior"
                        },
                        new
                        {
                            AccesorioId = 3,
                            Descripcion = "Interior en piel"
                        },
                        new
                        {
                            AccesorioId = 4,
                            Descripcion = "Sun Roof"
                        },
                        new
                        {
                            AccesorioId = 5,
                            Descripcion = "Aros de lujo"
                        });
                });

            modelBuilder.Entity("Randy_Fanbian_P2_Ap1.Models.Vehiculo", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Gasto")
                        .HasColumnType("TEXT");

                    b.HasKey("VehiculoId");

                    b.ToTable("Vehiculo");
                });

            modelBuilder.Entity("Randy_Fanbian_P2_Ap1.Models.VehiculoDetalle", b =>
                {
                    b.Property<int>("VehiculoDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccesorioId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("VehiculoDetalleId");

                    b.HasIndex("AccesorioId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("VehiculoDetalle");
                });

            modelBuilder.Entity("Randy_Fanbian_P2_Ap1.Models.VehiculoDetalle", b =>
                {
                    b.HasOne("Randy_Fanbian_P2_Ap1.Models.Accesorios", null)
                        .WithMany("VehiculoDetalle")
                        .HasForeignKey("AccesorioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Randy_Fanbian_P2_Ap1.Models.Vehiculo", null)
                        .WithMany("VehiculoDetalle")
                        .HasForeignKey("VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Randy_Fanbian_P2_Ap1.Models.Accesorios", b =>
                {
                    b.Navigation("VehiculoDetalle");
                });

            modelBuilder.Entity("Randy_Fanbian_P2_Ap1.Models.Vehiculo", b =>
                {
                    b.Navigation("VehiculoDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
