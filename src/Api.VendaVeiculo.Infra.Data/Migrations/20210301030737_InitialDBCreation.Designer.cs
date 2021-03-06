﻿// <auto-generated />
using System;
using Api.VendaVeiculo.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.VendaVeiculo.Infra.Data.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20210301030737_InitialDBCreation")]
    partial class InitialDBCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Api.VendaVeiculo.Domain.Entities.Veiculo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("int")
                        .HasColumnName("ano_fabricacao");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("marca");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("modelo");

                    b.Property<int?>("Vendaid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Vendaid");

                    b.ToTable("veiculos");
                });

            modelBuilder.Entity("Api.VendaVeiculo.Domain.Entities.Venda", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2")
                        .HasColumnName("data");

                    b.Property<int>("IdVendedor")
                        .HasColumnType("int")
                        .HasColumnName("id_vendedor");

                    b.Property<int>("StatusVenda")
                        .HasColumnType("int")
                        .HasColumnName("status_venda");

                    b.HasKey("id");

                    b.ToTable("vendas");
                });

            modelBuilder.Entity("Api.VendaVeiculo.Domain.Entities.Vendedor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("id");

                    b.ToTable("vendedores");
                });

            modelBuilder.Entity("Api.VendaVeiculo.Domain.Entities.Veiculo", b =>
                {
                    b.HasOne("Api.VendaVeiculo.Domain.Entities.Venda", null)
                        .WithMany("Veiculo")
                        .HasForeignKey("Vendaid");
                });

            modelBuilder.Entity("Api.VendaVeiculo.Domain.Entities.Venda", b =>
                {
                    b.Navigation("Veiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
