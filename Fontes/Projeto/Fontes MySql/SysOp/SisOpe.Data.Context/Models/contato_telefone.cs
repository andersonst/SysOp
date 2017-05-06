using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class contato_telefone
    {
        public long ID { get; set; }
        public long ID_CONTATO { get; set; }
        public long ID_TIPO_TELEFONE { get; set; }
        public string TELEFONE { get; set; }
        public virtual contato contato { get; set; }
        public virtual tipo_telefone tipo_telefone { get; set; }
    }
}
