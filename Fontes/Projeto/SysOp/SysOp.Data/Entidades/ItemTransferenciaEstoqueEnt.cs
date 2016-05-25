using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ItemTransferenciaEstoqueEnt
    {
        public int IdItemTransferenciaEstoque { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public string Status { get; set; }
        public Nullable<int> IdLocalOrigem { get; set; }
        public Nullable<int> IdLocalDestino { get; set; }
        public Nullable<int> IdTE { get; set; }
        public virtual ProdutoEnt Produto { get; set; }
        public virtual TransferenciaEstoqueEnt TransferenciaEstoque { get; set; }
        public virtual UnidadeEnt Unidade { get; set; }
        public virtual UnidadeEnt Unidade1 { get; set; }
    }
}
