﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationSeguros.Data;

namespace WebApplicationSeguros.Migrations
{
    [DbContext(typeof(DBContextInsurances))]
    [Migration("20220305205259_secondtMigration")]
    partial class secondtMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplicationSeguros.Models.CoverType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CoverTypes");
                });

            modelBuilder.Entity("WebApplicationSeguros.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebApplicationSeguros.Models.InsurancePolicy", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<decimal>("CoverPercent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("CoverTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CoveragePeriod")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NameCoverType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameTypeRisk")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PolicyPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDatePoliceValidity")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TypeRiskId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CoverTypeId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TypeRiskId");

                    b.ToTable("InsurancePolicies");
                });

            modelBuilder.Entity("WebApplicationSeguros.Models.TypeRisk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameRisk")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TypeRisks");
                });

            modelBuilder.Entity("WebApplicationSeguros.Models.InsurancePolicy", b =>
                {
                    b.HasOne("WebApplicationSeguros.Models.CoverType", "CoverType")
                        .WithMany()
                        .HasForeignKey("CoverTypeId");

                    b.HasOne("WebApplicationSeguros.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("WebApplicationSeguros.Models.TypeRisk", "TypeRisk")
                        .WithMany()
                        .HasForeignKey("TypeRiskId");

                    b.Navigation("CoverType");

                    b.Navigation("Customer");

                    b.Navigation("TypeRisk");
                });
#pragma warning restore 612, 618
        }
    }
}
