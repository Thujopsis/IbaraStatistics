﻿// <auto-generated />
using IbaraStatistics.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IbaraStatistics.Migrations
{
    [DbContext(typeof(IbaraDbContext))]
    partial class IbaraDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("IbaraStatistics.Models.Character", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Eno")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("IbaraStatistics.Models.Extraordinarys", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Eno")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Extraordinary")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Extraordinarys");
                });

            modelBuilder.Entity("IbaraStatistics.Models.Items", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Eno")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Item")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
