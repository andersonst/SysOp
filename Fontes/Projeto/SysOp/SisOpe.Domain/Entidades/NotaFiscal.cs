using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class NotaFiscal
    {
        public NotaFiscal()
        {
            this.EntradaProdutoNFs = new List<EntradaProdutoNF>();
            this.ItemProdutoNotaFiscals = new List<ItemProdutoNotaFiscal>();
        }

        public int IdNotaFiscal { get; set; }
        public Nullable<int> NumeroNF { get; set; }
        public Nullable<int> Serie { get; set; }
        public Nullable<int> CodRegimeTrib { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string ChaveAcesso { get; set; }
        public string PalavrasChave { get; set; }
        public string Observacoes { get; set; }
        public virtual ICollection<EntradaProdutoNF> EntradaProdutoNFs { get; set; }
        public virtual ICollection<ItemProdutoNotaFiscal> ItemProdutoNotaFiscals { get; set; }
    }
}
