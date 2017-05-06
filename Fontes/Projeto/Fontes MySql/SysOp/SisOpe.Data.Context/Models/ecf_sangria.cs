using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_sangria
    {
        public long ID { get; set; }
        public long ID_ECF_MOVIMENTO { get; set; }
        public Nullable<System.DateTime> DATA_SANGRIA { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public virtual ecf_movimento ecf_movimento { get; set; }
    }
}
