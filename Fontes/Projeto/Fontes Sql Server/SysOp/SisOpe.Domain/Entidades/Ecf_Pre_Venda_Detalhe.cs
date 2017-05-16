using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Pre_Venda_Detalhe
    {
        public long ID { get; set; }
        public long ID_PRODUTO { get; set; }
        public long ID_ECF_PRE_VENDA_CABECALHO { get; set; }
        public Nullable<decimal> QUANTIDADE { get; set; }
        public Nullable<decimal> VALOR_UNITARIO { get; set; }
        public Nullable<decimal> VALOR_TOTAL { get; set; }
        public virtual Ecf_Pre_Venda_Cabecalho ecf_pre_venda_cabecalho { get; set; }
        public virtual Produto produto { get; set; }
    }
}
