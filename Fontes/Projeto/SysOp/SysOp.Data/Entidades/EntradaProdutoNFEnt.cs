using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class EntradaProdutoNFEnt
    {
        public int IdEntradaProdutoNF { get; set; }
        public Nullable<int> IdEntradaProduto { get; set; }
        public Nullable<int> IdNotaFisacal { get; set; }
        public Nullable<int> IdPedidoCompra { get; set; }
        public virtual EntradaProdutoEnt EntradaProduto { get; set; }
        public virtual NotaFiscalEnt NotaFiscal { get; set; }
        public virtual PedidoCompraEnt PedidoCompra { get; set; }
    }
}
