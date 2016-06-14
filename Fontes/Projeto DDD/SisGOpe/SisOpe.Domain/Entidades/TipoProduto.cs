using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class TipoProduto
    {
        public TipoProduto()
        {
            this.Produtoes = new List<Produto>();
        }

        public int IdTipoProduto { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Produto> Produtoes { get; set; }
    }
}
