﻿// <auto-generated />
using System;
using CustomerCareSystem.Services.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomerCareSystem.Migrations
{
    [DbContext(typeof(CustomerCareSystemDbContext))]
    [Migration("20250109040850_init-migration")]
    partial class initmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerCareSystem.Models.Domain.ExecutiveLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QueryType")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExecutiveLogin");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "general123",
                            QueryType = 0,
                            User = "general@ccs.com"
                        },
                        new
                        {
                            Id = 2,
                            Password = "repair123",
                            QueryType = 1,
                            User = "repair@ccs.com"
                        },
                        new
                        {
                            Id = 3,
                            Password = "return123",
                            QueryType = 2,
                            User = "return@ccs.com"
                        },
                        new
                        {
                            Id = 4,
                            Password = "inquiry123",
                            QueryType = 3,
                            User = "inquiry@ccs.com"
                        });
                });

            modelBuilder.Entity("CustomerCareSystem.Models.Domain.Token", b =>
                {
                    b.Property<Guid>("TokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("TokenId");

                    b.ToTable("Token");
                });
#pragma warning restore 612, 618
        }
    }
}
