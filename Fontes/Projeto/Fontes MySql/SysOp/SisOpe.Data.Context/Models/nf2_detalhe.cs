using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Nf2_Detalhe
    {
        public long ID { get; set; }
        public long ID_CFOP { get; set; }
        public long ID_ECF_TRIBUTO_PRODUTO { get; set; }
        public long ID_PRODUTO { get; set; }
        public long ID_NF2_CABECALHO { get; set; }
        public Nullable<int> ITEM { get; set; }
        public Nullable<decimal> QUANTIDADE { get; set; }
        public Nullable<decimal> VALOR_UNITARIO { get; set; }
        public Nullable<decimal> VALOR_TOTAL { get; set; }
        public Nullable<decimal> BASE_ICMS { get; set; }
        public Nullable<decimal> TAXA_ICMS { get; set; }
        public Nullable<decimal> ICMS { get; set; }
        public Nullable<decimal> ICMS_OUTRAS { get; set; }
        public Nullable<decimal> ICMS_ISENTO { get; set; }
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
        public Nullable<decimal> TAXA_IPI { get; set; }
        public Nullable<decimal> IPI { get; set; }
        public string CANCELADO { get; set; }
        public string MOVIMENTA_ESTOQUE { get; set; }
        public virtual Cfop cfop { get; set; }
        public virtual Ecf_Tributo_Produto ecf_tributo_produto { get; set; }
        public virtual Nf2_Cabecalho nf2_cabecalho { get; set; }
        public virtual Produto produto { get; set; }
    }
}
