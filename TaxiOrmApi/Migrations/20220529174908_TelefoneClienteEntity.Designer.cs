﻿// <auto-generated />
using System;
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
    [Migration("20220529174908_TelefoneClienteEntity")]
    partial class TelefoneClienteEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TaxiOrmApi.Models.ClienteModel.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character(11)")
                        .HasColumnName("cpf")
                        .IsFixedLength();

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_cadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)")
                        .HasColumnName("nome");

                    b.HasKey("Id")
                        .HasName("pk_cliente");

                    b.HasIndex("Cpf")
                        .IsUnique()
                        .HasDatabaseName("ix_cliente_cpf");

                    b.ToTable("cliente", (string)null);
                });

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

            modelBuilder.Entity("TaxiOrmApi.Models.MotoristaModel.Motorista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character(11)")
                        .HasColumnName("cpf")
                        .IsFixedLength();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character(60)")
                        .HasColumnName("nome")
                        .IsFixedLength();

                    b.Property<string>("NumeroCnh")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character(11)")
                        .HasColumnName("numero_cnh")
                        .IsFixedLength();

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("integer")
                        .HasColumnName("veiculo_id");

                    b.HasKey("Id")
                        .HasName("pk_motorista");

                    b.HasIndex("Cpf")
                        .IsUnique()
                        .HasDatabaseName("ix_motorista_cpf");

                    b.HasIndex("NumeroCnh")
                        .IsUnique()
                        .HasDatabaseName("ix_motorista_numero_cnh");

                    b.HasIndex("VeiculoId")
                        .IsUnique()
                        .HasDatabaseName("ix_motorista_veiculo_id");

                    b.ToTable("motorista", (string)null);
                });

            modelBuilder.Entity("TaxiOrmApi.Models.TelefoneClienteModel.TelefoneCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("integer")
                        .HasColumnName("cliente_id");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("numero");

                    b.HasKey("Id")
                        .HasName("pk_telefone_cliente");

                    b.HasIndex("ClienteId")
                        .HasDatabaseName("ix_telefone_cliente_cliente_id");

                    b.ToTable("telefone_cliente", (string)null);
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

            modelBuilder.Entity("TaxiOrmApi.Models.MotoristaModel.Motorista", b =>
                {
                    b.HasOne("TaxiOrmApi.Models.VeiculoModel.Veiculo", "Veiculo")
                        .WithOne("Motorista")
                        .HasForeignKey("TaxiOrmApi.Models.MotoristaModel.Motorista", "VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_motorista_veiculo_veiculo_id");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("TaxiOrmApi.Models.TelefoneClienteModel.TelefoneCliente", b =>
                {
                    b.HasOne("TaxiOrmApi.Models.ClienteModel.Cliente", "Cliente")
                        .WithMany("Telefones")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_telefone_cliente_cliente_cliente_id");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("TaxiOrmApi.Models.VeiculoModel.Veiculo", b =>
                {
                    b.HasOne("TaxiOrmApi.Models.ModeloModel.Modelo", "Modelo")
                        .WithMany("Veiculos")
                        .HasForeignKey("ModeloId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_veiculo_modelo_modelo_id");

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("TaxiOrmApi.Models.ClienteModel.Cliente", b =>
                {
                    b.Navigation("Telefones");
                });

            modelBuilder.Entity("TaxiOrmApi.Models.FabricanteModel.Fabricante", b =>
                {
                    b.Navigation("Modelos");
                });

            modelBuilder.Entity("TaxiOrmApi.Models.ModeloModel.Modelo", b =>
                {
                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("TaxiOrmApi.Models.VeiculoModel.Veiculo", b =>
                {
                    b.Navigation("Motorista");
                });
#pragma warning restore 612, 618
        }
    }
}
