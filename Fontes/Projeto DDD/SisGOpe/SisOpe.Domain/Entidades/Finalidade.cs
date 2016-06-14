using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Finalidade
    {
        public Finalidade()
        {
            this.ProdutoCotacaos = new List<ProdutoCotacao>();
        }

        public int IdFinalidade { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<ProdutoCotacao> ProdutoCotacaos { get; set; }
    }
}
