// <auto-generated />
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
    [Migration("20220208115202_videoclass")]
    partial class videoclass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("HYSABAT.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AccountDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("accountManagement");
                });

            modelBuilder.Entity("HYSABAT.Models.Assest", b =>
                {
                    b.Property<int>("AssestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AssesImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssestDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssetTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssestId");

                    b.ToTable("assests");
                });

            modelBuilder.Entity("HYSABAT.Models.Bussiness", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BusinessImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BusinessMonthlyPrice")
                        .HasColumnType("int");

                    b.Property<string>("BusinessPlanFeatures")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BusinessYearlyPrice")
                        .HasColumnType("int");

                    b.HasKey("BusinessId");

                    b.ToTable("business");
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

                    b.Property<string>("Bussiness")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CRNumber")
                        .HasColumnType("int");

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

                    b.Property<int>("CreditCardNumber")
                        .HasColumnType("int");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("contactInformation");
                });

            modelBuilder.Entity("HYSABAT.Models.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CompanyLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("HYSABAT.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EmployeeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("HYSABAT.Models.EnterPrise", b =>
                {
                    b.Property<int>("EnterpriseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EnterpriseImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnterpriseMonthlyPrice")
                        .HasColumnType("int");

                    b.Property<string>("EnterprisePlanFeatures")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnterpriseTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnterpriseYearlyPrice")
                        .HasColumnType("int");

                    b.HasKey("EnterpriseId");

                    b.ToTable("enterPrises");
                });

            modelBuilder.Entity("HYSABAT.Models.Help", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("HelpCenterDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HelpCenterImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HelpCenterTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("helps");
                });

            modelBuilder.Entity("HYSABAT.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("PurchaseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PurchaseId");

                    b.ToTable("purchases");
                });

            modelBuilder.Entity("HYSABAT.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("question")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("questions");
                });

            modelBuilder.Entity("HYSABAT.Models.SalesInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("SaleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaleImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaleTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("salesInformation");
                });

            modelBuilder.Entity("HYSABAT.Models.StarterPlan", b =>
                {
                    b.Property<int>("StarterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("StarterImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StarterMonthlyPrice")
                        .HasColumnType("int");

                    b.Property<string>("StarterPlanFeatures")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StarterTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StarterYearlyPrice")
                        .HasColumnType("int");

                    b.HasKey("StarterId");

                    b.ToTable("starterPlans");
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
#pragma warning restore 612, 618
        }
    }
}
