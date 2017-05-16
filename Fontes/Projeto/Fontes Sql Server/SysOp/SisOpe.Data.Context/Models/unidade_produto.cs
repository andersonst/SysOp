using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Unidade_Produto
    {
        public Unidade_Produto()
        {
            this.produtoes = new List<Produto>();
        }

        public long ID { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public virtual ICollection<Produto> produtoes { get; set; }
    }
}
