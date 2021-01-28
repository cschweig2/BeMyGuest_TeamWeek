﻿// <auto-generated />
using System;
using BeMyGuest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeMyGuest.Migrations
{
    [DbContext(typeof(BeMyGuestContext))]
    partial class BeMyGuestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BeMyGuest.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BeMyGuest.Models.CovidData", b =>
                {
                    b.Property<int>("CovidDataId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AgeAnswer");

                    b.Property<bool>("Cough");

                    b.Property<string>("Explanation");

                    b.Property<bool>("Fever");

                    b.Property<int>("GuestCovidInfoId");

                    b.Property<string>("Question");

                    b.Property<string>("SexAnswer");

                    b.Property<bool>("Sob");

                    b.Property<string>("UserId");

                    b.Property<bool>("YesNo");

                    b.HasKey("CovidDataId");

                    b.HasIndex("UserId");

                    b.ToTable("CovidDataSet");
                });

            modelBuilder.Entity("BeMyGuest.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("EndTime");

                    b.Property<DateTime?>("EventDate");

                    b.Property<string>("EventTitle");

                    b.Property<bool>("MaskRequirements");

                    b.Property<string>("QuarantineRequirements");

                    b.Property<DateTime?>("StartTime");

                    b.Property<string>("UserId");

                    b.Property<string>("Venue");

                    b.Property<string>("VenueAddress");

                    b.Property<string>("VenueRequirements");

                    b.HasKey("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("BeMyGuest.Models.Gathering", b =>
                {
                    b.Property<int>("GatheringId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EventId");

                    b.Property<int?>("GuestId");

                    b.Property<int?>("HostId");

                    b.HasKey("GatheringId");

                    b.HasIndex("EventId");

                    b.HasIndex("GuestId");

                    b.HasIndex("HostId");

                    b.ToTable("Gathering");
                });

            modelBuilder.Entity("BeMyGuest.Models.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AlcoholFree");

                    b.Property<string>("Allergies");

                    b.Property<bool>("CompletedQuestionnaire");

                    b.Property<int?>("CovidDataId");

                    b.Property<string>("DietaryRestrictions");

                    b.Property<string>("Email");

                    b.Property<bool>("HighRisk");

                    b.Property<string>("MedicalConditions");

                    b.Property<string>("MedicalMobilityNeeds");

                    b.Property<string>("Name");

                    b.Property<bool>("NotAHugger");

                    b.Property<bool>("PlusOne");

                    b.Property<string>("PreferredLanguage");

                    b.Property<string>("Pronouns");

                    b.Property<bool>("RecentTravel");

                    b.Property<bool>("ServiceAnimal");

                    b.Property<bool>("SmallChildren");

                    b.Property<string>("UserId");

                    b.Property<bool>("Vaccinated");

                    b.HasKey("GuestId");

                    b.HasIndex("CovidDataId");

                    b.HasIndex("UserId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("BeMyGuest.Models.Host", b =>
                {
                    b.Property<int>("HostId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HostEmail");

                    b.Property<string>("HostName");

                    b.Property<string>("UserId");

                    b.HasKey("HostId");

                    b.HasIndex("UserId");

                    b.ToTable("Hosts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BeMyGuest.Models.CovidData", b =>
                {
                    b.HasOne("BeMyGuest.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BeMyGuest.Models.Event", b =>
                {
                    b.HasOne("BeMyGuest.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BeMyGuest.Models.Gathering", b =>
                {
                    b.HasOne("BeMyGuest.Models.Event", "Event")
                        .WithMany("JoinEntries")
                        .HasForeignKey("EventId");

                    b.HasOne("BeMyGuest.Models.Guest", "Guest")
                        .WithMany("JoinEntries")
                        .HasForeignKey("GuestId");

                    b.HasOne("BeMyGuest.Models.Host", "Host")
                        .WithMany("JoinEntries")
                        .HasForeignKey("HostId");
                });

            modelBuilder.Entity("BeMyGuest.Models.Guest", b =>
                {
                    b.HasOne("BeMyGuest.Models.CovidData", "CovidData")
                        .WithMany("Guests")
                        .HasForeignKey("CovidDataId");

                    b.HasOne("BeMyGuest.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BeMyGuest.Models.Host", b =>
                {
                    b.HasOne("BeMyGuest.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BeMyGuest.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BeMyGuest.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BeMyGuest.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BeMyGuest.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
