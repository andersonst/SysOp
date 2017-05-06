using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class itempedidocompracotacao
    {
        public int IdItemPedidoCompraCotacao { get; set; }
        public Nullable<int> IdItemSolicitacaoCompraCotatcao { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual itemsolicitacaocompracotacao itemsolicitacaocompracotacao { get; set; }
        public virtual pedidocompra pedidocompra { get; set; }
    }
}
