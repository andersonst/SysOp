using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class itemsolicitacaocompracotacao
    {
        public itemsolicitacaocompracotacao()
        {
            this.itempedidocompracotacaos = new List<itempedidocompracotacao>();
        }

        public int IdItemSolicitacaoCompraCotacao { get; set; }
        public Nullable<int> IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdItemRetornoCotacao { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorUnitario { get; set; }
        public virtual ICollection<itempedidocompracotacao> itempedidocompracotacaos { get; set; }
        public virtual itemretornocotacao itemretornocotacao { get; set; }
        public virtual solicitacaocompra solicitacaocompra { get; set; }
    }
}
