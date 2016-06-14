using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class HistoricoStatusCotacaoEnt
    {
        public int IdHistoricoStatusCotacao { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<int> IdStatusCotacao { get; set; }
        public string DataStatus { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public virtual CotacaoEnt Cotacao { get; set; }
        public virtual StatusCotacaoEnt StatusCotacao { get; set; }
        public virtual UsuarioEnt Usuario { get; set; }
    }
}
