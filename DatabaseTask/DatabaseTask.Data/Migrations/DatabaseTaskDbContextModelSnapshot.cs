﻿// <auto-generated />
using DatabaseTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    [DbContext(typeof(DatabaseTaskDbContext))]
    partial class DatabaseTaskDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DatabaseTask.Core.Domain.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Coupons", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.HasKey("StudentId");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Group_Supervisor", b =>
                {
                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("FirstName");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Kitchen", b =>
                {
                    b.Property<string>("Food")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CouponId")
                        .HasColumnType("int");

                    b.HasKey("Food");

                    b.ToTable("Kitchen");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.School", b =>
                {
                    b.Property<string>("SchoolName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SchoolAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolName");

                    b.ToTable("School");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentPhone")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
