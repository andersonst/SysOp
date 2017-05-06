using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class itementradaestoque
    {
        public int IdItemEntradaProduto { get; set; }
        public Nullable<int> IdEntradaProduto { get; set; }
        public Nullable<int> Lote { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorUnitarioCusto { get; set; }
        public virtual entradaproduto entradaproduto { get; set; }
    }
}
