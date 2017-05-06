using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class itempedidocompra
    {
        public int IdItemPedidoCompra { get; set; }
        public Nullable<int> IdItemSolicitacaoCompra { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual itemsolicitacaocompra itemsolicitacaocompra { get; set; }
        public virtual pedidocompra pedidocompra { get; set; }
    }
}
