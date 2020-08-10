﻿// <auto-generated />
using System;
using Ciripa.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ciripa.Web.Migrations
{
    [DbContext(typeof(CiripaContext))]
    [Migration("20200627154323_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("Ciripa.Data.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContractType")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("DailyHours")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ExtraHourCost")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("HourCost")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("MinContractValue")
                        .HasColumnType("TEXT");

                    b.Property<bool>("MonthlyContract")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("MonthlyHours")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contract");

                    b.HasDiscriminator<int>("ContractType");
                });

            modelBuilder.Entity("Ciripa.Data.Entities.ExtraPresence", b =>
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

                    b.Property<int>("SpecialContractId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KidId");

                    b.HasIndex("SpecialContractId");

                    b.ToTable("ExtraPresences");
                });

            modelBuilder.Entity("Ciripa.Data.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<int>("BillingParentId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("KidId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PaymentMethod")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("SubscriptionAmount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("SubscriptionPaidDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("KidId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Ciripa.Data.Entities.Kid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ContractId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ExtraServicesEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FiscalCode")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("From")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("SubscriptionAmount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("SubscriptionPaidDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("To")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

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

            modelBuilder.Entity("Ciripa.Data.Entities.SimpleContract", b =>
                {
                    b.HasBaseType("Ciripa.Data.Entities.Contract");

                    b.HasDiscriminator().HasValue(1);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DailyHours = 4m,
                            Description = "Contratto 4 ore/dì",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 500m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            DailyHours = 4.5m,
                            Description = "Contratto 4,5 ore/dì",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 525m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            DailyHours = 5m,
                            Description = "Contratto 5 ore/dì",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 550m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            DailyHours = 5.5m,
                            Description = "Contratto 5,5 ore/dì",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 575m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            DailyHours = 6m,
                            Description = "Contratto 6 ore/dì",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 600m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            DailyHours = 6.5m,
                            Description = "Contratto 6,5 ore/dì",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 625m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            DailyHours = 7m,
                            Description = "Contratto 7 ore/dì",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 650m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            DailyHours = 7.5m,
                            Description = "Contratto 7,5 ore/dì",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 675m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            DailyHours = 8m,
                            Description = "Contratto 8 ore/dì",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 700m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            DailyHours = 8.5m,
                            Description = "Contratto 8,5 ore/dì",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 725m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            DailyHours = 9m,
                            Description = "Contratto 9 ore/dì",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 750m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            DailyHours = 9.5m,
                            Description = "Contratto 9,5 ore/dì",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 775m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            DailyHours = 10m,
                            Description = "Contratto 10 ore/dì",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 800m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            DailyHours = 0m,
                            Description = "Contratto orario",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8m,
                            HourCost = 7m,
                            MinContractValue = 300m,
                            MonthlyContract = true,
                            MonthlyHours = 43m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Ciripa.Data.Entities.SpecialContract", b =>
                {
                    b.HasBaseType("Ciripa.Data.Entities.Contract");

                    b.Property<bool>("WeeklyContract")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue(2);

                    b.HasData(
                        new
                        {
                            Id = 15,
                            DailyHours = 0m,
                            Description = "Babysitting",
                            EndTime = new DateTime(2020, 1, 1, 22, 59, 59, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 10.0m,
                            HourCost = 10.0m,
                            MinContractValue = 0m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WeeklyContract = false
                        },
                        new
                        {
                            Id = 16,
                            DailyHours = 0m,
                            Description = "Colonie settimanali",
                            EndTime = new DateTime(2020, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 7.0m,
                            MinContractValue = 150m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified),
                            WeeklyContract = true
                        },
                        new
                        {
                            Id = 17,
                            DailyHours = 0m,
                            Description = "Aiuto compiti",
                            EndTime = new DateTime(2020, 1, 1, 22, 59, 59, 0, DateTimeKind.Unspecified),
                            ExtraHourCost = 8.0m,
                            HourCost = 8.0m,
                            MinContractValue = 0m,
                            MonthlyContract = false,
                            MonthlyHours = 0m,
                            StartTime = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WeeklyContract = false
                        });
                });

            modelBuilder.Entity("Ciripa.Data.Entities.ExtraPresence", b =>
                {
                    b.HasOne("Ciripa.Data.Entities.Kid", "Kid")
                        .WithMany()
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ciripa.Data.Entities.SpecialContract", "SpecialContract")
                        .WithMany()
                        .HasForeignKey("SpecialContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ciripa.Data.Entities.Invoice", b =>
                {
                    b.HasOne("Ciripa.Data.Entities.Kid", "Kid")
                        .WithMany()
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Ciripa.Data.Entities.Parent", "BillingParent", b1 =>
                        {
                            b1.Property<int>("InvoiceId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Address")
                                .HasColumnType("TEXT");

                            b1.Property<bool>("Billing")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Cap")
                                .HasColumnType("TEXT");

                            b1.Property<string>("City")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Email")
                                .HasColumnType("TEXT");

                            b1.Property<string>("FirstName")
                                .HasColumnType("TEXT");

                            b1.Property<string>("FiscalCode")
                                .HasColumnType("TEXT");

                            b1.Property<int>("Id")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("LastName")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Phone")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Province")
                                .HasColumnType("TEXT");

                            b1.HasKey("InvoiceId");

                            b1.ToTable("Invoice");

                            b1.WithOwner()
                                .HasForeignKey("InvoiceId");
                        });
                });

            modelBuilder.Entity("Ciripa.Data.Entities.Kid", b =>
                {
                    b.HasOne("Ciripa.Data.Entities.SimpleContract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Ciripa.Data.Entities.Parent", "Parent1", b1 =>
                        {
                            b1.Property<int>("KidId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Address")
                                .HasColumnType("TEXT");

                            b1.Property<bool>("Billing")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Cap")
                                .HasColumnType("TEXT");

                            b1.Property<string>("City")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Email")
                                .HasColumnType("TEXT");

                            b1.Property<string>("FirstName")
                                .HasColumnType("TEXT");

                            b1.Property<string>("FiscalCode")
                                .HasColumnType("TEXT");

                            b1.Property<int>("Id")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("LastName")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Phone")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Province")
                                .HasColumnType("TEXT");

                            b1.HasKey("KidId");

                            b1.ToTable("Kids");

                            b1.WithOwner()
                                .HasForeignKey("KidId");
                        });

                    b.OwnsOne("Ciripa.Data.Entities.Parent", "Parent2", b1 =>
                        {
                            b1.Property<int>("KidId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Address")
                                .HasColumnType("TEXT");

                            b1.Property<bool>("Billing")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Cap")
                                .HasColumnType("TEXT");

                            b1.Property<string>("City")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Email")
                                .HasColumnType("TEXT");

                            b1.Property<string>("FirstName")
                                .HasColumnType("TEXT");

                            b1.Property<string>("FiscalCode")
                                .HasColumnType("TEXT");

                            b1.Property<int>("Id")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("LastName")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Phone")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Province")
                                .HasColumnType("TEXT");

                            b1.HasKey("KidId");

                            b1.ToTable("Kids");

                            b1.WithOwner()
                                .HasForeignKey("KidId");
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