﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestingAppQa.Data;

namespace TestingAppQa.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TestingAppQa.Models.ConsolidationReport", b =>
                {
                    b.Property<int>("IdTimeOut")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnalistaId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DesarrolladorId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("EstadoReporte")
                        .HasColumnType("longtext");

                    b.Property<string>("EstadoTarea")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaReporte")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaSolucion")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("HUIdUserHistory")
                        .HasColumnType("int");

                    b.Property<int?>("UserHistoryIdUserHistory")
                        .HasColumnType("int");

                    b.HasKey("IdTimeOut");

                    b.HasIndex("AnalistaId");

                    b.HasIndex("DesarrolladorId");

                    b.HasIndex("HUIdUserHistory");

                    b.HasIndex("UserHistoryIdUserHistory");

                    b.ToTable("ConsolidationReport");
                });

            modelBuilder.Entity("TestingAppQa.Models.Metrics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Analista")
                        .HasColumnType("longtext");

                    b.Property<int>("CantidadReportadosAnalista")
                        .HasColumnType("int");

                    b.Property<int>("CantidadTareasDesarrollador")
                        .HasColumnType("int");

                    b.Property<string>("Desarrollador")
                        .HasColumnType("longtext");

                    b.Property<int>("cantidadexitosas")
                        .HasColumnType("int");

                    b.Property<int>("cantidadnoexitosas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Metrics");
                });

            modelBuilder.Entity("TestingAppQa.Models.Project", b =>
                {
                    b.Property<int>("IdProject")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.HasKey("IdProject");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("TestingAppQa.Models.ProjectUser", b =>
                {
                    b.Property<int>("IdRolUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IdRol")
                        .HasColumnType("longtext");

                    b.Property<int?>("ProjectIdProject")
                        .HasColumnType("int");

                    b.Property<int?>("RolsId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdRolUser");

                    b.HasIndex("ProjectIdProject");

                    b.HasIndex("RolsId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectUser");
                });

            modelBuilder.Entity("TestingAppQa.Models.Risk", b =>
                {
                    b.Property<int>("IdRisk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MitigationStrategy")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("RiskDependency")
                        .HasColumnType("longtext");

                    b.Property<int?>("UserHistoryIdUserHistory")
                        .HasColumnType("int");

                    b.Property<int?>("UserHistoryIdUserHistory1")
                        .HasColumnType("int");

                    b.HasKey("IdRisk");

                    b.HasIndex("UserHistoryIdUserHistory");

                    b.HasIndex("UserHistoryIdUserHistory1");

                    b.ToTable("Risk");
                });

            modelBuilder.Entity("TestingAppQa.Models.Rols", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Rols");
                });

            modelBuilder.Entity("TestingAppQa.Models.Scope", b =>
                {
                    b.Property<int>("IdScope")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Considerations")
                        .HasColumnType("longtext");

                    b.Property<string>("NameModule")
                        .HasColumnType("longtext");

                    b.Property<string>("TestGoal")
                        .HasColumnType("longtext");

                    b.Property<int?>("UserHistoryIdUserHistory")
                        .HasColumnType("int");

                    b.Property<int?>("UserHistoryIdUserHistory1")
                        .HasColumnType("int");

                    b.HasKey("IdScope");

                    b.HasIndex("UserHistoryIdUserHistory");

                    b.HasIndex("UserHistoryIdUserHistory1");

                    b.ToTable("Scope");
                });

            modelBuilder.Entity("TestingAppQa.Models.Sprint", b =>
                {
                    b.Property<int>("IdSprint")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("ProjectIdProject")
                        .HasColumnType("int");

                    b.HasKey("IdSprint");

                    b.HasIndex("ProjectIdProject");

                    b.ToTable("Sprint");
                });

            modelBuilder.Entity("TestingAppQa.Models.TaskReview", b =>
                {
                    b.Property<int>("IdTask")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateComplete")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("DeveloperId")
                        .HasColumnType("longtext");

                    b.Property<int?>("HistoryIdUserHistory")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectIdProject")
                        .HasColumnType("int");

                    b.Property<string>("ReponsabilityUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ReportState")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.Property<string>("TaskState")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<int?>("UserHistoryIdUserHistory")
                        .HasColumnType("int");

                    b.HasKey("IdTask");

                    b.HasIndex("HistoryIdUserHistory");

                    b.HasIndex("ProjectIdProject");

                    b.HasIndex("ReponsabilityUserId");

                    b.HasIndex("UserHistoryIdUserHistory");

                    b.ToTable("TaskReview");
                });

            modelBuilder.Entity("TestingAppQa.Models.TestCase", b =>
                {
                    b.Property<int>("IdTestCase")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Analyst")
                        .HasColumnType("longtext");

                    b.Property<int?>("HistoryUserIdUserHistory")
                        .HasColumnType("int");

                    b.Property<string>("StepStep")
                        .HasColumnType("longtext");

                    b.Property<string>("TestType")
                        .HasColumnType("longtext");

                    b.Property<int?>("UserHistoryIdUserHistory")
                        .HasColumnType("int");

                    b.Property<string>("Var")
                        .HasColumnType("longtext");

                    b.HasKey("IdTestCase");

                    b.HasIndex("HistoryUserIdUserHistory");

                    b.HasIndex("UserHistoryIdUserHistory");

                    b.ToTable("TestCase");
                });

            modelBuilder.Entity("TestingAppQa.Models.TimeOut", b =>
                {
                    b.Property<int>("IdTimeOut")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("HuIdUserHistory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("UserHistoryIdUserHistory")
                        .HasColumnType("int");

                    b.HasKey("IdTimeOut");

                    b.HasIndex("HuIdUserHistory");

                    b.HasIndex("UserHistoryIdUserHistory");

                    b.ToTable("TimeOut");
                });

            modelBuilder.Entity("TestingAppQa.Models.Tools", b =>
                {
                    b.Property<int>("IdTool")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Specification")
                        .HasColumnType("longtext");

                    b.Property<int?>("UserHistoryIdUserHistory")
                        .HasColumnType("int");

                    b.Property<int?>("UserHistoryIdUserHistory1")
                        .HasColumnType("int");

                    b.Property<string>("Version")
                        .HasColumnType("longtext");

                    b.HasKey("IdTool");

                    b.HasIndex("UserHistoryIdUserHistory");

                    b.HasIndex("UserHistoryIdUserHistory1");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("TestingAppQa.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("IdHUActive")
                        .HasColumnType("int");

                    b.Property<int>("IdProjectActive")
                        .HasColumnType("int");

                    b.Property<int>("IdSprintActive")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Pass")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TestingAppQa.Models.UserHistory", b =>
                {
                    b.Property<int>("IdUserHistory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescriptionTestType")
                        .HasColumnType("longtext");

                    b.Property<string>("IWant")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("SprintHistoryUserIdSprint")
                        .HasColumnType("int");

                    b.Property<string>("TestType")
                        .HasColumnType("longtext");

                    b.Property<string>("Then")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("Where")
                        .HasColumnType("longtext");

                    b.HasKey("IdUserHistory");

                    b.HasIndex("SprintHistoryUserIdSprint");

                    b.ToTable("UserHistory");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TestingAppQa.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TestingAppQa.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestingAppQa.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TestingAppQa.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestingAppQa.Models.ConsolidationReport", b =>
                {
                    b.HasOne("TestingAppQa.Models.User", "Analista")
                        .WithMany()
                        .HasForeignKey("AnalistaId");

                    b.HasOne("TestingAppQa.Models.User", "Desarrollador")
                        .WithMany()
                        .HasForeignKey("DesarrolladorId");

                    b.HasOne("TestingAppQa.Models.UserHistory", "HU")
                        .WithMany()
                        .HasForeignKey("HUIdUserHistory");

                    b.HasOne("TestingAppQa.Models.UserHistory", null)
                        .WithMany("Report")
                        .HasForeignKey("UserHistoryIdUserHistory")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Analista");

                    b.Navigation("Desarrollador");

                    b.Navigation("HU");
                });

            modelBuilder.Entity("TestingAppQa.Models.ProjectUser", b =>
                {
                    b.HasOne("TestingAppQa.Models.Project", "Project")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("ProjectIdProject");

                    b.HasOne("TestingAppQa.Models.Rols", null)
                        .WithMany("ProjectUsers")
                        .HasForeignKey("RolsId");

                    b.HasOne("TestingAppQa.Models.User", "User")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("UserId");

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestingAppQa.Models.Risk", b =>
                {
                    b.HasOne("TestingAppQa.Models.UserHistory", null)
                        .WithMany("Risks")
                        .HasForeignKey("UserHistoryIdUserHistory")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestingAppQa.Models.UserHistory", "UserHistory")
                        .WithMany()
                        .HasForeignKey("UserHistoryIdUserHistory1");

                    b.Navigation("UserHistory");
                });

            modelBuilder.Entity("TestingAppQa.Models.Scope", b =>
                {
                    b.HasOne("TestingAppQa.Models.UserHistory", null)
                        .WithMany("Scopes")
                        .HasForeignKey("UserHistoryIdUserHistory")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestingAppQa.Models.UserHistory", "UserHistory")
                        .WithMany()
                        .HasForeignKey("UserHistoryIdUserHistory1");

                    b.Navigation("UserHistory");
                });

            modelBuilder.Entity("TestingAppQa.Models.Sprint", b =>
                {
                    b.HasOne("TestingAppQa.Models.Project", "Project")
                        .WithMany("Sprints")
                        .HasForeignKey("ProjectIdProject");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("TestingAppQa.Models.TaskReview", b =>
                {
                    b.HasOne("TestingAppQa.Models.UserHistory", "History")
                        .WithMany()
                        .HasForeignKey("HistoryIdUserHistory");

                    b.HasOne("TestingAppQa.Models.Project", "Project")
                        .WithMany("TaskReviews")
                        .HasForeignKey("ProjectIdProject");

                    b.HasOne("TestingAppQa.Models.User", "ReponsabilityUser")
                        .WithMany("Tasks")
                        .HasForeignKey("ReponsabilityUserId");

                    b.HasOne("TestingAppQa.Models.UserHistory", null)
                        .WithMany("ReviewTask")
                        .HasForeignKey("UserHistoryIdUserHistory")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("History");

                    b.Navigation("Project");

                    b.Navigation("ReponsabilityUser");
                });

            modelBuilder.Entity("TestingAppQa.Models.TestCase", b =>
                {
                    b.HasOne("TestingAppQa.Models.UserHistory", "HistoryUser")
                        .WithMany()
                        .HasForeignKey("HistoryUserIdUserHistory");

                    b.HasOne("TestingAppQa.Models.UserHistory", null)
                        .WithMany("TestCases")
                        .HasForeignKey("UserHistoryIdUserHistory")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("HistoryUser");
                });

            modelBuilder.Entity("TestingAppQa.Models.TimeOut", b =>
                {
                    b.HasOne("TestingAppQa.Models.UserHistory", "Hu")
                        .WithMany()
                        .HasForeignKey("HuIdUserHistory");

                    b.HasOne("TestingAppQa.Models.UserHistory", null)
                        .WithMany("TimeOuts")
                        .HasForeignKey("UserHistoryIdUserHistory")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Hu");
                });

            modelBuilder.Entity("TestingAppQa.Models.Tools", b =>
                {
                    b.HasOne("TestingAppQa.Models.UserHistory", null)
                        .WithMany("Tools")
                        .HasForeignKey("UserHistoryIdUserHistory")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestingAppQa.Models.UserHistory", "UserHistory")
                        .WithMany()
                        .HasForeignKey("UserHistoryIdUserHistory1");

                    b.Navigation("UserHistory");
                });

            modelBuilder.Entity("TestingAppQa.Models.UserHistory", b =>
                {
                    b.HasOne("TestingAppQa.Models.Sprint", "SprintHistoryUser")
                        .WithMany("HistoryUsers")
                        .HasForeignKey("SprintHistoryUserIdSprint");

                    b.Navigation("SprintHistoryUser");
                });

            modelBuilder.Entity("TestingAppQa.Models.Project", b =>
                {
                    b.Navigation("ProjectUsers");

                    b.Navigation("Sprints");

                    b.Navigation("TaskReviews");
                });

            modelBuilder.Entity("TestingAppQa.Models.Rols", b =>
                {
                    b.Navigation("ProjectUsers");
                });

            modelBuilder.Entity("TestingAppQa.Models.Sprint", b =>
                {
                    b.Navigation("HistoryUsers");
                });

            modelBuilder.Entity("TestingAppQa.Models.User", b =>
                {
                    b.Navigation("ProjectUsers");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("TestingAppQa.Models.UserHistory", b =>
                {
                    b.Navigation("Report");

                    b.Navigation("ReviewTask");

                    b.Navigation("Risks");

                    b.Navigation("Scopes");

                    b.Navigation("TestCases");

                    b.Navigation("TimeOuts");

                    b.Navigation("Tools");
                });
#pragma warning restore 612, 618
        }
    }
}
