using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class vendaprodutonf
    {
        public int IdVendaProdutoNF { get; set; }
        public Nullable<int> IdVendaProduto { get; set; }
        public Nullable<int> IdNotaFiscal { get; set; }
    }
}
