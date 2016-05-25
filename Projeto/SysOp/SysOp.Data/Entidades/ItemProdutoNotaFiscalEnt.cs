using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class ItemProdutoNotaFiscalEnt
    {
        public int IdItemProdutoNotaFiscal { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<int> Lote { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorUnitario { get; set; }
        public Nullable<decimal> ValorFrete { get; set; }
        public Nullable<decimal> ValorDesconto { get; set; }
        public Nullable<decimal> ValorSeguro { get; set; }
        public Nullable<decimal> IPI { get; set; }
        public Nullable<decimal> ICMS { get; set; }
        public Nullable<int> IdNotaFiscal { get; set; }
        public virtual NotaFiscalEnt NotaFiscal { get; set; }
        public virtual ProdutoEnt Produto { get; set; }
    }
}
