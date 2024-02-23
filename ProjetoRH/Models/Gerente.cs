using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRH.Models
{
    public partial class Gerente
    {
        public Gerente()
        {
            BancoTalentos = new HashSet<BancoTalento>();
            Cargos = new HashSet<Cargo>();
        }

        [Key]
        public int CodGerente { get; set; }
        public string NomeGerente { get; set; } = null!;
        public int? CodSetor { get; set; }
        public int Cpf { get; set; }
        public int Cep { get; set; }
        public int TelContato { get; set; }
        public int ContatoEmergencia { get; set; }
        public string Email { get; set; } = null!;
        public DateTime DataAdmissao { get; set; }
        public string Modalidade { get; set; } = null!;
        public decimal Salario { get; set; }
        public decimal ValorExtra { get; set; }
        public int HorasTrabalhadas { get; set; }
        public int? HorasExtras { get; set; }
        public decimal SalarioTotal { get; set; }

        public virtual Setore? CodSetorNavigation { get; set; }
        public virtual ICollection<BancoTalento> BancoTalentos { get; set; }
        public virtual ICollection<Cargo> Cargos { get; set; }
    }
}
