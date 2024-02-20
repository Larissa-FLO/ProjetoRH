using System;
using System.Collections.Generic;

namespace ProjetoRH.Models
{
    public partial class Setore
    {
        public Setore()
        {
            Gerentes = new HashSet<Gerente>();
        }

        public int CodSetor { get; set; }
        public string NomeSetor { get; set; } = null!;

        public virtual ICollection<Gerente> Gerentes { get; set; }
    }
}
