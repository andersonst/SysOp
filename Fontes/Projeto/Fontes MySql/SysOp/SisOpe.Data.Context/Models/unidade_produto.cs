using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class unidade_produto
    {
        public unidade_produto()
        {
            this.produtoes = new List<produto>();
        }

        public long ID { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public virtual ICollection<produto> produtoes { get; set; }
    }
}
