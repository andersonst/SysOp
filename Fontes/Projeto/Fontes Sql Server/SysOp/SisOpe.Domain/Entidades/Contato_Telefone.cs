using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Contato_Telefone
    {
        public long ID { get; set; }
        public long ID_CONTATO { get; set; }
        public long ID_TIPO_TELEFONE { get; set; }
        public string TELEFONE { get; set; }
        public virtual Contato contato { get; set; }
        public virtual Tipo_Telefone tipo_telefone { get; set; }
    }
}
