using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRH.Models
{
    public partial class Treinamento
    {
        [Key]
        public int IdTreinamento { get; set; }
        public int? IdFuncionario { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataTermino { get; set; }

        public virtual Funcionario? IdFuncionarioNavigation { get; set; }
    }
}
