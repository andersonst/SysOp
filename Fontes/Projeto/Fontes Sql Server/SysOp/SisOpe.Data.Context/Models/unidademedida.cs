using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class UnidadeMedida
    {
        public UnidadeMedida()
        {
            this.produto_2 = new List<Produto_2>();
        }

        public int IdUnidadeMedida { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Produto_2> produto_2 { get; set; }
    }
}
