using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_cheque_cliente
    {
        public long ID { get; set; }
        public long ID_BANCO { get; set; }
        public long ID_PESSOA { get; set; }
        public Nullable<long> NUMERO_CHEQUE { get; set; }
        public Nullable<System.DateTime> DATA_CHEQUE { get; set; }
        public Nullable<decimal> VALOR_CHEQUE { get; set; }
        public string OBSERVACOES { get; set; }
        public virtual banco banco { get; set; }
        public virtual pessoa pessoa { get; set; }
    }
}
