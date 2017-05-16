using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class EntradaProdutoNF
    {
        public int IdEntradaProdutoNF { get; set; }
        public Nullable<int> IdEntradaProduto { get; set; }
        public Nullable<int> IdNotaFisacal { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual EntradaProduto entradaproduto { get; set; }
        public virtual NotaFiscal notafiscal { get; set; }
        public virtual PedidoCompra pedidocompra { get; set; }
    }
}
