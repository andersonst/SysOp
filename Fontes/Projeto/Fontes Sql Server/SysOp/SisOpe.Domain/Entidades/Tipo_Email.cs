using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Tipo_Email
    {
        public Tipo_Email()
        {
            this.contato_email = new List<Contato_email>();
        }

        public long ID { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public virtual ICollection<Contato_email> contato_email { get; set; }
    }
}
