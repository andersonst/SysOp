using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class EntradaProdutoNF
    {
        public int IdEntradaProdutoNF { get; set; }
        public Nullable<int> IdEntradaProduto { get; set; }
        public Nullable<int> IdNotaFisacal { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual EntradaProduto EntradaProduto { get; set; }
        public virtual NotaFiscal NotaFiscal { get; set; }
        public virtual PedidoCompra PedidoCompra { get; set; }
    }
}
