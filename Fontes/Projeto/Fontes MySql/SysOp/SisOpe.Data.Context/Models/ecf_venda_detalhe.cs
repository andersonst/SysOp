using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_venda_detalhe
    {
        public long ID { get; set; }
        public long ID_CFOP { get; set; }
        public long ID_ECF_TRIBUTO_PRODUTO { get; set; }
        public long ID_ECF_PRODUTO { get; set; }
        public long ID_ECF_VENDA_CABECALHO { get; set; }
        public Nullable<int> ITEM { get; set; }
        public Nullable<decimal> QUANTIDADE { get; set; }
        public Nullable<decimal> VALOR_UNITARIO { get; set; }
        public Nullable<decimal> VALOR_TOTAL { get; set; }
        public Nullable<decimal> TOTAL_ITEM { get; set; }
        public Nullable<decimal> BASE_ICMS { get; set; }
        public Nullable<decimal> TAXA_ICMS { get; set; }
        public Nullable<decimal> ICMS { get; set; }
        public Nullable<decimal> TAXA_DESCONTO { get; set; }
        public Nullable<decimal> DESCONTO { get; set; }
        public Nullable<decimal> TAXA_ISSQN { get; set; }
        public Nullable<decimal> ISSQN { get; set; }
        public Nullable<decimal> TAXA_PIS { get; set; }
        public Nullable<decimal> PIS { get; set; }
        public Nullable<decimal> TAXA_COFINS { get; set; }
        public Nullable<decimal> COFINS { get; set; }
        public Nullable<decimal> TAXA_ACRESCIMO { get; set; }
        public Nullable<decimal> ACRESCIMO { get; set; }
        public string TOTALIZADOR_PARCIAL { get; set; }
        public string CST { get; set; }
        public string CANCELADO { get; set; }
        public string MOVIMENTA_ESTOQUE { get; set; }
        public virtual cfop cfop { get; set; }
        public virtual ecf_tributo_produto ecf_tributo_produto { get; set; }
        public virtual ecf_venda_cabecalho ecf_venda_cabecalho { get; set; }
        public virtual produto produto { get; set; }
    }
}
