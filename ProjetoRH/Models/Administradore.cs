using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRH.Models
{
    public partial class Administradore
    {
        public Administradore()
        {
            FolhaPagamentos = new HashSet<FolhaPagamento>();
        }
        [Key]
        public int IdAdm { get; set; }
        public int? IdFuncionario { get; set; }

        public virtual Funcionario? IdFuncionarioNavigation { get; set; }
        public virtual ICollection<FolhaPagamento> FolhaPagamentos { get; set; }
    }
}
