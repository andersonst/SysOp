using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class FinalidadeEnt
    {
        public FinalidadeEnt()
        {
            this.ProdutoCotacaos = new List<ProdutoCotacaoEnt>();
        }

        public int IdFinalidade { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<ProdutoCotacaoEnt> ProdutoCotacaos { get; set; }
    }
}
