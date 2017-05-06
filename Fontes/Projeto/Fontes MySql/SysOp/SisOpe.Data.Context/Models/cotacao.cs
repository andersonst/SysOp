using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class cotacao
    {
        public cotacao()
        {
            this.fornecedorcotacaos = new List<fornecedorcotacao>();
            this.historicostatuscotacaos = new List<historicostatuscotacao>();
            this.produtocotacaos = new List<produtocotacao>();
        }

        public int IdCotacao { get; set; }
        public string Descricao { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public Nullable<int> IdStatusCotacao { get; set; }
        public virtual statuscotacao statuscotacao { get; set; }
        public virtual ICollection<fornecedorcotacao> fornecedorcotacaos { get; set; }
        public virtual ICollection<historicostatuscotacao> historicostatuscotacaos { get; set; }
        public virtual ICollection<produtocotacao> produtocotacaos { get; set; }
    }
}
