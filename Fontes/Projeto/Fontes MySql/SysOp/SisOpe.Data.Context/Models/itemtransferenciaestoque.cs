using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class itemtransferenciaestoque
    {
        public int IdItemTransferenciaEstoque { get; set; }
        public Nullable<long> IdProduto { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public string Status { get; set; }
        public Nullable<int> IdLocalOrigem { get; set; }
        public Nullable<int> IdLocalDestino { get; set; }
        public Nullable<int> IdTE { get; set; }
        public virtual produto_2 produto_2 { get; set; }
        public virtual transferenciaestoque transferenciaestoque { get; set; }
        public virtual unidade unidade { get; set; }
        public virtual unidade unidade1 { get; set; }
    }
}
