using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class ItemVendaEstoque
    {
        public int IdItemVendaEstoque { get; set; }
        public Nullable<int> IdVendaProduto { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<int> Valor { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<decimal> desconto { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual VendaProduto VendaProduto { get; set; }
    }
}
