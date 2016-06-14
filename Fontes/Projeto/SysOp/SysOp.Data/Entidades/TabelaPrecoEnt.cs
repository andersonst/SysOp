using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class TabelaPrecoEnt
    {
        public int IdTabelaPreco { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<decimal> ValorUnitarioVenda { get; set; }
        public Nullable<System.DateTime> DataVenda { get; set; }
        public virtual ProdutoEnt Produto { get; set; }
    }
}
