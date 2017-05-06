using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class tabelapreco
    {
        public int IdTabelaPreco { get; set; }
        public Nullable<long> IdProduto { get; set; }
        public Nullable<decimal> ValorUnitarioVenda { get; set; }
        public Nullable<System.DateTime> DataVenda { get; set; }
        public virtual produto_2 produto_2 { get; set; }
    }
}
