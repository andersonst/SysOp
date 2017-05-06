using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class historicostatuscotacao
    {
        public int IdHistoricoStatusCotacao { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<int> IdStatusCotacao { get; set; }
        public string DataStatus { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public virtual cotacao cotacao { get; set; }
        public virtual statuscotacao statuscotacao { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
