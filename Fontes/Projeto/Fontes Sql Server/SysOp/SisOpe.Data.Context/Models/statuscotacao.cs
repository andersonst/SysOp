using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class StatusCotacao
    {
        public StatusCotacao()
        {
            this.cotacaos = new List<Cotacao>();
            this.historicostatuscotacaos = new List<HistoricoStatusCotacao>();
        }

        public int IdStatusCotacao { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Cotacao> cotacaos { get; set; }
        public virtual ICollection<HistoricoStatusCotacao> historicostatuscotacaos { get; set; }
    }
}
