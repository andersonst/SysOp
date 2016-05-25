using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class PagamentoRetornoCotacaoEnt
    {
        public int IdPagamentoRetorno { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<int> IdFormaPagamento { get; set; }
        public Nullable<int> Parcela { get; set; }
        public Nullable<System.DateTime> DataVencimento { get; set; }
        public Nullable<decimal> ValorPago { get; set; }
        public virtual FormaPagamentoEnt FormaPagamento { get; set; }
    }
}
