using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class SolicitacaoPedidoCompraEnt
    {
        public int IdSolicitacaoPedidoCompra { get; set; }
        public Nullable<int> IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual PedidoCompraEnt PedidoCompra { get; set; }
        public virtual SolicitacaoCompraEnt SolicitacaoCompra { get; set; }
    }
}
