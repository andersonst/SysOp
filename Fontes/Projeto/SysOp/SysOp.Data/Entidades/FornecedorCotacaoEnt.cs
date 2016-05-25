using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class FornecedorCotacaoEnt
    {
        public FornecedorCotacaoEnt()
        {
            this.ItemRetornoCotacaos = new List<ItemRetornoCotacaoEnt>();
        }

        public int IdFornecedorCotacao { get; set; }
        public Nullable<int> IdFornecedor { get; set; }
        public Nullable<int> IdCotacao { get; set; }
        public Nullable<decimal> ValorFrete { get; set; }
        public string Observacao { get; set; }
        public Nullable<System.DateTime> DataRetorno { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public virtual CotacaoEnt Cotacao { get; set; }
        public virtual PessoaEnt Pessoa { get; set; }
        public virtual ICollection<ItemRetornoCotacaoEnt> ItemRetornoCotacaos { get; set; }
    }
}
