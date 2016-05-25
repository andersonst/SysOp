using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class EntradaProdutoEnt
    {
        public EntradaProdutoEnt()
        {
            this.EntradaProdutoNFs = new List<EntradaProdutoNFEnt>();
            this.ItemEntradaEstoques = new List<ItemEntradaEstoqueEnt>();
        }

        public int IdEntradaProduto { get; set; }
        public Nullable<System.DateTime> DataEntrada { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public virtual ICollection<EntradaProdutoNFEnt> EntradaProdutoNFs { get; set; }
        public virtual ICollection<ItemEntradaEstoqueEnt> ItemEntradaEstoques { get; set; }
    }
}
