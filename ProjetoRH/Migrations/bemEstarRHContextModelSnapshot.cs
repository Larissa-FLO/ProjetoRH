﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoRH.Models;

#nullable disable

namespace ProjetoRH.Migrations
{
    [DbContext(typeof(bemEstarRHContext))]
    partial class bemEstarRHContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProjetoRH.Models.Administradore", b =>
                {
                    b.Property<int>("IdAdm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAdm"), 1L, 1);

                    b.Property<int?>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<int?>("IdFuncionarioNavigationIdFuncionario")
                        .HasColumnType("int");

                    b.HasKey("IdAdm");

                    b.HasIndex("IdFuncionarioNavigationIdFuncionario");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("ProjetoRH.Models.BancoTalento", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFuncionario"), 1L, 1);

                    b.Property<int>("Cep")
                        .HasColumnType("int");

                    b.Property<int?>("CodCargo")
                        .HasColumnType("int");

                    b.Property<int?>("CodCargoNavigationCodCargo")
                        .HasColumnType("int");

                    b.Property<int>("CodEntrevistador")
                        .HasColumnType("int");

                    b.Property<int>("CodEntrevistadorNavigationCodGerente")
                        .HasColumnType("int");

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEntrevista")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NotaEntrevista")
                        .HasColumnType("int");

                    b.Property<int>("TelContato")
                        .HasColumnType("int");

                    b.HasKey("IdFuncionario");

                    b.HasIndex("CodCargoNavigationCodCargo");

                    b.HasIndex("CodEntrevistadorNavigationCodGerente");

