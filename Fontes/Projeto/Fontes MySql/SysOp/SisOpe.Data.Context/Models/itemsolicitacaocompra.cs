using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class itemsolicitacaocompra
    {
        public itemsolicitacaocompra()
        {
            this.itempedidocompras = new List<itempedidocompra>();
        }

        public int IdItemSolicitacaoCompra { get; set; }
        public Nullable<int> IdSolicitacaoCompra { get; set; }
        public Nullable<long> IdProduto { get; set; }
        public Nullable<int> IdFornecedor { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorUnitario { get; set; }
        public virtual ICollection<itempedidocompra> itempedidocompras { get; set; }
        public virtual produto produto { get; set; }
        public virtual solicitacaocompra solicitacaocompra { get; set; }
    }
}
