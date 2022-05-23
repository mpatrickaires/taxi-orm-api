﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TaxiOrmApi.Context;

#nullable disable

namespace TaxiOrmApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220523163141_VeiculoEntity")]
    partial class VeiculoEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TaxiOrmApi.Models.FabricanteModel.Fabricante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)")
                        .HasColumnName("nome");

                    b.HasKey("Id")
                        .HasName("pk_fabricante");

                    b.ToTable("fabricante", (string)null);
                });

            modelBuilder.Entity("TaxiOrmApi.Models.ModeloModel.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FabricanteId")
                        .HasColumnType("integer")
                        .HasColumnName("fabricante_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)")
                        .HasColumnName("nome");

                    b.HasKey("Id")
                        .HasName("pk_modelo");

                    b.HasIndex("FabricanteId")
                        .HasDatabaseName("ix_modelo_fabricante_id");

                    b.ToTable("modelo", (string)null);
                });

            modelBuilder.Entity("TaxiOrmApi.Models.VeiculoModel.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Ano")
                        .HasColumnType("integer")
                        .HasColumnName("ano");

                    b.Property<int>("ModeloId")
                        .HasColumnType("integer")
                        .HasColumnName("modelo_id");

                    b.Property<string>("Renavam")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character(11)")
                        .HasColumnName("renavam")
                        .IsFixedLength();

                    b.HasKey("Id")
                        .HasName("pk_veiculo");

                    b.HasIndex("ModeloId")
                        .HasDatabaseName("ix_veiculo_modelo_id");

                    b.HasIndex("Renavam")
                        .IsUnique()
                        .HasDatabaseName("ix_veiculo_renavam");

                    b.ToTable("veiculo", (string)null);
                });

            modelBuilder.Entity("TaxiOrmApi.Models.ModeloModel.Modelo", b =>
                {
                    b.HasOne("TaxiOrmApi.Models.FabricanteModel.Fabricante", "Fabricante")
                        .WithMany("Modelos")
                        .HasForeignKey("FabricanteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_modelo_fabricante_fabricante_id");

                    b.Navigation("Fabricante");
                });

            modelBuilder.Entity("TaxiOrmApi.Models.VeiculoModel.Veiculo", b =>
                {
                    b.HasOne("TaxiOrmApi.Models.ModeloModel.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_veiculo_modelo_modelo_id");

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("TaxiOrmApi.Models.FabricanteModel.Fabricante", b =>
                {
                    b.Navigation("Modelos");
                });
#pragma warning restore 612, 618
        }
    }
}