using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using UI.MVC.Data;

namespace UI.MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain_Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Domain_Entities.Card", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("ClientId");

                    b.Property<decimal>("CursValutarStabilit");

                    b.Property<DateTime>("DataTranzactie");

                    b.Property<string>("DenumireCard");

                    b.Property<int>("NumarBonFiscal");

                    b.Property<string>("NumarCard");

                    b.Property<int>("NumarChitantaSchimbValutar");

                    b.Property<string>("SerieChitantaSchimbValutar");

                    b.Property<int>("SumaTranzactionata");

                    b.Property<decimal>("ValoareLei");

                    b.Property<string>("Valuta");

                    b.HasKey("Id");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("Domain_Entities.Casier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AccesEmployee");

                    b.Property<bool>("AccesManager");

                    b.Property<bool>("AccesOwner");

                    b.Property<string>("CNP");

                    b.Property<string>("Email");

                    b.Property<string>("Nume");

                    b.Property<string>("Password");

                    b.Property<string>("Prenume");

                    b.HasKey("Id");

                    b.ToTable("Casier");
                });

            modelBuilder.Entity("Domain_Entities.Client", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("CodTara");

                    b.Property<string>("DenumireTara");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsNigger");

                    b.Property<bool>("IsOwner");

                    b.Property<int>("NumarDocumentIdentitate");

                    b.Property<string>("Nume");

                    b.Property<string>("Prenume");

                    b.Property<string>("SerieDocumentIdentitate");

                    b.Property<string>("TipDocumentIdentitate");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Domain_Entities.Curs", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("AcronimValuta");

                    b.Property<bool>("ActualizareValuta");

                    b.Property<Guid>("CasierId");

                    b.Property<decimal>("CursCumparare");

                    b.Property<decimal>("CursOficialBnr");

                    b.Property<decimal>("CursVanzare");

                    b.Property<DateTime>("DataCurs");

                    b.Property<string>("DenumireValuta");

                    b.Property<int>("Multiplu");

                    b.Property<int>("NumarCurentValuta");

                    b.Property<int>("NumarLista");

                    b.Property<decimal>("ParitateEuro");

                    b.Property<string>("PozitieValuta");

                    b.Property<int>("SoldCurentValuta");

                    b.Property<string>("TipValuta");

                    b.HasKey("Id");

                    b.ToTable("Curs");
                });

            modelBuilder.Entity("Domain_Entities.Operatie", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("AcronimValuta");

                    b.Property<int>("AdaosRealizat");

                    b.Property<int>("AdaosRelativ");

                    b.Property<string>("CalitateClient");

                    b.Property<int>("CodTaraClient");

                    b.Property<int>("CursOficialBnr");

                    b.Property<int>("CursValutarStabilit");

                    b.Property<DateTime>("DataOperatiune");

                    b.Property<string>("DenumireTaraClient");

                    b.Property<string>("InstrumentPlata");

                    b.Property<int>("Multiplu");

                    b.Property<int>("NumarCurentChitanta");

                    b.Property<int>("NumarDocument");

                    b.Property<int>("NumarDocumentIdentitate");

                    b.Property<int>("NumarLista");

                    b.Property<int>("NumarRaportZ");

                    b.Property<string>("NumePrenumeClient");

                    b.Property<decimal>("ParitateEuro");

                    b.Property<int>("ProcentComisionCard");

                    b.Property<int>("ProcentComisionCec");

                    b.Property<string>("SerieChitanta");

                    b.Property<string>("SerieDocumentIdentitate");

                    b.Property<int>("SoldPrecedent");

                    b.Property<string>("StareOperatiuneTranzactie");

                    b.Property<int>("SumaValuta");

                    b.Property<string>("TipDocumentIdentitate");

                    b.Property<int>("ValoareComision");

                    b.Property<int>("ValoareLei");

                    b.Property<int>("ValoareSpeze");

                    b.HasKey("Id");

                    b.ToTable("Operatie");
                });

            modelBuilder.Entity("Domain_Entities.Tara", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Cod");

                    b.Property<string>("Denumire");

                    b.Property<int>("TotalCumparariEuro");

                    b.Property<int>("TotalVanzariEuro");

                    b.HasKey("Id");

                    b.ToTable("Tara");
                });

            modelBuilder.Entity("Domain_Entities.Valuta", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("AcronimValuta");

                    b.Property<string>("DenumireValuta");

                    b.Property<int>("Multiplu");

                    b.Property<int>("NumarCurentValuta");

                    b.Property<int>("PozitieValuta");

                    b.Property<string>("TipValuta");

                    b.HasKey("Id");

                    b.ToTable("Valuta");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("UI.MVC.Models.CursValutar", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("BuyingEuroToRon");

                    b.Property<float>("BuyingGbpToRon");

                    b.Property<float>("BuyingUsdToRon");

                    b.Property<bool>("IsDeleted");

                    b.Property<float>("SellingEuroToRon");

                    b.Property<float>("SellingGbpToRon");

                    b.Property<float>("SellingUsdToRon");

                    b.HasKey("Id");

                    b.ToTable("CursValutar");
                });

            modelBuilder.Entity("UI.MVC.Models.Tranzactie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActIdentitate");

                    b.Property<string>("Cnp")
                        .IsRequired();

                    b.Property<int>("Din");

                    b.Property<int>("In");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Numarul")
                        .IsRequired();

                    b.Property<string>("Seria")
                        .IsRequired();

                    b.Property<decimal>("SumaDatorata");

                    b.Property<decimal>("SumaTranzationata");

                    b.Property<int>("TipOperatie");

                    b.HasKey("Id");

                    b.ToTable("Tranzactii");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain_Entities.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain_Entities.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain_Entities.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
