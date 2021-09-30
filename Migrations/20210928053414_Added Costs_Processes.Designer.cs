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
    [Migration("20210928053414_Added Costs_Processes")]
    partial class AddedCosts_Processes
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

                    b.Property<double>("administration_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("administration_cost_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("administration_percentage")
                        .HasColumnType("double precision");

                    b.Property<string>("approved_by")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("business_type")
                        .HasColumnType("character varying(20)");

                    b.Property<string>("checked_date")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("customer")
                        .HasColumnType("character varying(20)");

                    b.Property<double>("defective_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("defective_cost_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("defective_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("die_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("die_cost_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("die_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("direct_material_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("direct_material_cost_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("direct_process_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("direct_process_cost_percentage")
                        .HasColumnType("double precision");

                    b.Property<string>("doc_no")
                        .HasColumnType("character varying(20)");

                    b.Property<double>("exchange_rate")
                        .HasColumnType("double precision");

                    b.Property<string>("expired_by")
                        .HasColumnType("character varying(10)");

                    b.Property<double>("indirect_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("indirect_cost_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("indirect_percentage")
                        .HasColumnType("double precision");

                    b.Property<string>("issue_date")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("item")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("item_spec")
                        .HasColumnType("character varying(20)");

                    b.Property<double>("material_inhouse_cost_sgd_1")
                        .HasColumnType("double precision");

                    b.Property<double>("material_inhouse_cost_sgd_2")
                        .HasColumnType("double precision");

                    b.Property<double>("material_inhouse_cost_sgd_3")
                        .HasColumnType("double precision");

                    b.Property<string>("material_inhouse_info_1")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("material_inhouse_info_1b")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("material_inhouse_info_2")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("material_inhouse_info_2b")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("material_inhouse_info_3")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("material_inhouse_info_3b")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("material_inhouse_name_1")
                        .HasColumnType("character varying(30)");

                    b.Property<string>("material_inhouse_name_2")
                        .HasColumnType("character varying(30)");

                    b.Property<string>("material_inhouse_name_3")
                        .HasColumnType("character varying(30)");

                    b.Property<double>("material_inhouse_percentage_target_price_1")
                        .HasColumnType("double precision");

                    b.Property<double>("material_inhouse_percentage_target_price_2")
                        .HasColumnType("double precision");

                    b.Property<double>("material_inhouse_percentage_target_price_3")
                        .HasColumnType("double precision");

                    b.Property<double>("material_inhouse_value_1")
                        .HasColumnType("double precision");

                    b.Property<double>("material_inhouse_value_1b")
                        .HasColumnType("double precision");

                    b.Property<double>("material_inhouse_value_2")
                        .HasColumnType("double precision");

                    b.Property<double>("material_inhouse_value_2b")
                        .HasColumnType("double precision");

                    b.Property<double>("material_inhouse_value_3")
                        .HasColumnType("double precision");

                    b.Property<double>("material_inhouse_value_3b")
                        .HasColumnType("double precision");

                    b.Property<double>("material_outside_cost_sgd_1")
                        .HasColumnType("double precision");

                    b.Property<double>("material_outside_cost_sgd_2")
                        .HasColumnType("double precision");

                    b.Property<double>("material_outside_cost_sgd_3")
                        .HasColumnType("double precision");

                    b.Property<string>("material_outside_info_1")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("material_outside_info_1b")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("material_outside_info_2")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("material_outside_info_2b")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("material_outside_info_3")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("material_outside_info_3b")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("material_outside_name_1")
                        .HasColumnType("character varying(30)");

                    b.Property<string>("material_outside_name_2")
                        .HasColumnType("character varying(30)");

                    b.Property<string>("material_outside_name_3")
                        .HasColumnType("character varying(30)");

                    b.Property<double>("material_outside_percentage_target_price_1")
                        .HasColumnType("double precision");

                    b.Property<double>("material_outside_percentage_target_price_2")
                        .HasColumnType("double precision");

                    b.Property<double>("material_outside_percentage_target_price_3")
                        .HasColumnType("double precision");

                    b.Property<double>("material_outside_value_1")
                        .HasColumnType("double precision");

                    b.Property<double>("material_outside_value_1b")
                        .HasColumnType("double precision");

                    b.Property<double>("material_outside_value_2")
                        .HasColumnType("double precision");

                    b.Property<double>("material_outside_value_2b")
                        .HasColumnType("double precision");

                    b.Property<double>("material_outside_value_3")
                        .HasColumnType("double precision");

                    b.Property<double>("material_outside_value_3b")
                        .HasColumnType("double precision");

                    b.Property<double>("moldjig_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("moldjig_cost_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("moldjig_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("net_exclude_tooling_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("net_exclude_tooling_cost_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("net_included_tooling_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("net_included_tooling_cost_percentage")
                        .HasColumnType("double precision");

                    b.Property<string>("note")
                        .HasColumnType("character varying(200)");

                    b.Property<double>("packing_material_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("packing_material_cost_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("packing_material_percentage")
                        .HasColumnType("double precision");

                    b.Property<string>("parts_code")
                        .HasColumnType("character varying(15)");

                    b.Property<string>("plant")
                        .HasColumnType("character varying(5)");

                    b.Property<double>("plant_retail_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("plant_retail_cost_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("plant_retail_percentage")
                        .HasColumnType("double precision");

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

                    b.Property<double>("rubber_cost_sgd")
                        .HasColumnType("double precision");

                    b.Property<double>("rubber_database_price_current")
                        .HasColumnType("double precision");

                    b.Property<double>("rubber_database_price_new")
                        .HasColumnType("double precision");

                    b.Property<string>("rubber_material_name")
                        .HasColumnType("character varying(10)");

                    b.Property<double>("rubber_mixing_process_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("rubber_percentage_target_price")
                        .HasColumnType("double precision");

                    b.Property<double>("rubber_price_kg")
                        .HasColumnType("double precision");

                    b.Property<double>("rubber_weight_g")
                        .HasColumnType("double precision");

                    b.Property<double>("rubber_weight_kg")
                        .HasColumnType("double precision");

                    b.Property<double>("rubber_weight_kg_yieldrate")
                        .HasColumnType("double precision");

                    b.Property<double>("rubber_yield_rate")
                        .HasColumnType("double precision");

                    b.Property<string>("sales")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("section")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("size")
                        .HasColumnType("character varying(10)");

                    b.Property<double>("special_package_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("sub_material_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("sub_material_cost_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("sub_material_percentage")
                        .HasColumnType("double precision");

                    b.Property<double>("target_price_bht")
                        .HasColumnType("double precision");

                    b.Property<double>("target_price_export")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_1")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_10")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_11")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_12")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_13")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_14")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_15")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_2")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_3")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_4")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_5")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_6")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_7")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_8")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_jpy_9")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_1")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_10")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_11")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_12")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_13")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_14")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_15")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_2")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_3")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_4")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_5")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_6")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_7")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_8")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_amount_usd_9")
                        .HasColumnType("double precision");

                    b.Property<string>("tooling_list_description_1")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_10")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_11")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_12")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_13")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_14")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_15")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_2")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_3")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_4")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_5")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_6")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_7")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_8")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("tooling_list_description_9")
                        .HasColumnType("character varying(50)");

                    b.Property<double>("tooling_list_price_1")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_10")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_11")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_12")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_13")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_14")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_15")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_2")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_3")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_4")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_5")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_6")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_7")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_8")
                        .HasColumnType("double precision");

                    b.Property<double>("tooling_list_price_9")
                        .HasColumnType("double precision");

                    b.Property<int>("tooling_list_qty_1")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_10")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_11")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_12")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_13")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_14")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_15")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_2")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_3")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_4")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_5")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_6")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_7")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_8")
                        .HasColumnType("integer");

                    b.Property<int>("tooling_list_qty_9")
                        .HasColumnType("integer");

                    b.Property<string>("tooling_list_source_1")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_10")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_11")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_12")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_13")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_14")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_15")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_2")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_3")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_4")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_5")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_6")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_7")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_8")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_source_9")
                        .HasColumnType("character varying(10)");

                    b.Property<double>("tooling_list_total_amount_usd")
                        .HasColumnType("double precision");

                    b.Property<string>("tooling_list_type_1")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_10")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_11")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_12")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_13")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_14")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_15")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_2")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_3")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_4")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_5")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_6")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_7")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_8")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_type_9")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_1")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_10")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_11")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_12")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_13")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_14")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_15")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_2")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_3")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_4")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_5")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_6")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_7")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_8")
                        .HasColumnType("character varying(10)");

                    b.Property<string>("tooling_list_unit_9")
                        .HasColumnType("character varying(10)");

                    b.Property<double>("total_direct_cost")
                        .HasColumnType("double precision");

                    b.Property<double>("total_direct_cost_percentage")
                        .HasColumnType("double precision");

                    b.Property<int>("working_day")
                        .HasColumnType("integer");

                    b.Property<string>("wr_no")
                        .HasColumnType("character varying(20)");

                    b.HasKey("CostId");

                    b.ToTable("Costs");
                });

            modelBuilder.Entity("CostNAGAPI.Models.Cost_Process", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CostId")
                        .HasColumnType("integer");

                    b.Property<int>("ProcessId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CostId");

                    b.HasIndex("ProcessId");

                    b.ToTable("Costs_Processes");
                });

            modelBuilder.Entity("CostNAGAPI.Models.Process", b =>
                {
                    b.Property<int>("ProcessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("daily_amount")
                        .HasColumnType("double precision");

                    b.Property<double>("daily_percentage")
                        .HasColumnType("double precision");

                    b.Property<int>("daily_qty")
                        .HasColumnType("integer");

                    b.Property<string>("doc_no")
                        .HasColumnType("character varying(20)");

                    b.Property<double>("process_cost")
                        .HasColumnType("double precision");

                    b.Property<int>("working_day")
                        .HasColumnType("integer");

                    b.HasKey("ProcessId");

                    b.ToTable("Processes");
                });

            modelBuilder.Entity("CostNAGAPI.Models.Cost_Process", b =>
                {
                    b.HasOne("CostNAGAPI.Models.Cost", "Cost")
                        .WithMany("cost_Processes")
                        .HasForeignKey("CostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CostNAGAPI.Models.Process", "Process")
                        .WithMany("cost_Processes")
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cost");

                    b.Navigation("Process");
                });

            modelBuilder.Entity("CostNAGAPI.Models.Cost", b =>
                {
                    b.Navigation("cost_Processes");
                });

            modelBuilder.Entity("CostNAGAPI.Models.Process", b =>
                {
                    b.Navigation("cost_Processes");
                });
#pragma warning restore 612, 618
        }
    }
}
