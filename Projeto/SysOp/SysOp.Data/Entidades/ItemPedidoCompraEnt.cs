using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ItemPedidoCompraEnt
    {
        public int IdItemPedidoCompra { get; set; }
        public Nullable<int> IdItemSolicitacaoCompra { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual ItemSolicitacaoCompraEnt ItemSolicitacaoCompra { get; set; }
        public virtual PedidoCompraEnt PedidoCompra { get; set; }
    }
}
