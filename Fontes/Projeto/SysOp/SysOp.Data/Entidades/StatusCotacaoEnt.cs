using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class StatusCotacaoEnt
    {
        public StatusCotacaoEnt()
        {
            this.Cotacaos = new List<CotacaoEnt>();
            this.HistoricoStatusCotacaos = new List<HistoricoStatusCotacaoEnt>();
        }

        public int IdStatusCotacao { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<CotacaoEnt> Cotacaos { get; set; }
        public virtual ICollection<HistoricoStatusCotacaoEnt> HistoricoStatusCotacaos { get; set; }
    }
}
