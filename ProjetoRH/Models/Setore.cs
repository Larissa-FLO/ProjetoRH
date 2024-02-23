using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRH.Models
{
    public partial class Setore
    {
        public Setore()
        {
            Gerentes = new HashSet<Gerente>();
        }

        [Key]
        public int CodSetor { get; set; }
        public string NomeSetor { get; set; } = null!;

        public virtual ICollection<Gerente> Gerentes { get; set; }
    }
}
