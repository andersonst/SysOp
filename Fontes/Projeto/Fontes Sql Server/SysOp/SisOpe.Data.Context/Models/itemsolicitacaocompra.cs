using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ItemSolicitacaoCompra
    {
        public ItemSolicitacaoCompra()
        {
            this.itempedidocompras = new List<ItemPedidoCompra>();
        }

        public int IdItemSolicitacaoCompra { get; set; }
        public Nullable<int> IdSolicitacaoCompra { get; set; }
        public Nullable<long> IdProduto { get; set; }
        public Nullable<int> IdFornecedor { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorUnitario { get; set; }
        public virtual ICollection<ItemPedidoCompra> itempedidocompras { get; set; }
        public virtual Produto produto { get; set; }
        public virtual Solicitacaocompra solicitacaocompra { get; set; }
    }
}
