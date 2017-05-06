using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class produtocotacao
    {
        public produtocotacao()
        {
            this.itemretornocotacaos = new List<itemretornocotacao>();
        }

        public int IdProdutoCotacao { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public Nullable<int> IdFinalidade { get; set; }
        public Nullable<decimal> QuantidadeCotada { get; set; }
        public virtual cotacao cotacao { get; set; }
        public virtual departamento departamento { get; set; }
        public virtual finalidade finalidade { get; set; }
        public virtual ICollection<itemretornocotacao> itemretornocotacaos { get; set; }
    }
}
