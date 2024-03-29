﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRH.Models
{
    public partial class FolhaPagamento
    {
        [Key]
        public int IdLancamento { get; set; }
        public int? ResponsavelLancamento { get; set; }
        public int? IdFuncionario { get; set; }
        public DateTime DataLancamento { get; set; }
        public decimal ValorBase { get; set; }
        public decimal Descontos { get; set; }
        public decimal ValorFinal { get; set; }

        public virtual Funcionario? IdFuncionarioNavigation { get; set; }
        public virtual Administradore? ResponsavelLancamentoNavigation { get; set; }
    }
}
