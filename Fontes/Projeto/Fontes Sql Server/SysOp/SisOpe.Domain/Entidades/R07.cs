using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class R07
    {
        public long ID { get; set; }
        public Nullable<long> ID_R06 { get; set; }
        public Nullable<long> ID_R02 { get; set; }
        public Nullable<int> CCF { get; set; }
        public string MEIO_PAGAMENTO { get; set; }
        public Nullable<decimal> VALOR_PAGAMENTO { get; set; }
        public string ESTORNO { get; set; }
        public Nullable<decimal> VALOR_ESTORNO { get; set; }
        public virtual R02 r02 { get; set; }
        public virtual R06 r06 { get; set; }
    }
}
