using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class HistoricoStatusCotacao
    {
        public int IdHistoricoStatusCotacao { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<int> IdStatusCotacao { get; set; }
        public string DataStatus { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public virtual Cotacao Cotacao { get; set; }
        public virtual StatusCotacao StatusCotacao { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
