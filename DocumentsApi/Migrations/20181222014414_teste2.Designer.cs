﻿// <auto-generated />
using DocumentsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DocumentsApi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20181222014414_teste2")]
    partial class teste2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DocumentsApi.Models.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DocumentsApi.Models.Department", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DocumentsApi.Models.Document", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CategoryId");

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("DocumentsApi.Models.DocumentDepartment", b =>
                {
                    b.Property<long>("DocumentId");

                    b.Property<long>("DepartmentId");

                    b.HasKey("DocumentId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DocumentDepartment");
                });

            modelBuilder.Entity("DocumentsApi.Models.Document", b =>
                {
                    b.HasOne("DocumentsApi.Models.Category", "Category")
                        .WithMany("Documents")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DocumentsApi.Models.DocumentDepartment", b =>
                {
                    b.HasOne("DocumentsApi.Models.Department", "Department")
                        .WithMany("DocumentDepartments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DocumentsApi.Models.Document", "Document")
                        .WithMany("DocumentDepartments")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
