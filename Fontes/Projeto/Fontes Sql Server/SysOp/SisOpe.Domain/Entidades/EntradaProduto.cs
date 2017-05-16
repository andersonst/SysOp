using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class EntradaProduto
    {
        public EntradaProduto()
        {
            this.entradaprodutonfs = new List<EntradaProdutoNF>();
            this.itementradaestoques = new List<ItemEntradaEstoque>();
        }

        public int IdEntradaProduto { get; set; }
        public Nullable<System.DateTime> DataEntrada { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public virtual ICollection<EntradaProdutoNF> entradaprodutonfs { get; set; }
        public virtual ICollection<ItemEntradaEstoque> itementradaestoques { get; set; }
    }
}
