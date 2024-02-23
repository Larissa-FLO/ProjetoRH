using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoRH.Models;

namespace ProjetoRH.Models;
public class bemEstarRHContext : IdentityDbContext<IdentityUser>
{
    public virtual DbSet<Administradore> Administradores { get; set; } = null!;
    public virtual DbSet<BancoTalento> BancoTalentos { get; set; } = null!;
    public virtual DbSet<Cargo> Cargos { get; set; } = null!;
    public virtual DbSet<FolhaPagamento> FolhaPagamentos { get; set; } = null!;
    public virtual DbSet<Funcionario> Funcionarios { get; set; } = null!;
    public virtual DbSet<FuncionariosInativo> FuncionariosInativos { get; set; } = null!;
    public virtual DbSet<Gerente> Gerentes { get; set; } = null!;
    public virtual DbSet<Setore> Setores { get; set; } = null!;
    public virtual DbSet<Treinamento> Treinamentos { get; set; } = null!;

    public bemEstarRHContext(DbContextOptions<bemEstarRHContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}

