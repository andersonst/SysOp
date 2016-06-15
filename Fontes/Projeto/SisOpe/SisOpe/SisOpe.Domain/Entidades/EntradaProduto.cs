using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class EntradaProduto
    {
        public EntradaProduto()
        {
            this.EntradaProdutoNFs = new List<EntradaProdutoNF>();
            this.ItemEntradaEstoques = new List<ItemEntradaEstoque>();
        }

        public int IdEntradaProduto { get; set; }
        public Nullable<System.DateTime> DataEntrada { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public virtual ICollection<EntradaProdutoNF> EntradaProdutoNFs { get; set; }
        public virtual ICollection<ItemEntradaEstoque> ItemEntradaEstoques { get; set; }
    }
}
