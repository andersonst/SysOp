using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class VendaProdutoNFEnt
    {
        public int IdVendaProdutoNF { get; set; }
        public Nullable<int> IdVendaProduto { get; set; }
        public Nullable<int> IdNotaFiscal { get; set; }
    }
}
