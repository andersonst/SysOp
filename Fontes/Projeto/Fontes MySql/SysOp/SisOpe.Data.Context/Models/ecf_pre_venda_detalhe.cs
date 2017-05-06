using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_pre_venda_detalhe
    {
        public long ID { get; set; }
        public long ID_PRODUTO { get; set; }
        public long ID_ECF_PRE_VENDA_CABECALHO { get; set; }
        public Nullable<decimal> QUANTIDADE { get; set; }
        public Nullable<decimal> VALOR_UNITARIO { get; set; }
        public Nullable<decimal> VALOR_TOTAL { get; set; }
        public virtual ecf_pre_venda_cabecalho ecf_pre_venda_cabecalho { get; set; }
        public virtual produto produto { get; set; }
    }
}
