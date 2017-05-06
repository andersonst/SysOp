using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_recebimento_nao_fiscal
    {
        public long ID { get; set; }
        public long ID_ECF_MOVIMENTO { get; set; }
        public Nullable<System.DateTime> DATA_RECBTO { get; set; }
        public string DESCRICAO { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public virtual ecf_movimento ecf_movimento { get; set; }
    }
}
