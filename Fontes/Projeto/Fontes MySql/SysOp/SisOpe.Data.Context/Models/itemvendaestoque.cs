using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class itemvendaestoque
    {
        public int IdItemVendaEstoque { get; set; }
        public Nullable<int> IdVendaProduto { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<int> Valor { get; set; }
        public Nullable<long> IdProduto { get; set; }
        public Nullable<decimal> desconto { get; set; }
        public virtual produto produto { get; set; }
        public virtual vendaproduto vendaproduto { get; set; }
    }
}
