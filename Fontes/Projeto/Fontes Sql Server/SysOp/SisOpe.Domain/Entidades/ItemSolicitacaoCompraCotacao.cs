using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class ItemSolicitacaoCompraCotacao
    {
        public ItemSolicitacaoCompraCotacao()
        {
            this.itempedidocompracotacaos = new List<ItemPedidoCompraCotacao>();
        }

        public int IdItemSolicitacaoCompraCotacao { get; set; }
        public Nullable<int> IdSolicitacaoCompra { get; set; }
        public Nullable<int> IdItemRetornoCotacao { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorUnitario { get; set; }
        public virtual ICollection<ItemPedidoCompraCotacao> itempedidocompracotacaos { get; set; }
        public virtual ItemRetornoCotacao itemretornocotacao { get; set; }
        public virtual SolicitacaoCompra solicitacaocompra { get; set; }
    }
}
