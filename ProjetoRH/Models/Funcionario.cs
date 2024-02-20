using System;
using System.Collections.Generic;

namespace ProjetoRH.Models
{
    public partial class Funcionario
    {
        public Funcionario()
        {
            Administradores = new HashSet<Administradore>();
            FolhaPagamentos = new HashSet<FolhaPagamento>();
            Treinamentos = new HashSet<Treinamento>();
        }

        public int IdFuncionario { get; set; }
        public string NomeFuncionario { get; set; } = null!;
        public DateTime DataNasc { get; set; }
        public string Genero { get; set; } = null!;
        public int Cpf { get; set; }
        public int Cep { get; set; }
        public int TelContato { get; set; }
        public int ContatoEmergencia { get; set; }
        public string Email { get; set; } = null!;
        public DateTime DataAdmissao { get; set; }
        public int? CodCargo { get; set; }
        public string Modalidade { get; set; } = null!;
        public decimal Salario { get; set; }
        public decimal ValorExtra { get; set; }
        public int HorasTrabalhadas { get; set; }
        public int? HorasExtras { get; set; }
        public decimal SalarioTotal { get; set; }
        public bool? Ferias { get; set; }

        public virtual Cargo? CodCargoNavigation { get; set; }
        public virtual ICollection<Administradore> Administradores { get; set; }
        public virtual ICollection<FolhaPagamento> FolhaPagamentos { get; set; }
        public virtual ICollection<Treinamento> Treinamentos { get; set; }
    }
}
