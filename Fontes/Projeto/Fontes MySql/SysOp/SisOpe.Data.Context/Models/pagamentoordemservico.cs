using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class PagamentoOrdemServico
    {
        public int IdPagamentoOrdemServico { get; set; }
        public Nullable<int> NumeroParcela { get; set; }
        public string Status { get; set; }
        public string NumeroDocumento { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<System.DateTime> DataVencimento { get; set; }
        public Nullable<decimal> ValorPago { get; set; }
        public Nullable<System.DateTime> DataPagamento { get; set; }
        public Nullable<int> IdOrdemServico { get; set; }
        public virtual OrdemServico ordemservico { get; set; }
    }
}
