﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestApi.DbContexts;

namespace RestApi.Migrations
{
    [DbContext(typeof(systemDbContext))]
    [Migration("20210909084858_Randevu")]
    partial class Randevu
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("RestApi.Models.Address.Counties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CountyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.HasKey("Id")
                        .HasName("PK_Counties");

                    b.HasIndex("CityId");

                    b.ToTable("Counties");
                });

            modelBuilder.Entity("RestApi.Models.Address.Cties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.HasKey("Id")
                        .HasName("PK_Cties");

                    b.ToTable("Cties");
                });

            modelBuilder.Entity("RestApi.Models.Address.Neighborhood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<string>("NeighborhoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id")
                        .HasName("PK_Neighborhoods");

                    b.HasIndex("CountyId");

                    b.ToTable("Neighborhoods");
                });

            modelBuilder.Entity("RestApi.Models.Address.Streets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<int>("NeighborhoodId")
                        .HasColumnType("int");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id")
                        .HasName("PK_Streets");

                    b.HasIndex("NeighborhoodId");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("RestApi.Models.Company.Companies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("CompanyAdressCityId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyAdressCountyId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyAdressNeighborhoodId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyAdressStreetId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyDelegateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyDelegatePhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CompanyGroupId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyLocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CompanyMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id")
                        .HasName("PK_Companies");

                    b.HasIndex("CompanyGroupId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyAppointmentTimes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<DateTime>("TimeToFinish")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("TimeToStart")
                        .HasColumnType("datetime");

                    b.Property<ulong>("isAvailable")
                        .HasColumnType("bit");

                    b.HasKey("Id")
                        .HasName("PK_CompanyAppointmentTimes");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyAppointmentTimes");
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyComments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<double>("Rank")
                        .HasColumnType("double");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<ulong>("isConfirmed")
                        .HasColumnType("bit");

                    b.HasKey("Id")
                        .HasName("PK_CompanyComments");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("CompanyComments");
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyGroupAppointmentAreaTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyGroupId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_CompanyGroupAppointmentAreaTypes");

                    b.HasIndex("CompanyGroupId");

                    b.ToTable("CompanyGroupAppointmentAreaTypes");
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyGroupAppointmentAreas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyGroupAppointmentAreaAreaTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_CompanyGroupAppointmentAreas");

                    b.HasIndex("CompanyGroupAppointmentAreaAreaTypeId");

                    b.ToTable("CompanyGroupAppointmentAreas");
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyGroups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyGroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.HasKey("Id")
                        .HasName("PK_CompanyGroups");

                    b.ToTable("CompanyGroups");
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<string>("ImageDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.HasKey("Id")
                        .HasName("PK_CompanyImages");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyImages");
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyTables", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<ulong>("isAvailable")
                        .HasColumnType("bit");

                    b.HasKey("Id")
                        .HasName("PK_CompanyTables");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyTables");
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyWorks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<double>("DurationMin")
                        .HasColumnType("double");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id")
                        .HasName("PK_CompanyWorks");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyWorks");
                });

            modelBuilder.Entity("RestApi.Models.User.UserAppointments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyAppointmentTimeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<ulong>("isConfirmed")
                        .HasColumnType("bit");

                    b.Property<ulong>("isFinished")
                        .HasColumnType("bit");

                    b.HasKey("Id")
                        .HasName("PK_UserAppointments");

                    b.HasIndex("CompanyAppointmentTimeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAppointments");
                });

            modelBuilder.Entity("RestApi.Models.User.UserAppointmentsSelectedTables", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.Property<int>("UserAppointmentId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_UserAppointments");

                    b.HasIndex("TableId");

                    b.HasIndex("UserAppointmentId");

                    b.ToTable("UserAppointmentsSelectedTables");
                });

            modelBuilder.Entity("RestApi.Models.User.UserAppointmentsSelectedWorks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyWorkId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<int>("UserAppointmentId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_UserAppointmentsSelectedWorks");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CompanyWorkId");

                    b.HasIndex("UserAppointmentId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAppointmentsSelectedWorks");
                });

            modelBuilder.Entity("RestApi.Models.User.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<ulong>("isActive")
                        .HasColumnType("bit");

                    b.Property<ulong>("isAuthentication")
                        .HasColumnType("bit");

                    b.HasKey("Id")
                        .HasName("PK_Users");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RestApi.Models.Address.Counties", b =>
                {
                    b.HasOne("RestApi.Models.Address.Cties", null)
                        .WithMany()
                        .HasForeignKey("CityId")
                        .HasConstraintName("FK_Counties_Cties")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApi.Models.Address.Neighborhood", b =>
                {
                    b.HasOne("RestApi.Models.Address.Counties", null)
                        .WithMany()
                        .HasForeignKey("CountyId")
                        .HasConstraintName("FK_Neighborhoods_Counties")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApi.Models.Address.Streets", b =>
                {
                    b.HasOne("RestApi.Models.Address.Neighborhood", null)
                        .WithMany()
                        .HasForeignKey("NeighborhoodId")
                        .HasConstraintName("FK_Streets_Neighborhoods")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApi.Models.Company.Companies", b =>
                {
                    b.HasOne("RestApi.Models.Company.CompanyGroups", null)
                        .WithMany()
                        .HasForeignKey("CompanyGroupId")
                        .HasConstraintName("FK_CompanyGroup_Companies")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyAppointmentTimes", b =>
                {
                    b.HasOne("RestApi.Models.Company.Companies", null)
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK_Company_CompanyAppointmentTimes")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyComments", b =>
                {
                    b.HasOne("RestApi.Models.Company.Companies", null)
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK_Company_CompanyComments")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RestApi.Models.User.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_User_CompanyComments")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyGroupAppointmentAreaTypes", b =>
                {
                    b.HasOne("RestApi.Models.Company.CompanyGroups", null)
                        .WithMany()
                        .HasForeignKey("CompanyGroupId")
                        .HasConstraintName("FK_CompanyGroup_CompanyGroupAppointmentAreaTypes")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyGroupAppointmentAreas", b =>
                {
                    b.HasOne("RestApi.Models.Company.CompanyGroupAppointmentAreaTypes", null)
                        .WithMany()
                        .HasForeignKey("CompanyGroupAppointmentAreaAreaTypeId")
                        .HasConstraintName("FK_CompanyGroupAppointmentAreaTypes_CompanyGroupAppointmentAreas")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyImages", b =>
                {
                    b.HasOne("RestApi.Models.Company.Companies", null)
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK_Company_CompanyImages")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyTables", b =>
                {
                    b.HasOne("RestApi.Models.Company.Companies", null)
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK_Company_CompanyTables")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApi.Models.Company.CompanyWorks", b =>
                {
                    b.HasOne("RestApi.Models.Company.Companies", null)
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK_Company_CompanyWorks")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApi.Models.User.UserAppointments", b =>
                {
                    b.HasOne("RestApi.Models.Company.CompanyAppointmentTimes", null)
                        .WithMany()
                        .HasForeignKey("CompanyAppointmentTimeId")
                        .HasConstraintName("FK_CompanyAppointmentTimes_UserAppointments")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RestApi.Models.User.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_User_UserAppointments")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApi.Models.User.UserAppointmentsSelectedTables", b =>
                {
                    b.HasOne("RestApi.Models.Company.CompanyTables", null)
                        .WithMany()
                        .HasForeignKey("TableId")
                        .HasConstraintName("FK_CompanyTables_UserAppointmentsSelectedTables")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RestApi.Models.User.UserAppointments", null)
                        .WithMany()
                        .HasForeignKey("UserAppointmentId")
                        .HasConstraintName("FK_UserAppointments_UserAppointmentsSelectedTables")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RestApi.Models.User.UserAppointmentsSelectedWorks", b =>
                {
                    b.HasOne("RestApi.Models.Company.Companies", null)
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK_Company_PK_UserAppointmentsSelectedWorks")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RestApi.Models.Company.CompanyWorks", null)
                        .WithMany()
                        .HasForeignKey("CompanyWorkId")
                        .HasConstraintName("FK_CompanyWork_PK_UserAppointmentsSelectedWorks")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RestApi.Models.User.UserAppointments", null)
                        .WithMany()
                        .HasForeignKey("UserAppointmentId")
                        .HasConstraintName("FK_UserAppointments_PK_UserAppointmentsSelectedWorks")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RestApi.Models.User.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_User_PK_UserAppointmentsSelectedWorks")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
