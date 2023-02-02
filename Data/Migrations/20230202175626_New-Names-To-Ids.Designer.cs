﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230202175626_New-Names-To-Ids")]
    partial class NewNamesToIds
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Domain.Models.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("client_name");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("message");

                    b.Property<string>("OriginEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("origin_email");

                    b.Property<string>("RecipientEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("recipient_email");

                    b.Property<string>("RecipientNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("recipient_number");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("subject");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("type");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("API.Domain.Models.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("password");

                    b.Property<int>("Role")
                        .HasColumnType("int")
                        .HasColumnName("role");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,4)")
                        .HasColumnName("salary");

                    b.Property<decimal>("SalarySave")
                        .HasColumnType("decimal(18,4)")
                        .HasColumnName("salary_save");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Application.Models.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("MonthId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("month_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,4)")
                        .HasColumnName("salary");

                    b.HasKey("Id");

                    b.HasIndex("MonthId");

                    b.HasIndex("UserId");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("Application.Models.Month", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Months");
                });

            modelBuilder.Entity("Application.Models.SpentInMonth", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("MonthId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("month_id");

                    b.Property<decimal>("SpendPercentageAbove")
                        .HasColumnType("decimal(18,4)")
                        .HasColumnName("spent_percentage_above");

                    b.Property<decimal>("Spent")
                        .HasColumnType("decimal(18,4)")
                        .HasColumnName("spent");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("MonthId");

                    b.HasIndex("UserId");

                    b.ToTable("SpentInMonth");
                });

            modelBuilder.Entity("Application.Models.Bill", b =>
                {
                    b.HasOne("Application.Models.Month", "Month")
                        .WithMany("Bills")
                        .HasForeignKey("MonthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Domain.Models.User", "User")
                        .WithMany("Bills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Month");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Application.Models.SpentInMonth", b =>
                {
                    b.HasOne("Application.Models.Month", "Month")
                        .WithMany("SpentInMonth")
                        .HasForeignKey("MonthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Domain.Models.User", "User")
                        .WithMany("SpentInMonth")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Month");

                    b.Navigation("User");
                });

            modelBuilder.Entity("API.Domain.Models.User", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("SpentInMonth");
                });

            modelBuilder.Entity("Application.Models.Month", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("SpentInMonth");
                });
#pragma warning restore 612, 618
        }
    }
}
