using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class solicitacaopedidocompra
    {
        public int IdSolicitacaoPedidoCompra { get; set; }
        public Nullable<int> IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual pedidocompra pedidocompra { get; set; }
        public virtual solicitacaocompra solicitacaocompra { get; set; }
    }
}
