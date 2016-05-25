using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class FormaPagamentoEnt
    {
        public FormaPagamentoEnt()
        {
            this.PagamentoRetornoCotacaos = new List<PagamentoRetornoCotacaoEnt>();
        }

        public int IdFormaPagamento { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<PagamentoRetornoCotacaoEnt> PagamentoRetornoCotacaos { get; set; }
    }
}
