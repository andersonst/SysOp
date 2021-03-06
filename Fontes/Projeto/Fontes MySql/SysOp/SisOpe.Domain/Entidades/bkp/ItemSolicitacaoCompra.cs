using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class ItemSolicitacaoCompra
    {
        public ItemSolicitacaoCompra()
        {
            this.ItemPedidoCompras = new List<ItemPedidoCompra>();
        }

        public int IdItemSolicitacaoCompra { get; set; }
        public Nullable<int> IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<int> IdFornecedor { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorUnitario { get; set; }
        public virtual ICollection<ItemPedidoCompra> ItemPedidoCompras { get; set; }
        public virtual SolicitacaoCompra SolicitacaoCompra { get; set; }
    }
}
