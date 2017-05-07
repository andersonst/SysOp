using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Ecf_Total_Tipo_Pgto
    {
        public long ID { get; set; }
        public long ID_ECF_VENDA_CABECALHO { get; set; }
        public long ID_ECF_TIPO_PAGAMENTO { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public string NSU { get; set; }
        public virtual Ecf_Tipo_Pagamento ecf_tipo_pagamento { get; set; }
        public virtual Ecf_Venda_Cabecalho ecf_venda_cabecalho { get; set; }
    }
}
