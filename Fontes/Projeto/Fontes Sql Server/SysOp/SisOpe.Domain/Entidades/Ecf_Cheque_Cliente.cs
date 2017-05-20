using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Cheque_Cliente
    {
        public long ID { get; set; }
        public long ID_BANCO { get; set; }
        public long ID_PESSOA { get; set; }
        public Nullable<long> NUMERO_CHEQUE { get; set; }
        public Nullable<System.DateTime> DATA_CHEQUE { get; set; }
        public Nullable<decimal> VALOR_CHEQUE { get; set; }
        public string OBSERVACOES { get; set; }
        public virtual Banco banco { get; set; }
        public virtual Pessoa pessoa { get; set; }
    }
}
