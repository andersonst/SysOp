using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ItemVendaEstoqueEnt
    {
        public int IdItemVendaEstoque { get; set; }
        public Nullable<int> IdVendaProduto { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<int> Valor { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<decimal> desconto { get; set; }
        public virtual ProdutoEnt Produto { get; set; }
        public virtual VendaProdutoEnt VendaProduto { get; set; }
    }
}
