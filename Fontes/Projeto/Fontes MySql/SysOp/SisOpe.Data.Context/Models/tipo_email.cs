using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class tipo_email
    {
        public tipo_email()
        {
            this.contato_email = new List<contato_email>();
        }

        public long ID { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public virtual ICollection<contato_email> contato_email { get; set; }
    }
}
