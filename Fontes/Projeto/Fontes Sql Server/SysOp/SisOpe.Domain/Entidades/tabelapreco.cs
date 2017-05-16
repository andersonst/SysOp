using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class TabelaPreco
    {
        public int IdTabelaPreco { get; set; }
        public Nullable<long> IdProduto { get; set; }
        public Nullable<decimal> ValorUnitarioVenda { get; set; }
        public Nullable<System.DateTime> DataVenda { get; set; }
        public virtual Produto_2 produto_2 { get; set; }
    }
}
