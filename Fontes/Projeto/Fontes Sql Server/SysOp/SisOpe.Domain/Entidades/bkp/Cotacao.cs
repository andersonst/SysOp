using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Cotacao
    {
        public Cotacao()
        {
            this.FornecedorCotacaos = new List<FornecedorCotacao>();
            this.HistoricoStatusCotacaos = new List<HistoricoStatusCotacao>();
            this.ProdutoCotacaos = new List<ProdutoCotacao>();
        }

        public int IdCotacao { get; set; }
        public string Descricao { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public Nullable<int> IdStatusCotacao { get; set; }
        public virtual StatusCotacao StatusCotacao { get; set; }
        public virtual ICollection<FornecedorCotacao> FornecedorCotacaos { get; set; }
        public virtual ICollection<HistoricoStatusCotacao> HistoricoStatusCotacaos { get; set; }
        public virtual ICollection<ProdutoCotacao> ProdutoCotacaos { get; set; }
    }
}
