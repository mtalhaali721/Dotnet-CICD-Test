﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TKWebAPI.Data;

#nullable disable

namespace TKWebAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TKWebAPI.Models.CategoryModel", b =>
                {
                    b.Property<int>("CatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatID"), 1L, 1);

                    b.Property<string>("CatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TKWebAPI.Models.DevicesModel", b =>
                {
                    b.Property<int>("DevId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DevId"), 1L, 1);

                    b.Property<string>("DevCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DevName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DevQuantity")
                        .HasColumnType("int");

                    b.Property<float>("DevRate")
                        .HasColumnType("real");

                    b.HasKey("DevId");

                    b.ToTable("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}
