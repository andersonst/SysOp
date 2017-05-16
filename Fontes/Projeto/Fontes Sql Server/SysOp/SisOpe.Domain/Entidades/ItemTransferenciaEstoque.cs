using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class ItemTransferenciaEstoque
    {
        public int IdItemTransferenciaEstoque { get; set; }
        public Nullable<long> IdProduto { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public string Status { get; set; }
        public Nullable<int> IdLocalOrigem { get; set; }
        public Nullable<int> IdLocalDestino { get; set; }
        public Nullable<int> IdTE { get; set; }
        public virtual Produto_2 produto_2 { get; set; }
        public virtual TransferenciaEstoque transferenciaestoque { get; set; }
        public virtual Unidade unidade { get; set; }
        public virtual Unidade unidade1 { get; set; }
    }
}