                    b.ToTable("BancoTalentos");
                });

            modelBuilder.Entity("ProjetoRH.Models.Cargo", b =>
                {
                    b.Property<int>("CodCargo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodCargo"), 1L, 1);

                    b.Property<int?>("CodGerente")
                        .HasColumnType("int");

                    b.Property<int?>("CodGerenteNavigationCodGerente")
                        .HasColumnType("int");

                    b.Property<string>("DescricaoCargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SalarioBase")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CodCargo");

                    b.HasIndex("CodGerenteNavigationCodGerente");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("ProjetoRH.Models.FolhaPagamento", b =>
                {
                    b.Property<int>("IdLancamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLancamento"), 1L, 1);

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Descontos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<int?>("IdFuncionarioNavigationIdFuncionario")
                        .HasColumnType("int");

                    b.Property<int?>("ResponsavelLancamento")
                        .HasColumnType("int");

                    b.Property<int?>("ResponsavelLancamentoNavigationIdAdm")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorBase")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorFinal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdLancamento");

                    b.HasIndex("IdFuncionarioNavigationIdFuncionario");

                    b.HasIndex("ResponsavelLancamentoNavigationIdAdm");

                    b.ToTable("FolhaPagamentos");
                });

            modelBuilder.Entity("ProjetoRH.Models.Funcionario", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFuncionario"), 1L, 1);

                    b.Property<int>("Cep")
                        .HasColumnType("int");

                    b.Property<int?>("CodCargo")
                        .HasColumnType("int");

                    b.Property<int?>("CodCargoNavigationCodCargo")
                        .HasColumnType("int");

                    b.Property<int>("ContatoEmergencia")
                        .HasColumnType("int");

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Ferias")
                        .HasColumnType("bit");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HorasExtras")
                        .HasColumnType("int");

                    b.Property<int>("HorasTrabalhadas")
                        .HasColumnType("int");

                    b.Property<string>("Modalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalarioTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TelContato")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorExtra")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdFuncionario");

                    b.HasIndex("CodCargoNavigationCodCargo");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("ProjetoRH.Models.FuncionariosInativo", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFuncionario"), 1L, 1);

                    b.Property<int>("Cep")
                        .HasColumnType("int");

                    b.Property<int?>("CodCargo")
                        .HasColumnType("int");

                    b.Property<int?>("CodCargoNavigationCodCargo")
                        .HasColumnType("int");

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDesligamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelContato")
                        .HasColumnType("int");

                    b.HasKey("IdFuncionario");

                    b.HasIndex("CodCargoNavigationCodCargo");

                    b.ToTable("FuncionariosInativos");
                });

            modelBuilder.Entity("ProjetoRH.Models.Gerente", b =>
                {
                    b.Property<int>("CodGerente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodGerente"), 1L, 1);

                    b.Property<int>("Cep")
                        .HasColumnType("int");

                    b.Property<int?>("CodSetor")
                        .HasColumnType("int");

                    b.Property<int?>("CodSetorNavigationCodSetor")
                        .HasColumnType("int");

                    b.Property<int>("ContatoEmergencia")
                        .HasColumnType("int");

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HorasExtras")
                        .HasColumnType("int");

                    b.Property<int>("HorasTrabalhadas")
                        .HasColumnType("int");

                    b.Property<string>("Modalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeGerente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalarioTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TelContato")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorExtra")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CodGerente");

                    b.HasIndex("CodSetorNavigationCodSetor");

                    b.ToTable("Gerentes");
                });

            modelBuilder.Entity("ProjetoRH.Models.Setore", b =>
                {
                    b.Property<int>("CodSetor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodSetor"), 1L, 1);

                    b.Property<string>("NomeSetor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodSetor");

                    b.ToTable("Setores");
                });

            modelBuilder.Entity("ProjetoRH.Models.Treinamento", b =>
                {
                    b.Property<int>("IdTreinamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTreinamento"), 1L, 1);

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataTermino")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<int?>("IdFuncionarioNavigationIdFuncionario")
                        .HasColumnType("int");

                    b.HasKey("IdTreinamento");

                    b.HasIndex("IdFuncionarioNavigationIdFuncionario");

                    b.ToTable("Treinamentos");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetoRH.Models.Administradore", b =>
                {
                    b.HasOne("ProjetoRH.Models.Funcionario", "IdFuncionarioNavigation")
                        .WithMany("Administradores")
                        .HasForeignKey("IdFuncionarioNavigationIdFuncionario");

                    b.Navigation("IdFuncionarioNavigation");
                });

            modelBuilder.Entity("ProjetoRH.Models.BancoTalento", b =>
                {
                    b.HasOne("ProjetoRH.Models.Cargo", "CodCargoNavigation")
                        .WithMany("BancoTalentos")
                        .HasForeignKey("CodCargoNavigationCodCargo");

                    b.HasOne("ProjetoRH.Models.Gerente", "CodEntrevistadorNavigation")
                        .WithMany("BancoTalentos")
                        .HasForeignKey("CodEntrevistadorNavigationCodGerente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodCargoNavigation");

                    b.Navigation("CodEntrevistadorNavigation");
                });

            modelBuilder.Entity("ProjetoRH.Models.Cargo", b =>
                {
                    b.HasOne("ProjetoRH.Models.Gerente", "CodGerenteNavigation")
                        .WithMany("Cargos")
                        .HasForeignKey("CodGerenteNavigationCodGerente");

                    b.Navigation("CodGerenteNavigation");
                });

            modelBuilder.Entity("ProjetoRH.Models.FolhaPagamento", b =>
                {
                    b.HasOne("ProjetoRH.Models.Funcionario", "IdFuncionarioNavigation")
                        .WithMany("FolhaPagamentos")
                        .HasForeignKey("IdFuncionarioNavigationIdFuncionario");

                    b.HasOne("ProjetoRH.Models.Administradore", "ResponsavelLancamentoNavigation")
                        .WithMany("FolhaPagamentos")
                        .HasForeignKey("ResponsavelLancamentoNavigationIdAdm");

                    b.Navigation("IdFuncionarioNavigation");

                    b.Navigation("ResponsavelLancamentoNavigation");
                });

            modelBuilder.Entity("ProjetoRH.Models.Funcionario", b =>
                {
                    b.HasOne("ProjetoRH.Models.Cargo", "CodCargoNavigation")
                        .WithMany("Funcionarios")
                        .HasForeignKey("CodCargoNavigationCodCargo");

                    b.Navigation("CodCargoNavigation");
                });

            modelBuilder.Entity("ProjetoRH.Models.FuncionariosInativo", b =>
                {
                    b.HasOne("ProjetoRH.Models.Cargo", "CodCargoNavigation")
                        .WithMany("FuncionariosInativos")
                        .HasForeignKey("CodCargoNavigationCodCargo");

                    b.Navigation("CodCargoNavigation");
                });

            modelBuilder.Entity("ProjetoRH.Models.Gerente", b =>
                {
                    b.HasOne("ProjetoRH.Models.Setore", "CodSetorNavigation")
                        .WithMany("Gerentes")
                        .HasForeignKey("CodSetorNavigationCodSetor");

                    b.Navigation("CodSetorNavigation");
                });

            modelBuilder.Entity("ProjetoRH.Models.Treinamento", b =>
                {
                    b.HasOne("ProjetoRH.Models.Funcionario", "IdFuncionarioNavigation")
                        .WithMany("Treinamentos")
                        .HasForeignKey("IdFuncionarioNavigationIdFuncionario");

                    b.Navigation("IdFuncionarioNavigation");
                });

            modelBuilder.Entity("ProjetoRH.Models.Administradore", b =>
                {
                    b.Navigation("FolhaPagamentos");
                });

            modelBuilder.Entity("ProjetoRH.Models.Cargo", b =>
                {
                    b.Navigation("BancoTalentos");

                    b.Navigation("Funcionarios");

                    b.Navigation("FuncionariosInativos");
                });

            modelBuilder.Entity("ProjetoRH.Models.Funcionario", b =>
                {
                    b.Navigation("Administradores");

                    b.Navigation("FolhaPagamentos");

                    b.Navigation("Treinamentos");
                });

            modelBuilder.Entity("ProjetoRH.Models.Gerente", b =>
                {
                    b.Navigation("BancoTalentos");

                    b.Navigation("Cargos");
                });

            modelBuilder.Entity("ProjetoRH.Models.Setore", b =>
                {
                    b.Navigation("Gerentes");
                });
#pragma warning restore 612, 618
        }
    }
}
