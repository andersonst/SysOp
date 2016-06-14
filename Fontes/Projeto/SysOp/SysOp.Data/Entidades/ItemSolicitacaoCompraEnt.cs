using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ItemSolicitacaoCompraEnt
    {
        public ItemSolicitacaoCompraEnt()
        {
            this.ItemPedidoCompras = new List<ItemPedidoCompraEnt>();
        }

        public int IdItemSolicitacaoCompra { get; set; }
        public Nullable<int> IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<int> IdFornecedor { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorUnitario { get; set; }
        public virtual ICollection<ItemPedidoCompraEnt> ItemPedidoCompras { get; set; }
        public virtual SolicitacaoCompraEnt SolicitacaoCompra { get; set; }
    }
}
