using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class UnidadeMedida
    {
        public UnidadeMedida()
        {
            this.Produtoes = new List<Produto>();
        }

        public int IdUnidadeMedida { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Produto> Produtoes { get; set; }
    }
}
