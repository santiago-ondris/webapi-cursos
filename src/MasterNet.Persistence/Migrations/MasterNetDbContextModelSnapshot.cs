﻿// <auto-generated />
using System;
using MasterNet.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MasterNet.Persistence.Migrations
{
    [DbContext(typeof(MasterNetDbContext))]
    partial class MasterNetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4");

            modelBuilder.Entity("MasterNet.Domain.Calificacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Alumno")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comentario")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Puntaje")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("calificaciones", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.Curso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FechaPublicacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("cursos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("edd65d29-27aa-4e2e-b385-1a096770716d"),
                            Descripcion = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            FechaPublicacion = new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(3762),
                            Titulo = "Tasty Frozen Pizza"
                        },
                        new
                        {
                            Id = new Guid("c90b1259-ccbe-42d9-9e80-f0c16c335841"),
                            Descripcion = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            FechaPublicacion = new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(3821),
                            Titulo = "Rustic Plastic Chips"
                        },
                        new
                        {
                            Id = new Guid("21d1504e-3cfc-4801-a1c9-fcb8e50228ab"),
                            Descripcion = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            FechaPublicacion = new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(3879),
                            Titulo = "Intelligent Rubber Hat"
                        },
                        new
                        {
                            Id = new Guid("23706472-d6b8-4f35-8f06-53c6e9810855"),
                            Descripcion = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            FechaPublicacion = new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(3922),
                            Titulo = "Fantastic Metal Hat"
                        },
                        new
                        {
                            Id = new Guid("7c75e3dd-1565-43a3-ba8d-c185949ea648"),
                            Descripcion = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            FechaPublicacion = new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(3967),
                            Titulo = "Gorgeous Concrete Computer"
                        },
                        new
                        {
                            Id = new Guid("b0b23293-2b3a-434c-b8d4-16ffec6f4bc0"),
                            Descripcion = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            FechaPublicacion = new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(4013),
                            Titulo = "Handmade Cotton Shirt"
                        },
                        new
                        {
                            Id = new Guid("1babafa4-a44d-4b1d-aca0-0f33df26fdb5"),
                            Descripcion = "The Football Is Good For Training And Recreational Purposes",
                            FechaPublicacion = new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(4056),
                            Titulo = "Intelligent Granite Tuna"
                        },
                        new
                        {
                            Id = new Guid("eabd484f-f816-411a-bcef-3cb3d3f54123"),
                            Descripcion = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            FechaPublicacion = new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(4099),
                            Titulo = "Small Metal Keyboard"
                        },
                        new
                        {
                            Id = new Guid("618222a1-9c44-408d-a183-37470e107b3e"),
                            Descripcion = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            FechaPublicacion = new DateTime(2024, 10, 10, 1, 30, 53, 208, DateTimeKind.Utc).AddTicks(4148),
                            Titulo = "Intelligent Plastic Mouse"
                        });
                });

            modelBuilder.Entity("MasterNet.Domain.CursoInstructor", b =>
                {
                    b.Property<Guid>("InstructorId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("TEXT");

                    b.HasKey("InstructorId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("cursos_instructores", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.CursoPrecio", b =>
                {
                    b.Property<Guid>("PrecioId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("TEXT");

                    b.HasKey("PrecioId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("cursos_precios", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.Instructor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Grado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("instructores", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("86c2d0c2-d98e-46f1-bb6e-3c11f9ca0f1b"),
                            Apellidos = "Ondricka",
                            Grado = "Human Branding Planner",
                            Nombre = "Madonna"
                        },
                        new
                        {
                            Id = new Guid("5e02e426-6ce1-401b-ae5f-d6510daae6d0"),
                            Apellidos = "Hauck",
                            Grado = "Chief Branding Officer",
                            Nombre = "Omer"
                        },
                        new
                        {
                            Id = new Guid("a9cd61bb-cca4-4ffb-ace4-53911ecabfb7"),
                            Apellidos = "Wilkinson",
                            Grado = "Principal Accounts Orchestrator",
                            Nombre = "Queenie"
                        },
                        new
                        {
                            Id = new Guid("5dd7d6af-92d1-4a3c-b78b-670c061a22ea"),
                            Apellidos = "Roob",
                            Grado = "Internal Marketing Designer",
                            Nombre = "Angelo"
                        },
                        new
                        {
                            Id = new Guid("2a074c62-f4ca-4919-b41f-aaede34a2a6f"),
                            Apellidos = "Rodriguez",
                            Grado = "Regional Program Designer",
                            Nombre = "Kip"
                        },
                        new
                        {
                            Id = new Guid("97cb265e-99d2-43b0-8d54-2ec2a4e46be4"),
                            Apellidos = "Ankunding",
                            Grado = "Corporate Accountability Designer",
                            Nombre = "Loyal"
                        },
                        new
                        {
                            Id = new Guid("3662dabb-5926-45d5-a7be-69143caa0c52"),
                            Apellidos = "Kuhn",
                            Grado = "Customer Solutions Strategist",
                            Nombre = "Nayeli"
                        },
                        new
                        {
                            Id = new Guid("e9895f7a-5862-44f6-b2e8-717e5f8eb29c"),
                            Apellidos = "Spinka",
                            Grado = "Human Program Agent",
                            Nombre = "Ettie"
                        },
                        new
                        {
                            Id = new Guid("125cd795-9bd6-46ec-8f2b-203bf9a0cde7"),
                            Apellidos = "Schultz",
                            Grado = "National Metrics Consultant",
                            Nombre = "Kobe"
                        },
                        new
                        {
                            Id = new Guid("190f9e81-55a0-47b6-8fed-e16f60b48306"),
                            Apellidos = "Walker",
                            Grado = "Central Markets Strategist",
                            Nombre = "Darian"
                        });
                });

            modelBuilder.Entity("MasterNet.Domain.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("imagenes", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.Precio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("PrecioActual")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioPromocion")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("precios", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3ae00121-bac7-45c3-b8c5-9cfefe70c62e"),
                            Nombre = "Precio Regular",
                            PrecioActual = 10.0m,
                            PrecioPromocion = 8.0m
                        });
                });

            modelBuilder.Entity("MasterNet.Persistence.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Carrera")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e7737264-30a3-4ac2-9044-7e843e501c57",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "27f5efa1-a70c-4029-a383-af280334b6ca",
                            Name = "CLIENT",
                            NormalizedName = "CLIENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_READ",
                            RoleId = "e7737264-30a3-4ac2-9044-7e843e501c57"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_UPDATE",
                            RoleId = "e7737264-30a3-4ac2-9044-7e843e501c57"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_WRITE",
                            RoleId = "e7737264-30a3-4ac2-9044-7e843e501c57"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_DELETE",
                            RoleId = "e7737264-30a3-4ac2-9044-7e843e501c57"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_CREATE",
                            RoleId = "e7737264-30a3-4ac2-9044-7e843e501c57"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "e7737264-30a3-4ac2-9044-7e843e501c57"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_UPDATE",
                            RoleId = "e7737264-30a3-4ac2-9044-7e843e501c57"
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_CREATE",
                            RoleId = "e7737264-30a3-4ac2-9044-7e843e501c57"
                        },
                        new
                        {
                            Id = 9,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_DELETE",
                            RoleId = "e7737264-30a3-4ac2-9044-7e843e501c57"
                        },
                        new
                        {
                            Id = 10,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_READ",
                            RoleId = "e7737264-30a3-4ac2-9044-7e843e501c57"
                        },
                        new
                        {
                            Id = 11,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_READ",
                            RoleId = "27f5efa1-a70c-4029-a383-af280334b6ca"
                        },
                        new
                        {
                            Id = 12,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "27f5efa1-a70c-4029-a383-af280334b6ca"
                        },
                        new
                        {
                            Id = 13,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_READ",
                            RoleId = "27f5efa1-a70c-4029-a383-af280334b6ca"
                        },
                        new
                        {
                            Id = 14,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_CREATE",
                            RoleId = "27f5efa1-a70c-4029-a383-af280334b6ca"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.Calificacion", b =>
                {
                    b.HasOne("MasterNet.Domain.Curso", "Curso")
                        .WithMany("Calificaciones")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("MasterNet.Domain.CursoInstructor", b =>
                {
                    b.HasOne("MasterNet.Domain.Curso", "Curso")
                        .WithMany("CursoInstructores")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MasterNet.Domain.Instructor", "Instructor")
                        .WithMany("CursoInstructores")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("MasterNet.Domain.CursoPrecio", b =>
                {
                    b.HasOne("MasterNet.Domain.Curso", "Curso")
                        .WithMany("CursoPrecios")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MasterNet.Domain.Precio", "Precio")
                        .WithMany("CursoPrecios")
                        .HasForeignKey("PrecioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Precio");
                });

            modelBuilder.Entity("MasterNet.Domain.Photo", b =>
                {
                    b.HasOne("MasterNet.Domain.Curso", "Curso")
                        .WithMany("Photos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
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
                    b.HasOne("MasterNet.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MasterNet.Persistence.Models.AppUser", null)
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

                    b.HasOne("MasterNet.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MasterNet.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MasterNet.Domain.Curso", b =>
                {
                    b.Navigation("Calificaciones");

                    b.Navigation("CursoInstructores");

                    b.Navigation("CursoPrecios");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("MasterNet.Domain.Instructor", b =>
                {
                    b.Navigation("CursoInstructores");
                });

            modelBuilder.Entity("MasterNet.Domain.Precio", b =>
                {
                    b.Navigation("CursoPrecios");
                });
#pragma warning restore 612, 618
        }
    }
}
