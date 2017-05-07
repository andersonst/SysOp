using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Finalidade
    {
        public Finalidade()
        {
            this.produtocotacaos = new List<ProdutocCotacao>();
        }

        public int IdFinalidade { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<ProdutocCotacao> produtocotacaos { get; set; }
    }
}
