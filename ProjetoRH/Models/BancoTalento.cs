using System;
using System.Collections.Generic;

namespace ProjetoRH.Models
{
    public partial class BancoTalento
    {
        public int IdFuncionario { get; set; }
        public string NomeFuncionario { get; set; } = null!;
        public int Cpf { get; set; }
        public int Cep { get; set; }
        public int TelContato { get; set; }
        public string Email { get; set; } = null!;
        public int? CodCargo { get; set; }
        public DateTime DataEntrevista { get; set; }
        public int NotaEntrevista { get; set; }
        public int CodEntrevistador { get; set; }

        public virtual Cargo? CodCargoNavigation { get; set; }
        public virtual Gerente CodEntrevistadorNavigation { get; set; } = null!;
    }
}
