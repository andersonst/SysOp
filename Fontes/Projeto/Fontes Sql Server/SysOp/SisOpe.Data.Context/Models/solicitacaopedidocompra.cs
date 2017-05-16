using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Solicitacaopedidocompra
    {
        public int IdSolicitacaoPedidoCompra { get; set; }
        public Nullable<int> IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual PedidoCompra pedidocompra { get; set; }
        public virtual Solicitacaocompra solicitacaocompra { get; set; }
    }
}
