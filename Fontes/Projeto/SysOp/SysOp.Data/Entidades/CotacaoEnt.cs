using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class CotacaoEnt
    {
        public CotacaoEnt()
        {
            this.FornecedorCotacaos = new List<FornecedorCotacaoEnt>();
            this.HistoricoStatusCotacaos = new List<HistoricoStatusCotacaoEnt>();
            this.ProdutoCotacaos = new List<ProdutoCotacaoEnt>();
        }

        public int IdCotacao { get; set; }
        public string Descricao { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public Nullable<int> IdStatusCotacao { get; set; }
        public virtual StatusCotacaoEnt StatusCotacao { get; set; }
        public virtual ICollection<FornecedorCotacaoEnt> FornecedorCotacaos { get; set; }
        public virtual ICollection<HistoricoStatusCotacaoEnt> HistoricoStatusCotacaos { get; set; }
        public virtual ICollection<ProdutoCotacaoEnt> ProdutoCotacaos { get; set; }
    }
}
