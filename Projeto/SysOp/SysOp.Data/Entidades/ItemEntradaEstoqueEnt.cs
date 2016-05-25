using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ItemEntradaEstoqueEnt
    {
        public int IdItemEntradaProduto { get; set; }
        public Nullable<int> IdEntradaProduto { get; set; }
        public Nullable<int> Lote { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorUnitarioCusto { get; set; }
        public virtual EntradaProdutoEnt EntradaProduto { get; set; }
    }
}
