﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShareBook.Repository;

namespace ShareBook.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200509195647_Refatoracao_para_Book_ter_apenas_um_campo_status")]
    partial class Refatoracao_para_Book_ter_apenas_um_campo_status
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShareBook.Domain.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(30);

                    b.Property<string>("Complement")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Neighborhood")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(30);

                    b.Property<string>("Number")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("PostalCode")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("State")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Street")
                        .HasColumnType("varchar(80)")
                        .HasMaxLength(50);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ShareBook.Domain.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(50);

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ChooseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FacilitatorNotes")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<int>("FreightOption")
                        .HasColumnType("int");

                    b.Property<string>("ImageSlug")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Slug")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Synopsis")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(50);

                    b.Property<string>("TrackingNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserIdFacilitator")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserIdFacilitator");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("ShareBook.Domain.BookUser", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NickName")
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Note")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Reason")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id", "BookId", "UserId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("BookUser");
                });

            modelBuilder.Entity("ShareBook.Domain.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ShareBook.Domain.JobHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("varchar(max)");

                    b.Property<bool>("IsSuccess")
                        .HasColumnType("bit");

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("LastResult")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<double>("TimeSpentSeconds")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("JobHistories");
                });

            modelBuilder.Entity("ShareBook.Domain.LogEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LogDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Operation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ValuesChanges")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LogEntries");
                });

            modelBuilder.Entity("ShareBook.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("1");

                    b.Property<bool>("AllowSendingEmail")
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("HashCodePassword")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("HashCodePasswordExpiryDate")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("LastLogin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Linkedin")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("Profile")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ShareBook.Domain.Address", b =>
                {
                    b.HasOne("ShareBook.Domain.User", null)
                        .WithOne("Address")
                        .HasForeignKey("ShareBook.Domain.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShareBook.Domain.Book", b =>
                {
                    b.HasOne("ShareBook.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShareBook.Domain.User", "User")
                        .WithMany("BooksDonated")
                        .HasForeignKey("UserId");

                    b.HasOne("ShareBook.Domain.User", "UserFacilitator")
                        .WithMany()
                        .HasForeignKey("UserIdFacilitator");
                });

            modelBuilder.Entity("ShareBook.Domain.BookUser", b =>
                {
                    b.HasOne("ShareBook.Domain.Book", "Book")
                        .WithMany("BookUsers")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShareBook.Domain.User", "User")
                        .WithMany("BookUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
