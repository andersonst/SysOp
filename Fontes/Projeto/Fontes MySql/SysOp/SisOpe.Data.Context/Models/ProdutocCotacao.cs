using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ProdutocCotacao
    {
        public ProdutocCotacao()
        {
            this.itemretornocotacaos = new List<ItemRetornoCotacao>();
        }

        public int IdProdutoCotacao { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public Nullable<int> IdFinalidade { get; set; }
        public Nullable<decimal> QuantidadeCotada { get; set; }
        public virtual Cotacao cotacao { get; set; }
        public virtual Departamento departamento { get; set; }
        public virtual Finalidade finalidade { get; set; }
        public virtual ICollection<ItemRetornoCotacao> itemretornocotacaos { get; set; }
    }
}
