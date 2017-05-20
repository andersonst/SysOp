using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class ItemEntradaEstoque
    {
        public int IdItemEntradaProduto { get; set; }
        public Nullable<int> IdEntradaProduto { get; set; }
        public Nullable<int> Lote { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorUnitarioCusto { get; set; }
        public virtual EntradaProduto entradaproduto { get; set; }
    }
}
