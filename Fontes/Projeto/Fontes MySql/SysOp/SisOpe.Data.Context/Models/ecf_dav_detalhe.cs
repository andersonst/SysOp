using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_dav_detalhe
    {
        public long ID { get; set; }
        public long ID_PRODUTO { get; set; }
        public long ID_ECF_DAV { get; set; }
        public Nullable<decimal> QUANTIDADE { get; set; }
        public Nullable<decimal> VALOR_UNITARIO { get; set; }
        public Nullable<decimal> VALOR_TOTAL { get; set; }
        public virtual ecf_dav_cabecalho ecf_dav_cabecalho { get; set; }
        public virtual produto produto { get; set; }
    }
}
