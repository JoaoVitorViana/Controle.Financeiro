﻿// <auto-generated />
using System;
using ControleFinanceiro.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ControleFinanceiro.API.Migrations
{
    [DbContext(typeof(ControleContext))]
    partial class ControleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.5.22302.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ControleFinanceiro.API.Models.Cartao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.HasKey("Id");

                    b.ToTable("cartao");
                });

            modelBuilder.Entity("ControleFinanceiro.API.Models.Despesa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Ano")
                        .HasColumnType("integer")
                        .HasColumnName("ano");

                    b.Property<DateTime?>("Data")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dataHora");

                    b.Property<int?>("IdCartao")
                        .HasColumnType("integer")
                        .HasColumnName("idCartao");

                    b.Property<int>("Mes")
                        .HasColumnType("integer")
                        .HasColumnName("mes");

                    b.Property<int?>("Parcela")
                        .HasColumnType("integer")
                        .HasColumnName("parcela");

                    b.Property<bool?>("Recorrente")
                        .HasColumnType("boolean")
                        .HasColumnName("recorrente");

                    b.Property<int?>("TotalParcela")
                        .HasColumnType("integer")
                        .HasColumnName("totalParcela");

                    b.Property<decimal?>("Valor")
                        .HasColumnType("numeric")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("IdCartao");

                    b.ToTable("despesa");
                });

            modelBuilder.Entity("ControleFinanceiro.API.Models.Despesa", b =>
                {
                    b.HasOne("ControleFinanceiro.API.Models.Cartao", "Cartao")
                        .WithMany()
                        .HasForeignKey("IdCartao");

                    b.Navigation("Cartao");
                });
#pragma warning restore 612, 618
        }
    }
}
