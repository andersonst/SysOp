using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ItemPedidoCompraCotacao
    {
        public int IdItemPedidoCompraCotacao { get; set; }
        public Nullable<int> IdItemSolicitacaoCompraCotatcao { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual ItemSolicitacaoCompraCotacao itemsolicitacaocompracotacao { get; set; }
        public virtual PedidoCompra pedidocompra { get; set; }
    }
}
