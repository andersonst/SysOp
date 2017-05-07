using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class StatusCotacao
    {
        public StatusCotacao()
        {
            this.Cotacaos = new List<Cotacao>();
            this.HistoricoStatusCotacaos = new List<HistoricoStatusCotacao>();
        }

        public int IdStatusCotacao { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Cotacao> Cotacaos { get; set; }
        public virtual ICollection<HistoricoStatusCotacao> HistoricoStatusCotacaos { get; set; }
    }
}
