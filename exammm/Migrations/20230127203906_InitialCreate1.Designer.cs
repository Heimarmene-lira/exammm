﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exammm;

#nullable disable

namespace exammm.Migrations
{
    [DbContext(typeof(AppDB))]
    [Migration("20230127203906_InitialCreate1")]
    partial class InitialCreate1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("exammm.Good", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("Price");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("exammm.Good_saled", b =>
                {
                    b.Property<int>("GoodId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SaledId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GoodId", "SaledId");

                    b.HasIndex("SaledId");

                    b.ToTable("Good_Selads");
                });

            modelBuilder.Entity("exammm.Saled", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sum")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Date");

                    b.HasIndex("Sum");

                    b.HasIndex("UserId");

                    b.ToTable("Saleds");
                });

            modelBuilder.Entity("exammm.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Male")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Age");

                    b.HasIndex("Male");

                    b.HasIndex("Name");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("exammm.Good_saled", b =>
                {
                    b.HasOne("exammm.Good", "Good")
                        .WithMany("Good_Saled")
                        .HasForeignKey("GoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("exammm.Saled", "Saled")
                        .WithMany("good_Saled")
                        .HasForeignKey("SaledId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Good");

                    b.Navigation("Saled");
                });

            modelBuilder.Entity("exammm.Saled", b =>
                {
                    b.HasOne("exammm.Users", "Users")
                        .WithMany("Saled")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("exammm.Good", b =>
                {
                    b.Navigation("Good_Saled");
                });

            modelBuilder.Entity("exammm.Saled", b =>
                {
                    b.Navigation("good_Saled");
                });

            modelBuilder.Entity("exammm.Users", b =>
                {
                    b.Navigation("Saled");
                });
#pragma warning restore 612, 618
        }
    }
}
