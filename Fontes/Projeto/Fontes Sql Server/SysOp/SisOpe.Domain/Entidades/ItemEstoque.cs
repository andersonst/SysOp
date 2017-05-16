using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class ItemEstoque
    {
        public int IdItemEstoque { get; set; }
        public Nullable<int> IdUnidade { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<long> IdProduto { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public virtual Produto produto { get; set; }
        public virtual Unidade unidade { get; set; }
    }
}
