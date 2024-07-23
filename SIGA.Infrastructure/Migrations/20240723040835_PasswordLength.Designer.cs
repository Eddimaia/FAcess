﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SIGA.Infrastructure.Context;

#nullable disable

namespace SIGA.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240723040835_PasswordLength")]
    partial class PasswordLength
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SIGA.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DATETIME2(0)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("DATETIMEOFFSET");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("BIT");

                    b.Property<bool>("IsEmployed")
                        .HasColumnType("BIT");

                    b.Property<bool>("IsPhoneNumberConfirmed")
                        .HasColumnType("BIT");

                    b.Property<bool>("IsProjectCoordinator")
                        .HasColumnType("BIT");

                    b.Property<DateTimeOffset?>("LastLoginDate")
                        .HasColumnType("DATETIMEOFFSET");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Login")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("ApplicationUser", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Claim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("Claim", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Acronym")
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.DatabaseAccess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("INT");

                    b.Property<byte>("DataBaseTypeId")
                        .HasColumnType("TINYINT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("DataBaseTypeId");

                    b.ToTable("DatabaseAccess", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.DatabaseType", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TINYINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("DatabaseType", (string)null);

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            Name = "SqlServer"
                        },
                        new
                        {
                            Id = (byte)2,
                            Name = "PostgreSql"
                        },
                        new
                        {
                            Id = (byte)3,
                            Name = "MySql"
                        },
                        new
                        {
                            Id = (byte)4,
                            Name = "OracleDb"
                        },
                        new
                        {
                            Id = (byte)6,
                            Name = "MongoDb"
                        });
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Acronym")
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("Project", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Relations.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicationUserId")
                        .HasColumnType("INT");

                    b.Property<int>("ClaimId")
                        .HasColumnType("INT");

                    b.Property<int>("RolesId")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ClaimId");

                    b.HasIndex("RolesId");

                    b.ToTable("ApplicationUserClaim", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Relations.ApplicationUserProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicationUserId")
                        .HasColumnType("INT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ApplicationUserProject", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Relations.ApplicationUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicationUserId")
                        .HasColumnType("INT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("RoleId");

                    b.ToTable("ApplicationUserRole", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Relations.ClientProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("INT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ClientProject", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Relations.CoordinatorProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicationUserId")
                        .HasColumnType("INT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INT");

                    b.Property<int?>("ProjectId1")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ProjectId1");

                    b.ToTable("CoordinatorProject", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Relations.DatabaseAcessProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DatabaseAccessId")
                        .HasColumnType("INT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INT");

                    b.Property<int?>("ProjectId1")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("DatabaseAccessId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ProjectId1");

                    b.ToTable("DatabaseAcessProject", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Vpn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("INT");

                    b.Property<string>("Domain")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("IconPath")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Vpn", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.VpnAccess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicationUserId")
                        .HasColumnType("INT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<int>("VpnId")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("VpnId");

                    b.ToTable("VpnAccess", (string)null);
                });

            modelBuilder.Entity("SIGA.Domain.Entities.DatabaseAccess", b =>
                {
                    b.HasOne("SIGA.Domain.Entities.Client", "Client")
                        .WithMany("DatabaseAccesses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_DatabseAccess_Client");

                    b.HasOne("SIGA.Domain.Entities.DatabaseType", "DatabaseType")
                        .WithMany("DatabaseAccesses")
                        .HasForeignKey("DataBaseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DatabseAccess_DatabaseType");

                    b.Navigation("Client");

                    b.Navigation("DatabaseType");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Relations.ApplicationUserClaim", b =>
                {
                    b.HasOne("SIGA.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("UserClaims")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_UserClaim_ApplicationUser");

                    b.HasOne("SIGA.Domain.Entities.Claim", "Claim")
                        .WithMany("UserClaims")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_UserClaim_Claim");

                    b.HasOne("SIGA.Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Claim");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Relations.ApplicationUserProject", b =>
                {
                    b.HasOne("SIGA.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("UserProjects")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_UserProject_ApplicationUser");

                    b.HasOne("SIGA.Domain.Entities.Project", "Project")
                        .WithMany("UserProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_UserProject_Project");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Relations.ApplicationUserRole", b =>
                {
                    b.HasOne("SIGA.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("UserRoles")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_UserRoleMapper_ApplicationUser");

                    b.HasOne("SIGA.Domain.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_UserRoleMapper_Role");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Relations.ClientProject", b =>
                {
                    b.HasOne("SIGA.Domain.Entities.Client", "Client")
                        .WithMany("ClientProjects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ClientProject_Client");

                    b.HasOne("SIGA.Domain.Entities.Project", "Project")
                        .WithMany("ClientProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ClientProject_Project");

                    b.Navigation("Client");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Relations.CoordinatorProject", b =>
                {
                    b.HasOne("SIGA.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("CoordinatorsProjects")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CoordinatorProject_ApplicationUser");

                    b.HasOne("SIGA.Domain.Entities.Project", "Project")
                        .WithMany("CoordinatorsProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CoordinatorProject_Project");

                    b.HasOne("SIGA.Domain.Entities.Project", null)
                        .WithMany("CoordinatorProjects")
                        .HasForeignKey("ProjectId1");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Relations.DatabaseAcessProject", b =>
                {
                    b.HasOne("SIGA.Domain.Entities.DatabaseAccess", "DatabaseAccess")
                        .WithMany("DatabaseAcessProjects")
                        .HasForeignKey("DatabaseAccessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DatabaseAcessProject_DatabaseAccess");

                    b.HasOne("SIGA.Domain.Entities.Project", "Project")
                        .WithMany("DatabaseAcessProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DatabaseAcessProject_Project");

                    b.HasOne("SIGA.Domain.Entities.Project", null)
                        .WithMany("DatabaseAccessProjects")
                        .HasForeignKey("ProjectId1");

                    b.Navigation("DatabaseAccess");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Vpn", b =>
                {
                    b.HasOne("SIGA.Domain.Entities.Client", "Client")
                        .WithMany("Vpns")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_VPN_CLIENT");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.VpnAccess", b =>
                {
                    b.HasOne("SIGA.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("VpnAccesses")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_VpnAccess_ApplicationUser");

                    b.HasOne("SIGA.Domain.Entities.Vpn", "Vpn")
                        .WithMany("VpnAccesses")
                        .HasForeignKey("VpnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_VpnAccess_Vpn");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Vpn");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.ApplicationUser", b =>
                {
                    b.Navigation("CoordinatorsProjects");

                    b.Navigation("UserClaims");

                    b.Navigation("UserProjects");

                    b.Navigation("UserRoles");

                    b.Navigation("VpnAccesses");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Claim", b =>
                {
                    b.Navigation("UserClaims");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Client", b =>
                {
                    b.Navigation("ClientProjects");

                    b.Navigation("DatabaseAccesses");

                    b.Navigation("Vpns");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.DatabaseAccess", b =>
                {
                    b.Navigation("DatabaseAcessProjects");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.DatabaseType", b =>
                {
                    b.Navigation("DatabaseAccesses");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Project", b =>
                {
                    b.Navigation("ClientProjects");

                    b.Navigation("CoordinatorProjects");

                    b.Navigation("CoordinatorsProjects");

                    b.Navigation("DatabaseAccessProjects");

                    b.Navigation("DatabaseAcessProjects");

                    b.Navigation("UserProjects");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("SIGA.Domain.Entities.Vpn", b =>
                {
                    b.Navigation("VpnAccesses");
                });
#pragma warning restore 612, 618
        }
    }
}
