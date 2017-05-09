using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class PagamentoRetornoCotacao
    {
        public int IdPagamentoRetorno { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<int> IdFormaPagamento { get; set; }
        public Nullable<int> Parcela { get; set; }
        public Nullable<System.DateTime> DataVencimento { get; set; }
        public Nullable<decimal> ValorPago { get; set; }
        public virtual FormaPagamento formapagamento { get; set; }
    }
}
