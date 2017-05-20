using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class HistoricoStatusCotacao
    {
        public int IdHistoricoStatusCotacao { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<int> IdStatusCotacao { get; set; }
        public string DataStatus { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public virtual Cotacao cotacao { get; set; }
        public virtual StatusCotacao statuscotacao { get; set; }
        public virtual Usuario usuario { get; set; }
    }
}
