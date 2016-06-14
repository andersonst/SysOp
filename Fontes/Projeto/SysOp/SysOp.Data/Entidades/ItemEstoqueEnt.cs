using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ItemEstoqueEnt
    {
        public int IdItemEstoque { get; set; }
        public Nullable<int> IdUnidade { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public virtual ProdutoEnt Produto { get; set; }
        public virtual UnidadeEnt Unidade { get; set; }
    }
}
