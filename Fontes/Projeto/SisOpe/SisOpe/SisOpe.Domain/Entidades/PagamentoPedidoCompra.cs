using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class PagamentoPedidoCompra
    {
        public int IdPagamentoPedidoCompra { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public Nullable<int> Parcela { get; set; }
        public Nullable<int> IdFormaPagamento { get; set; }
        public string NumeroDocumento { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<System.DateTime> DataVencimento { get; set; }
        public Nullable<decimal> ValorPago { get; set; }
        public Nullable<System.DateTime> DataPagamento { get; set; }
        public string Status { get; set; }
        public virtual PedidoCompra PedidoCompra { get; set; }
    }
}
