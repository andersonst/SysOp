using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class MarcaProduto
    {
        public MarcaProduto()
        {
            this.produto_2 = new List<Produto_2>();
        }

        public int IdMarcaProduto { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Produto_2> produto_2 { get; set; }
    }
}
