using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class statuscotacao
    {
        public statuscotacao()
        {
            this.cotacaos = new List<cotacao>();
            this.historicostatuscotacaos = new List<historicostatuscotacao>();
        }

        public int IdStatusCotacao { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<cotacao> cotacaos { get; set; }
        public virtual ICollection<historicostatuscotacao> historicostatuscotacaos { get; set; }
    }
}
