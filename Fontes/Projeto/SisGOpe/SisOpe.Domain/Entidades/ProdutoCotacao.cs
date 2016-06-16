using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class ProdutoCotacao
    {
        public ProdutoCotacao()
        {
            this.ItemRetornoCotacaos = new List<ItemRetornoCotacao>();
        }

        public int IdProdutoCotacao { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public Nullable<int> IdFinalidade { get; set; }
        public Nullable<decimal> QuantidadeCotada { get; set; }
        public virtual Cotacao Cotacao { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual Finalidade Finalidade { get; set; }
        public virtual ICollection<ItemRetornoCotacao> ItemRetornoCotacaos { get; set; }
    }
}
