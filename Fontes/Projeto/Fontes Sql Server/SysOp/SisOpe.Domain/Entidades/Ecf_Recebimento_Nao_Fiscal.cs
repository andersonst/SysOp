using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Recebimento_Nao_Fiscal
    {
        public long ID { get; set; }
        public long ID_ECF_MOVIMENTO { get; set; }
        public Nullable<System.DateTime> DATA_RECBTO { get; set; }
        public string DESCRICAO { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public virtual Ecf_Movimento ecf_movimento { get; set; }
    }
}
