using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class ItemTransferenciaEstoque
    {
        public int IdItemTransferenciaEstoque { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public string Status { get; set; }
        public Nullable<int> IdLocalOrigem { get; set; }
        public Nullable<int> IdLocalDestino { get; set; }
        public Nullable<int> IdTE { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual TransferenciaEstoque TransferenciaEstoque { get; set; }
        public virtual Unidade Unidade { get; set; }
        public virtual Unidade Unidade1 { get; set; }
    }
}
