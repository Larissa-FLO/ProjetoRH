using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRH.Models
{
    public partial class Cargo
    {
        public Cargo()
        {
            BancoTalentos = new HashSet<BancoTalento>();
            Funcionarios = new HashSet<Funcionario>();
            FuncionariosInativos = new HashSet<FuncionariosInativo>();
        }

        [Key]

        public int CodCargo { get; set; }
        public string NomeCargo { get; set; } = null!;
        public string DescricaoCargo { get; set; } = null!;
        public decimal SalarioBase { get; set; }
        public int? CodGerente { get; set; }

        public virtual Gerente? CodGerenteNavigation { get; set; }
        public virtual ICollection<BancoTalento> BancoTalentos { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
        public virtual ICollection<FuncionariosInativo> FuncionariosInativos { get; set; }
    }
}
