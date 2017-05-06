using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class itemprodutonotafiscal
    {
        public int IdItemProdutoNotaFiscal { get; set; }
        public Nullable<long> IdProduto { get; set; }
        public Nullable<int> Lote { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorUnitario { get; set; }
        public Nullable<decimal> ValorFrete { get; set; }
        public Nullable<decimal> ValorDesconto { get; set; }
        public Nullable<decimal> ValorSeguro { get; set; }
        public Nullable<decimal> IPI { get; set; }
        public Nullable<decimal> ICMS { get; set; }
        public Nullable<int> IdNotaFiscal { get; set; }
        public virtual notafiscal notafiscal { get; set; }
        public virtual produto produto { get; set; }
    }
}
