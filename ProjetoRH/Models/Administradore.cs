using System;
using System.Collections.Generic;

namespace ProjetoRH.Models
{
    public partial class Administradore
    {
        public Administradore()
        {
            FolhaPagamentos = new HashSet<FolhaPagamento>();
        }

        public int IdAdm { get; set; }
        public int? IdFuncionario { get; set; }

        public virtual Funcionario? IdFuncionarioNavigation { get; set; }
        public virtual ICollection<FolhaPagamento> FolhaPagamentos { get; set; }
    }
}
