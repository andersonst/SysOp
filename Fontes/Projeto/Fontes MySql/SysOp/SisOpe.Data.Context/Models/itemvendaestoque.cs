using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ItemVendaEstoque
    {
        public int IdItemVendaEstoque { get; set; }
        public Nullable<int> IdVendaProduto { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<int> Valor { get; set; }
        public Nullable<long> IdProduto { get; set; }
        public Nullable<decimal> desconto { get; set; }
        public virtual Produto produto { get; set; }
        public virtual VendaProduto vendaproduto { get; set; }
    }
}
