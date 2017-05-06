using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class entradaprodutonf
    {
        public int IdEntradaProdutoNF { get; set; }
        public Nullable<int> IdEntradaProduto { get; set; }
        public Nullable<int> IdNotaFisacal { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual entradaproduto entradaproduto { get; set; }
        public virtual notafiscal notafiscal { get; set; }
        public virtual pedidocompra pedidocompra { get; set; }
    }
}
