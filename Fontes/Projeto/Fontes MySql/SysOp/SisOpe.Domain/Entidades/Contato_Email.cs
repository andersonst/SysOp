using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Contato_email
    {
        public long ID { get; set; }
        public long ID_CONTATO { get; set; }
        public long ID_TIPO_EMAIL { get; set; }
        public string EMAIL { get; set; }
        public virtual Contato contato { get; set; }
        public virtual Tipo_Email tipo_email { get; set; }
    }
}
