using System;
using System.Collections.Generic;

namespace ProjetoRH.Models
{
    public partial class FuncionariosInativo
    {
        public int IdFuncionario { get; set; }
        public string NomeFuncionario { get; set; } = null!;
        public int Cpf { get; set; }
        public int Cep { get; set; }
        public int TelContato { get; set; }
        public string Email { get; set; } = null!;
        public int? CodCargo { get; set; }
        public string Modalidade { get; set; } = null!;
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDesligamento { get; set; }

        public virtual Cargo? CodCargoNavigation { get; set; }
    }
}
