using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ItemSolicitacaoCompraCotacaoEnt
    {
        public ItemSolicitacaoCompraCotacaoEnt()
        {
            this.ItemPedidoCompraCotacaos = new List<ItemPedidoCompraCotacaoEnt>();
        }

        public int IdItemSolicitacaoCompraCotacao { get; set; }
        public Nullable<int> IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdItemRetornoCotacao { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorUnitario { get; set; }
        public virtual ICollection<ItemPedidoCompraCotacaoEnt> ItemPedidoCompraCotacaos { get; set; }
        public virtual ItemRetornoCotacaoEnt ItemRetornoCotacao { get; set; }
        public virtual SolicitacaoCompraEnt SolicitacaoCompra { get; set; }
    }
}
