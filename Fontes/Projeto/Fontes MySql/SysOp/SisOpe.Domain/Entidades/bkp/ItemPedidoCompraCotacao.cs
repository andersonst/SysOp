using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class ItemPedidoCompraCotacao
    {
        public int IdItemPedidoCompraCotacao { get; set; }
        public Nullable<int> IdItemSolicitacaoCompraCotatcao { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual ItemSolicitacaoCompraCotacao ItemSolicitacaoCompraCotacao { get; set; }
        public virtual PedidoCompra PedidoCompra { get; set; }
    }
}
