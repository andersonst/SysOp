using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class ItemPedidoCompra
    {
        public int IdItemPedidoCompra { get; set; }
        public Nullable<int> IdItemSolicitacaoCompra { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual ItemSolicitacaoCompra itemsolicitacaocompra { get; set; }
        public virtual PedidoCompra pedidocompra { get; set; }
    }
}
