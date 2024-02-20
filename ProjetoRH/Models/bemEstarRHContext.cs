using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjetoRH.Models
{
    public partial class bemEstarRHContext : DbContext
    {
        public bemEstarRHContext()
        {
        }

        public bemEstarRHContext(DbContextOptions<bemEstarRHContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administradore> Administradores { get; set; } = null!;
        public virtual DbSet<BancoTalento> BancoTalentos { get; set; } = null!;
        public virtual DbSet<Cargo> Cargos { get; set; } = null!;
        public virtual DbSet<FolhaPagamento> FolhaPagamentos { get; set; } = null!;
        public virtual DbSet<Funcionario> Funcionarios { get; set; } = null!;
        public virtual DbSet<FuncionariosInativo> FuncionariosInativos { get; set; } = null!;
        public virtual DbSet<Gerente> Gerentes { get; set; } = null!;
        public virtual DbSet<Setore> Setores { get; set; } = null!;
        public virtual DbSet<Treinamento> Treinamentos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning 
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administradore>(entity =>
            {
                entity.HasKey(e => e.IdAdm)
                    .HasName("PK__administ__3E0FA4AD9C682B3E");

                entity.ToTable("administradores");

                entity.Property(e => e.IdAdm).HasColumnName("idAdm");

                entity.Property(e => e.IdFuncionario).HasColumnName("idFuncionario");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.Administradores)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("FK__administr__idFun__36B12243");
            });

            modelBuilder.Entity<BancoTalento>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PK__bancoTal__B0A12295B5C8FB37");

                entity.ToTable("bancoTalentos");

                entity.Property(e => e.IdFuncionario).HasColumnName("idFuncionario");

                entity.Property(e => e.Cep).HasColumnName("cep");

                entity.Property(e => e.CodCargo).HasColumnName("codCargo");

                entity.Property(e => e.CodEntrevistador).HasColumnName("codEntrevistador");

                entity.Property(e => e.Cpf).HasColumnName("cpf");

                entity.Property(e => e.DataEntrevista)
                    .HasColumnType("date")
                    .HasColumnName("dataEntrevista");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.NomeFuncionario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeFuncionario");

                entity.Property(e => e.NotaEntrevista).HasColumnName("notaEntrevista");

                entity.Property(e => e.TelContato).HasColumnName("telContato");

                entity.HasOne(d => d.CodCargoNavigation)
                    .WithMany(p => p.BancoTalentos)
                    .HasForeignKey(d => d.CodCargo)
                    .HasConstraintName("FK__bancoTale__codCa__32E0915F");

                entity.HasOne(d => d.CodEntrevistadorNavigation)
                    .WithMany(p => p.BancoTalentos)
                    .HasForeignKey(d => d.CodEntrevistador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__bancoTale__codEn__33D4B598");
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.CodCargo)
                    .HasName("PK__cargos__362A2F9341D3758A");

                entity.ToTable("cargos");

                entity.Property(e => e.CodCargo).HasColumnName("codCargo");

                entity.Property(e => e.CodGerente).HasColumnName("codGerente");

                entity.Property(e => e.DescricaoCargo)
                    .HasColumnType("text")
                    .HasColumnName("descricaoCargo");

                entity.Property(e => e.NomeCargo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeCargo");

                entity.Property(e => e.SalarioBase)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("salarioBase");

                entity.HasOne(d => d.CodGerenteNavigation)
                    .WithMany(p => p.Cargos)
                    .HasForeignKey(d => d.CodGerente)
                    .HasConstraintName("FK__cargos__codGeren__29572725");
            });

            modelBuilder.Entity<FolhaPagamento>(entity =>
            {
                entity.HasKey(e => e.IdLancamento)
                    .HasName("PK__folhaPag__514A5A7652E77043");

                entity.ToTable("folhaPagamentos");

                entity.Property(e => e.IdLancamento).HasColumnName("idLancamento");

                entity.Property(e => e.DataLancamento)
                    .HasColumnType("date")
                    .HasColumnName("dataLancamento");

                entity.Property(e => e.Descontos)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("descontos");

                entity.Property(e => e.IdFuncionario).HasColumnName("idFuncionario");

                entity.Property(e => e.ResponsavelLancamento).HasColumnName("responsavelLancamento");

                entity.Property(e => e.ValorBase)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("valorBase");

                entity.Property(e => e.ValorFinal)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("valorFinal");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.FolhaPagamentos)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("FK__folhaPaga__idFun__3A81B327");

                entity.HasOne(d => d.ResponsavelLancamentoNavigation)
                    .WithMany(p => p.FolhaPagamentos)
                    .HasForeignKey(d => d.ResponsavelLancamento)
                    .HasConstraintName("FK__folhaPaga__respo__398D8EEE");
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PK__funciona__B0A1229524161C5F");

                entity.ToTable("funcionarios");

                entity.Property(e => e.IdFuncionario).HasColumnName("idFuncionario");

                entity.Property(e => e.Cep).HasColumnName("cep");

                entity.Property(e => e.CodCargo).HasColumnName("codCargo");

                entity.Property(e => e.ContatoEmergencia).HasColumnName("contatoEmergencia");

                entity.Property(e => e.Cpf).HasColumnName("cpf");

                entity.Property(e => e.DataAdmissao)
                    .HasColumnType("date")
                    .HasColumnName("dataAdmissao");

                entity.Property(e => e.DataNasc)
                    .HasColumnType("date")
                    .HasColumnName("dataNasc");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Ferias)
                    .HasColumnName("ferias")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Genero)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("genero");

                entity.Property(e => e.HorasExtras).HasColumnName("horasExtras");

                entity.Property(e => e.HorasTrabalhadas).HasColumnName("horasTrabalhadas");

                entity.Property(e => e.Modalidade)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("modalidade");

                entity.Property(e => e.NomeFuncionario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeFuncionario");

                entity.Property(e => e.Salario)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("salario");

                entity.Property(e => e.SalarioTotal)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("salarioTotal");

                entity.Property(e => e.TelContato).HasColumnName("telContato");

                entity.Property(e => e.ValorExtra)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("valorExtra");

                entity.HasOne(d => d.CodCargoNavigation)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.CodCargo)
                    .HasConstraintName("FK__funcionar__codCa__2D27B809");
            });

            modelBuilder.Entity<FuncionariosInativo>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PK__funciona__B0A12295C0DAD233");

                entity.ToTable("funcionariosInativos");

                entity.Property(e => e.IdFuncionario).HasColumnName("idFuncionario");

                entity.Property(e => e.Cep).HasColumnName("cep");

                entity.Property(e => e.CodCargo).HasColumnName("codCargo");

                entity.Property(e => e.Cpf).HasColumnName("cpf");

                entity.Property(e => e.DataAdmissao)
                    .HasColumnType("date")
                    .HasColumnName("dataAdmissao");

                entity.Property(e => e.DataDesligamento)
                    .HasColumnType("date")
                    .HasColumnName("dataDesligamento");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Modalidade)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("modalidade");

                entity.Property(e => e.NomeFuncionario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeFuncionario");

                entity.Property(e => e.TelContato).HasColumnName("telContato");

                entity.HasOne(d => d.CodCargoNavigation)
                    .WithMany(p => p.FuncionariosInativos)
                    .HasForeignKey(d => d.CodCargo)
                    .HasConstraintName("FK__funcionar__codCa__300424B4");
            });

            modelBuilder.Entity<Gerente>(entity =>
            {
                entity.HasKey(e => e.CodGerente)
                    .HasName("PK__gerentes__54357BB14E9CFFFE");

                entity.ToTable("gerentes");

                entity.Property(e => e.CodGerente).HasColumnName("codGerente");

                entity.Property(e => e.Cep).HasColumnName("cep");

                entity.Property(e => e.CodSetor).HasColumnName("codSetor");

                entity.Property(e => e.ContatoEmergencia).HasColumnName("contatoEmergencia");

                entity.Property(e => e.Cpf).HasColumnName("cpf");

                entity.Property(e => e.DataAdmissao)
                    .HasColumnType("date")
                    .HasColumnName("dataAdmissao");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.HorasExtras).HasColumnName("horasExtras");

                entity.Property(e => e.HorasTrabalhadas).HasColumnName("horasTrabalhadas");

                entity.Property(e => e.Modalidade)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("modalidade");

                entity.Property(e => e.NomeGerente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeGerente");

                entity.Property(e => e.Salario)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("salario");

                entity.Property(e => e.SalarioTotal)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("salarioTotal");

                entity.Property(e => e.TelContato).HasColumnName("telContato");

                entity.Property(e => e.ValorExtra)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("valorExtra");

                entity.HasOne(d => d.CodSetorNavigation)
                    .WithMany(p => p.Gerentes)
                    .HasForeignKey(d => d.CodSetor)
                    .HasConstraintName("FK__gerentes__codSet__267ABA7A");
            });

            modelBuilder.Entity<Setore>(entity =>
            {
                entity.HasKey(e => e.CodSetor)
                    .HasName("PK__setores__7A252CA92BCBD0D4");

                entity.ToTable("setores");

                entity.Property(e => e.CodSetor).HasColumnName("codSetor");

                entity.Property(e => e.NomeSetor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeSetor");
            });

            modelBuilder.Entity<Treinamento>(entity =>
            {
                entity.HasKey(e => e.IdTreinamento)
                    .HasName("PK__treiname__226AE22DC4CC2774");

                entity.ToTable("treinamentos");

                entity.Property(e => e.IdTreinamento).HasColumnName("idTreinamento");

                entity.Property(e => e.DataInicio)
                    .HasColumnType("date")
                    .HasColumnName("dataInicio");

                entity.Property(e => e.DataTermino)
                    .HasColumnType("date")
                    .HasColumnName("dataTermino");

                entity.Property(e => e.IdFuncionario).HasColumnName("idFuncionario");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.Treinamentos)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("FK__treinamen__idFun__3D5E1FD2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
