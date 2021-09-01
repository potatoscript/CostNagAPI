﻿// <auto-generated />
using CostNAG.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CostNAGAPI.Migrations
{
    [DbContext(typeof(CostDbContext))]
    [Migration("20210901022327_v2")]
    partial class v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CostNAGAPI.Models.Cost", b =>
                {
                    b.Property<int>("CostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("approved_by")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("business_type")
                        .HasColumnType("character varying(20)");

                    b.Property<string>("checked_date")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("customer")
                        .HasColumnType("character varying(20)");

                    b.Property<string>("doc_no")
                        .HasColumnType("character varying(20)");

                    b.Property<double>("exchange_rate")
                        .HasColumnType("double precision");

                    b.Property<string>("issue_date")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("item")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("item_spec")
                        .HasColumnType("character varying(20)");

                    b.Property<string>("parts_code")
                        .HasColumnType("character varying(15)");

                    b.Property<string>("plant")
                        .HasColumnType("character varying(5)");

                    b.Property<string>("product")
                        .HasColumnType("character varying(20)");

                    b.Property<string>("product_type")
                        .HasColumnType("character varying(10)");

                    b.Property<int>("production_qty_day")
                        .HasColumnType("integer");

                    b.Property<int>("qty_month")
                        .HasColumnType("integer");

                    b.Property<string>("revision_no")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("sales")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("section")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("size")
                        .HasColumnType("character varying(10)");

                    b.Property<double>("target_price_bht")
                        .HasColumnType("double precision");

                    b.Property<double>("target_price_export")
                        .HasColumnType("double precision");

                    b.Property<int>("working_day")
                        .HasColumnType("integer");

                    b.Property<string>("wr_no")
                        .HasColumnType("character varying(20)");

                    b.HasKey("CostId");

                    b.ToTable("Costs");
                });
#pragma warning restore 612, 618
        }
    }
}
