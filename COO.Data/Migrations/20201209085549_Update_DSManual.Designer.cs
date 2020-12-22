﻿// <auto-generated />
using System;
using COO.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COO.Data.Migrations
{
    [DbContext(typeof(COOContext))]
    [Migration("20201209085549_Update_DSManual")]
    partial class Update_DSManual
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COO.Data.EF.TblBoom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AltGroup")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Item")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Level")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Material")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ParentMaterial")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Plant")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SortString")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Id")
                        .HasName("PK_tblBoom_1");

                    b.ToTable("tbl_Boom");
                });

            modelBuilder.Entity("COO.Data.EF.TblBoomEcus", b =>
                {
                    b.Property<string>("AltGroup")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Country")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<decimal?>("DonGiaHd")
                        .HasColumnName("DonGiaHD")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<string>("Item")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Level")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("MaHS")
                        .HasColumnName("MaHS")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayDk")
                        .HasColumnName("NgayDK")
                        .HasColumnType("datetime");

                    b.Property<string>("ParentMaterial")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Plant")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SoTk")
                        .HasColumnName("SoTK")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("SortString")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("TenHang")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.ToTable("tbl_BoomEcusTS");
                });

            modelBuilder.Entity("COO.Data.EF.TblConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Key")
                        .HasColumnName("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemarkConfig")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Value")
                        .HasColumnName("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Config");
                });

            modelBuilder.Entity("COO.Data.EF.TblCountryShip", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HMDShipToCode")
                        .IsRequired()
                        .HasColumnName("HMDShipToCode")
                        .HasColumnType("nchar(20)")
                        .IsFixedLength(true)
                        .HasMaxLength(20);

                    b.Property<string>("HMDShipToParty")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("RemarkCountry")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("ShipToCountryCode")
                        .IsRequired()
                        .HasColumnName("ShipToCountryCode")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("ShipToCountryName")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("tbl_CountryShip");
                });

            modelBuilder.Entity("COO.Data.EF.TblDeliverySales", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ActualGidate")
                        .HasColumnName("ActualGIDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<long?>("CustomerInvoiceNo")
                        .HasColumnType("bigint");

                    b.Property<long>("Delivery")
                        .HasColumnType("bigint");

                    b.Property<long>("Dnqty")
                        .HasColumnName("DNQty")
                        .HasColumnType("bigint");

                    b.Property<string>("HMDShipToCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("HarmonizationCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime");

                    b.Property<long>("InvoiceNo")
                        .HasColumnType("bigint");

                    b.Property<string>("MaterialDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("MaterialParent")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal>("NetPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("NetValue")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("PartyName")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("PlanGidate")
                        .HasColumnName("PlanGIDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("PlanGisysDate")
                        .HasColumnName("PlanGISysDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Plant")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("SaleUnit")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("ShipToCountry")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("ShipToCountryName")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("tbl_DeliverySales");
                });

            modelBuilder.Entity("COO.Data.EF.TblDeliverySales_Temp", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ActualGidate")
                        .HasColumnName("ActualGIDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<long?>("CustomerInvoiceNo")
                        .HasColumnType("bigint");

                    b.Property<long>("Delivery")
                        .HasColumnType("bigint");

                    b.Property<long>("Dnqty")
                        .HasColumnName("DNQty")
                        .HasColumnType("bigint");

                    b.Property<string>("HMDShipToCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("HarmonizationCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime");

                    b.Property<long>("InvoiceNo")
                        .HasColumnType("bigint");

                    b.Property<string>("MaterialDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("MaterialParent")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal>("NetPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("NetValue")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("PartyName")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("PlanGidate")
                        .HasColumnName("PlanGIDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("PlanGisysDate")
                        .HasColumnName("PlanGISysDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Plant")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("SaleUnit")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("ShipToCountry")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("ShipToCountryName")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("tbl_DeliverySales_Temp");
                });

            modelBuilder.Entity("COO.Data.EF.TblDsmanual", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cooform")
                        .HasColumnName("COOForm")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Coono")
                        .HasColumnName("COONo")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<DateTime?>("CourierDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("DeliverySalesId")
                        .HasColumnName("DeliverySalesID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Origin")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Package")
                        .HasColumnName("Package")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<DateTime?>("ReceiptDate")
                        .HasColumnType("datetime");

                    b.Property<string>("RemarkDs")
                        .HasColumnName("RemarkDS")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ShipFrom")
                        .HasColumnName("ShipFrom")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("TrackingDate")
                        .HasColumnType("datetime");

                    b.Property<string>("TrackingNo")
                        .HasColumnName("TrackingNo")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("DeliverySalesId");

                    b.ToTable("tbl_DSManual");
                });

            modelBuilder.Entity("COO.Data.EF.TblEcusTs", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<decimal?>("DonGiaHd")
                        .HasColumnName("DonGiaHD")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("MaHang")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("MaHs")
                        .HasColumnName("MaHS")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgayDk")
                        .HasColumnName("NgayDK")
                        .HasColumnType("datetime");

                    b.Property<string>("SoTk")
                        .IsRequired()
                        .HasColumnName("SoTK")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("TenHang")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("tbl_EcusTS");
                });

            modelBuilder.Entity("COO.Data.EF.TblPlant", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Plant")
                        .IsRequired()
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("RemarkPlant")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("tbl_Plant");
                });

            modelBuilder.Entity("COO.Data.EF.TblDsmanual", b =>
                {
                    b.HasOne("COO.Data.EF.TblDeliverySales", "DeliverySales")
                        .WithMany("TblDsmanual")
                        .HasForeignKey("DeliverySalesId")
                        .HasConstraintName("FK_tblDSManual_tblDeliverySales")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
