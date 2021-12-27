﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _12._27._2021.data;

namespace _12._27._2021.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211227065541_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_12._27._2021.Models.Client", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<float>("budget")
                        .HasColumnType("real");

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("_12._27._2021.Models.Service", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("category_id")
                        .HasColumnType("int");

                    b.Property<int>("client_id")
                        .HasColumnType("int");

                    b.Property<int>("content_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("category_id");

                    b.HasIndex("client_id");

                    b.HasIndex("content_id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("_12._27._2021.Models.ServiceContent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("serviceContents");
                });

            modelBuilder.Entity("_12._27._2021.Models.category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("_12._27._2021.Models.Service", b =>
                {
                    b.HasOne("_12._27._2021.Models.category", "category")
                        .WithMany("Services")
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_12._27._2021.Models.Client", "Client")
                        .WithMany("Services")
                        .HasForeignKey("client_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_12._27._2021.Models.ServiceContent", "ServiceContent")
                        .WithMany("Services")
                        .HasForeignKey("content_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("Client");

                    b.Navigation("ServiceContent");
                });

            modelBuilder.Entity("_12._27._2021.Models.Client", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("_12._27._2021.Models.ServiceContent", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("_12._27._2021.Models.category", b =>
                {
                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
