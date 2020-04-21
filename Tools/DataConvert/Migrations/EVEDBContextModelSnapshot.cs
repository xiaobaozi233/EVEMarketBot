﻿// <auto-generated />
using DataConvert.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataConvert.Migrations
{
    [DbContext(typeof(EVEDBContext))]
    partial class EVEDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("DataConvert.Data.PropData", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GroupID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name_CN")
                        .HasColumnType("TEXT");

                    b.Property<float>("Volume")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.ToTable("Props");
                });
#pragma warning restore 612, 618
        }
    }
}
