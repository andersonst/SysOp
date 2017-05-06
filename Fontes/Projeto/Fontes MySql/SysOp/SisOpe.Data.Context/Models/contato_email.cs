using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class contato_email
    {
        public long ID { get; set; }
        public long ID_CONTATO { get; set; }
        public long ID_TIPO_EMAIL { get; set; }
        public string EMAIL { get; set; }
        public virtual contato contato { get; set; }
        public virtual tipo_email tipo_email { get; set; }
    }
}
