using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Documentos_Emitidos
    {
        public long ID { get; set; }
        public long ID_ECF_MOVIMENTO { get; set; }
        public Nullable<System.DateTime> DATA_HORA_EMISSAO { get; set; }
        public string TIPO { get; set; }
        public Nullable<long> COO { get; set; }
        public string SINCRONIZADO { get; set; }
        public virtual Ecf_Movimento ecf_movimento { get; set; }
    }
}
