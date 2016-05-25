using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ProdutoCotacaoEnt
    {
        public ProdutoCotacaoEnt()
        {
            this.ItemRetornoCotacaos = new List<ItemRetornoCotacaoEnt>();
        }

        public int IdProdutoCotacao { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public Nullable<int> IdFinalidade { get; set; }
        public Nullable<decimal> QuantidadeCotada { get; set; }
        public virtual CotacaoEnt Cotacao { get; set; }
        public virtual DepartamentoEnt Departamento { get; set; }
        public virtual FinalidadeEnt Finalidade { get; set; }
        public virtual ICollection<ItemRetornoCotacaoEnt> ItemRetornoCotacaos { get; set; }
    }
}
