using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Dav_Detalhe
    {
        public long ID { get; set; }
        public long ID_PRODUTO { get; set; }
        public long ID_ECF_DAV { get; set; }
        public Nullable<decimal> QUANTIDADE { get; set; }
        public Nullable<decimal> VALOR_UNITARIO { get; set; }
        public Nullable<decimal> VALOR_TOTAL { get; set; }
        public virtual Ecf_Dav_Cabecalho ecf_dav_cabecalho { get; set; }
        public virtual Produto produto { get; set; }
    }
}
