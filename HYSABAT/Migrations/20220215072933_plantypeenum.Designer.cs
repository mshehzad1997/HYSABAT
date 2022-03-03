﻿// <auto-generated />
using System;
using HYSABAT.Controllers.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HYSABAT.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220215072933_plantypeenum")]
    partial class plantypeenum
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("HYSABAT.Models.CompanyContactInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CompanyLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("companyContactInformation");
                });

            modelBuilder.Entity("HYSABAT.Models.ContactInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AutoRenew")
                        .HasColumnType("bit");

                    b.Property<string>("CRNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CVC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOnCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfBranches")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfCustomer")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSupliers")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfUser")
                        .HasColumnType("int");

                    b.Property<int>("Postal_ZipCode")
                        .HasColumnType("int");

                    b.Property<string>("Postion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PricingPlanId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("plans")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PricingPlanId");

                    b.ToTable("contactInformation");
                });

            modelBuilder.Entity("HYSABAT.Models.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("contactUs");
                });

            modelBuilder.Entity("HYSABAT.Models.Features", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DashboradTypes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("features");
                });

            modelBuilder.Entity("HYSABAT.Models.PricingPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("PricingPlanImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PricingPlanMonthlyPrice")
                        .HasColumnType("int");

                    b.Property<string>("PricingPlanTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PricingPlanYearlyPrice")
                        .HasColumnType("int");

                    b.Property<string>("planfeatures1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("planfeatures2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("planfeatures3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("planfeatures4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("planfeatures5")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("pricingPlans");
                });

            modelBuilder.Entity("HYSABAT.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Answers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("questions");
                });

            modelBuilder.Entity("HYSABAT.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("VideoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("videos");
                });

            modelBuilder.Entity("HYSABAT.Models.ContactInformation", b =>
                {
                    b.HasOne("HYSABAT.Models.PricingPlan", "PricingPlan")
                        .WithMany()
                        .HasForeignKey("PricingPlanId");

                    b.Navigation("PricingPlan");
                });
#pragma warning restore 612, 618
        }
    }
}
