using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class tipoproduto
    {
        public tipoproduto()
        {
            this.produto_2 = new List<produto_2>();
        }

        public int IdTipoProduto { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<produto_2> produto_2 { get; set; }
    }
}
