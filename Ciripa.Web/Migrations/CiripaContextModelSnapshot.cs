﻿// <auto-generated />
using System;
using Ciripa.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ciripa.Web.Migrations
{
    [DbContext(typeof(CiripaContext))]
    partial class CiripaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("Ciripa.Data.Entities.Kid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cap")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<int>("ContractType")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ContractValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FiscalCode")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("From")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentFiscalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentLastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Province")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("SubscriptionAmount")
                        .HasColumnType("TEXT");

                    b.Property<bool>("SubscriptionPaid")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("To")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Kids");
                });

            modelBuilder.Entity("Ciripa.Data.Entities.Presence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EveningEntry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EveningExit")
                        .HasColumnType("TEXT");

                    b.Property<int>("KidId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("MorningEntry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("MorningExit")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("KidId");

                    b.ToTable("Presences");
                });

            modelBuilder.Entity("Ciripa.Data.Entities.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ExtraHourCost")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("HourCost")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("SubscriptionAmount")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExtraHourCost = 7.0m,
                            HourCost = 6.0m,
                            SubscriptionAmount = 200.0m
                        });
                });

            modelBuilder.Entity("Ciripa.Data.Entities.Presence", b =>
                {
                    b.HasOne("Ciripa.Data.Entities.Kid", "Kid")
                        .WithMany("PresencesList")
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
