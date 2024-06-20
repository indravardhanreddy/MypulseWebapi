﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MypulseWebapi.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MypulseWebapi.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240529063957_InitialCreatEPG17")]
    partial class InitialCreatEPG17
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DepartmentManager", b =>
                {
                    b.Property<string>("DepartmentsId")
                        .HasColumnType("text");

                    b.Property<string>("ManagersId")
                        .HasColumnType("text");

                    b.HasKey("DepartmentsId", "ManagersId");

                    b.HasIndex("ManagersId");

                    b.ToTable("DepartmentManager");
                });

            modelBuilder.Entity("EntityManagerManager", b =>
                {
                    b.Property<string>("EntityManagersId")
                        .HasColumnType("text");

                    b.Property<string>("ManagersId")
                        .HasColumnType("text");

                    b.HasKey("EntityManagersId", "ManagersId");

                    b.HasIndex("ManagersId");

                    b.ToTable("EntityManagerManager");
                });

            modelBuilder.Entity("EntityManagerUser", b =>
                {
                    b.Property<string>("EntityManagersId")
                        .HasColumnType("text");

                    b.Property<string>("UsersId")
                        .HasColumnType("text");

                    b.HasKey("EntityManagersId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("EntityManagerUser");
                });

            modelBuilder.Entity("ManagerUser", b =>
                {
                    b.Property<string>("ManagersId")
                        .HasColumnType("text");

                    b.Property<string>("UsersId")
                        .HasColumnType("text");

                    b.HasKey("ManagersId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ManagerUser");
                });

            modelBuilder.Entity("MypulseWebapi.Models.Appointment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("AppMeetLink")
                        .HasColumnType("text");

                    b.Property<DateTime?>("AppointmentEndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("AppointmentFees")
                        .HasColumnType("integer");

                    b.Property<int?>("AppointmentMode")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("AppointmentStartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EntityManagerId")
                        .HasColumnType("text");

                    b.Property<int?>("Frequency")
                        .HasColumnType("integer");

                    b.Property<string>("ManagerId")
                        .HasColumnType("text");

                    b.Property<string>("MeetLink")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("text");

                    b.Property<bool?>("Scheduled")
                        .HasColumnType("boolean");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("__typeName")
                        .HasColumnType("text");

                    b.Property<long>("_lastChangedAt")
                        .HasColumnType("bigint");

                    b.Property<int?>("_version")
                        .HasColumnType("integer");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EntityManagerId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("UserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("MypulseWebapi.Models.Availability", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("AdditionalInfo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AdditionalInstructions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int[]>("AppointmentModes")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("AvailabilityJSON")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BookingPeriod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ExcludedDateConfig")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ManagerID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MaxBookedSlots")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MeetLocationId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PaymentCharges")
                        .HasColumnType("integer");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SlotDuration")
                        .HasColumnType("integer");

                    b.Property<string>("Timezone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ManagerID");

                    b.ToTable("Availabilities");
                });

            modelBuilder.Entity("MypulseWebapi.Models.ChatSession", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<bool>("IsManagerRead")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsUserRead")
                        .HasColumnType("boolean");

                    b.Property<string>("LastMessage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ManagerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("__typeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("_lastChangedAt")
                        .HasColumnType("bigint");

                    b.Property<int>("_version")
                        .HasColumnType("integer");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.HasIndex("UserId");

                    b.ToTable("ChatSessions");
                });

            modelBuilder.Entity("MypulseWebapi.Models.Configuration", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<List<string>>("Cities")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<List<string>>("Specializations")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("__typeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("_lastChangedAt")
                        .HasColumnType("bigint");

                    b.Property<int>("_version")
                        .HasColumnType("integer");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("MypulseWebapi.Models.Department", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("EntityManagerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<string>>("Expertise")
                        .HasColumnType("text[]");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("__typeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("_lastChangedAt")
                        .HasColumnType("bigint");

                    b.Property<int>("_version")
                        .HasColumnType("integer");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("entityVerified")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EntityManagerId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("MypulseWebapi.Models.EntityManager", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<List<string>>("AvatarS3Key")
                        .HasColumnType("text[]");

                    b.Property<string>("CognitoUserId")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool?>("Email_Verified")
                        .HasColumnType("boolean");

                    b.Property<string>("LocationId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone_Number")
                        .HasColumnType("text");

                    b.Property<bool?>("Phone_Number_Verified")
                        .HasColumnType("boolean");

                    b.Property<List<string>>("Specializations")
                        .HasColumnType("text[]");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Website")
                        .HasColumnType("text");

                    b.Property<string>("__typeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("_lastChangedAt")
                        .HasColumnType("bigint");

                    b.Property<int>("_version")
                        .HasColumnType("integer");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("entityVerified")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("EntityManagers");
                });

            modelBuilder.Entity("MypulseWebapi.Models.HealthInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("BloodGroup")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BloodPressure")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SugarLevel")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.Property<string>("__typeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("_lastChangedAt")
                        .HasColumnType("bigint");

                    b.Property<int>("_version")
                        .HasColumnType("integer");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("HealthInfos");
                });

            modelBuilder.Entity("MypulseWebapi.Models.License", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("EntityManagerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("IssueDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("__typeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("_lastChangedAt")
                        .HasColumnType("bigint");

                    b.Property<int>("_version")
                        .HasColumnType("integer");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EntityManagerId");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("MypulseWebapi.Models.Location", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sublocality")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("__typeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("_lastChangedAt")
                        .HasColumnType("bigint");

                    b.Property<int>("_version")
                        .HasColumnType("integer");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MypulseWebapi.Models.Manager", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("AvailabilityJSON")
                        .HasColumnType("text");

                    b.Property<string>("AvatarS3Key")
                        .HasColumnType("text");

                    b.Property<string>("CognitoUserId")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool?>("Email_Verified")
                        .HasColumnType("boolean");

                    b.Property<string>("LocationId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("Offline_Consultation_Charges")
                        .HasColumnType("integer");

                    b.Property<string>("Phone_Number")
                        .HasColumnType("text");

                    b.Property<bool?>("Phone_Number_Verified")
                        .HasColumnType("boolean");

                    b.Property<string>("Qualification")
                        .HasColumnType("text");

                    b.Property<int?>("Remote_Consultation_Charges")
                        .HasColumnType("integer");

                    b.Property<List<string>>("Specializations")
                        .HasColumnType("text[]");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("__typeName")
                        .HasColumnType("text");

                    b.Property<bool?>("_deleted")
                        .HasColumnType("boolean");

                    b.Property<long?>("_lastChangedAt")
                        .HasColumnType("bigint");

                    b.Property<int?>("_version")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("entityVerified")
                        .HasColumnType("boolean");

                    b.Property<string>("managerLocationId")
                        .HasColumnType("text");

                    b.Property<DateTime?>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("MypulseWebapi.Models.Message", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ChatSessionId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SenderId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("__typeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("_lastChangedAt")
                        .HasColumnType("bigint");

                    b.Property<int>("_version")
                        .HasColumnType("integer");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ChatSessionId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("MypulseWebapi.Models.Notification", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<bool>("IsSeen")
                        .HasColumnType("boolean");

                    b.Property<string>("ManagerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("MypulseWebapi.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<List<string>>("AvatarS3Key")
                        .HasColumnType("text[]");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("CognitoUserId")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool?>("Email_Verified")
                        .HasColumnType("boolean");

                    b.Property<List<string>>("KnownInterests")
                        .HasColumnType("text[]");

                    b.Property<string>("Latitude")
                        .HasColumnType("text");

                    b.Property<string>("LocationId")
                        .HasColumnType("text");

                    b.Property<string>("Longitude")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone_Number")
                        .HasColumnType("text");

                    b.Property<bool?>("Phone_Number_Verified")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("__typeName")
                        .HasColumnType("text");

                    b.Property<long?>("_lastChangedAt")
                        .HasColumnType("bigint");

                    b.Property<int?>("_version")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("entityVerified")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("userHealthInfoId")
                        .HasColumnType("text");

                    b.Property<string>("userLocationId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DepartmentManager", b =>
                {
                    b.HasOne("MypulseWebapi.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MypulseWebapi.Models.Manager", null)
                        .WithMany()
                        .HasForeignKey("ManagersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityManagerManager", b =>
                {
                    b.HasOne("MypulseWebapi.Models.EntityManager", null)
                        .WithMany()
                        .HasForeignKey("EntityManagersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MypulseWebapi.Models.Manager", null)
                        .WithMany()
                        .HasForeignKey("ManagersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityManagerUser", b =>
                {
                    b.HasOne("MypulseWebapi.Models.EntityManager", null)
                        .WithMany()
                        .HasForeignKey("EntityManagersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MypulseWebapi.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ManagerUser", b =>
                {
                    b.HasOne("MypulseWebapi.Models.Manager", null)
                        .WithMany()
                        .HasForeignKey("ManagersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MypulseWebapi.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MypulseWebapi.Models.Appointment", b =>
                {
                    b.HasOne("MypulseWebapi.Models.EntityManager", "EntityManager")
                        .WithMany("Appointments")
                        .HasForeignKey("EntityManagerId");

                    b.HasOne("MypulseWebapi.Models.Manager", "Manager")
                        .WithMany("Appointments")
                        .HasForeignKey("ManagerId");

                    b.HasOne("MypulseWebapi.Models.User", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserId");

                    b.Navigation("EntityManager");

                    b.Navigation("Manager");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MypulseWebapi.Models.Availability", b =>
                {
                    b.HasOne("MypulseWebapi.Models.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("MypulseWebapi.Models.ChatSession", b =>
                {
                    b.HasOne("MypulseWebapi.Models.Manager", "Manager")
                        .WithMany("ChatSessions")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MypulseWebapi.Models.User", "User")
                        .WithMany("ChatSessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MypulseWebapi.Models.Department", b =>
                {
                    b.HasOne("MypulseWebapi.Models.EntityManager", "EntityManager")
                        .WithMany("Departments")
                        .HasForeignKey("EntityManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityManager");
                });

            modelBuilder.Entity("MypulseWebapi.Models.EntityManager", b =>
                {
                    b.HasOne("MypulseWebapi.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("MypulseWebapi.Models.HealthInfo", b =>
                {
                    b.HasOne("MypulseWebapi.Models.User", "User")
                        .WithOne("HealthInfo")
                        .HasForeignKey("MypulseWebapi.Models.HealthInfo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MypulseWebapi.Models.License", b =>
                {
                    b.HasOne("MypulseWebapi.Models.EntityManager", "EntityManager")
                        .WithMany("Licenses")
                        .HasForeignKey("EntityManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityManager");
                });

            modelBuilder.Entity("MypulseWebapi.Models.Manager", b =>
                {
                    b.HasOne("MypulseWebapi.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("MypulseWebapi.Models.Message", b =>
                {
                    b.HasOne("MypulseWebapi.Models.ChatSession", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatSessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MypulseWebapi.Models.Notification", b =>
                {
                    b.HasOne("MypulseWebapi.Models.Manager", null)
                        .WithMany("Notifications")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MypulseWebapi.Models.User", null)
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MypulseWebapi.Models.User", b =>
                {
                    b.HasOne("MypulseWebapi.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("MypulseWebapi.Models.ChatSession", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("MypulseWebapi.Models.EntityManager", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Departments");

                    b.Navigation("Licenses");
                });

            modelBuilder.Entity("MypulseWebapi.Models.Manager", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("ChatSessions");

                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("MypulseWebapi.Models.User", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("ChatSessions");

                    b.Navigation("HealthInfo");

                    b.Navigation("Notifications");
                });
#pragma warning restore 612, 618
        }
    }
}
