using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class produto_2
    {
        public produto_2()
        {
            this.itemtransferenciaestoques = new List<itemtransferenciaestoque>();
            this.tabelaprecoes = new List<tabelapreco>();
        }

        public long IdProduto { get; set; }
        public Nullable<int> IdUnidadeMedida { get; set; }
        public Nullable<int> IdMarcaProduto { get; set; }
        public Nullable<int> IdTipoProduto { get; set; }
        public string Nome { get; set; }
        public Nullable<int> QtdMinimaEstoque { get; set; }
        public string CodigoBarras { get; set; }
        public string Observacoes { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DataValidade { get; set; }
        public virtual ICollection<itemtransferenciaestoque> itemtransferenciaestoques { get; set; }
        public virtual marcaproduto marcaproduto { get; set; }
        public virtual tipoproduto tipoproduto { get; set; }
        public virtual unidademedida unidademedida { get; set; }
        public virtual ICollection<tabelapreco> tabelaprecoes { get; set; }
    }
}
