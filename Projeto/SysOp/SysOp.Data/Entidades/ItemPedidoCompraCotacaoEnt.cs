using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ItemPedidoCompraCotacaoEnt
    {
        public int IdItemPedidoCompraCotacao { get; set; }
        public Nullable<int> IdItemSolicitacaoCompraCotatcao { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual ItemSolicitacaoCompraCotacaoEnt ItemSolicitacaoCompraCotacao { get; set; }
        public virtual PedidoCompraEnt PedidoCompra { get; set; }
    }
}
