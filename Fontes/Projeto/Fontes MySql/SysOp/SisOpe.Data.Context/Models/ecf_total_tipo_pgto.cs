using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_total_tipo_pgto
    {
        public long ID { get; set; }
        public long ID_ECF_VENDA_CABECALHO { get; set; }
        public long ID_ECF_TIPO_PAGAMENTO { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public string NSU { get; set; }
        public virtual ecf_tipo_pagamento ecf_tipo_pagamento { get; set; }
        public virtual ecf_venda_cabecalho ecf_venda_cabecalho { get; set; }
    }
}
