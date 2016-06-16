using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class SolicitacaoPedidoCompra
    {
        public int IdSolicitacaoPedidoCompra { get; set; }
        public Nullable<int> IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual PedidoCompra PedidoCompra { get; set; }
        public virtual SolicitacaoCompra SolicitacaoCompra { get; set; }
    }
}
