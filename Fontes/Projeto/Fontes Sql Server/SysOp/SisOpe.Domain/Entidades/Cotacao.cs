using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Cotacao
    {
        public Cotacao()
        {
            this.fornecedorcotacaos = new List<FornecedorCotacao>();
            this.historicostatuscotacaos = new List<HistoricoStatusCotacao>();
            this.produtocotacaos = new List<ProdutoCotacao>();
        }

        public int IdCotacao { get; set; }
        public string Descricao { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public Nullable<int> IdStatusCotacao { get; set; }
        public virtual StatusCotacao statuscotacao { get; set; }
        public virtual ICollection<FornecedorCotacao> fornecedorcotacaos { get; set; }
        public virtual ICollection<HistoricoStatusCotacao> historicostatuscotacaos { get; set; }
        public virtual ICollection<ProdutoCotacao> produtocotacaos { get; set; }
    }
}
