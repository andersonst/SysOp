using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class NotaFiscalEnt
    {
        public NotaFiscalEnt()
        {
            this.EntradaProdutoNFs = new List<EntradaProdutoNFEnt>();
            this.ItemProdutoNotaFiscals = new List<ItemProdutoNotaFiscalEnt>();
        }

        public int IdNotaFiscal { get; set; }
        public Nullable<int> NumeroNF { get; set; }
        public Nullable<int> Serie { get; set; }
        public Nullable<int> CodRegimeTrib { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string ChaveAcesso { get; set; }
        public string PalavrasChave { get; set; }
        public string Observacoes { get; set; }
        public virtual ICollection<EntradaProdutoNFEnt> EntradaProdutoNFs { get; set; }
        public virtual ICollection<ItemProdutoNotaFiscalEnt> ItemProdutoNotaFiscals { get; set; }
    }
}
