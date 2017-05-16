using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class NotaFiscal
    {
        public NotaFiscal()
        {
            this.entradaprodutonfs = new List<EntradaProdutoNF>();
            this.itemprodutonotafiscals = new List<ItemProdutoNotaFiscal>();
        }

        public int IdNotaFiscal { get; set; }
        public Nullable<int> NumeroNF { get; set; }
        public Nullable<int> Serie { get; set; }
        public Nullable<int> CodRegimeTrib { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string ChaveAcesso { get; set; }
        public string PalavrasChave { get; set; }
        public string Observacoes { get; set; }
        public virtual ICollection<EntradaProdutoNF> entradaprodutonfs { get; set; }
        public virtual ICollection<ItemProdutoNotaFiscal> itemprodutonotafiscals { get; set; }
    }
}
