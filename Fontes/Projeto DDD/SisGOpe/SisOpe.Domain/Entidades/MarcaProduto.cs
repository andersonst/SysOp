using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class MarcaProduto
    {
        public MarcaProduto()
        {
            this.Produtoes = new List<Produto>();
        }

        public int IdMarcaProduto { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Produto> Produtoes { get; set; }
    }
}
