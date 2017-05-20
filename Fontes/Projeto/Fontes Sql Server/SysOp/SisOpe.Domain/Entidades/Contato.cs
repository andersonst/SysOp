using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Contato
    {
        public Contato()
        {
            this.contato_email = new List<Contato_email>();
            this.contato_telefone = new List<Contato_Telefone>();
        }

        public long ID { get; set; }
        public long ID_CLIENTE { get; set; }
        public string NOME { get; set; }
        public virtual Cliente cliente { get; set; }
        public virtual ICollection<Contato_email> contato_email { get; set; }
        public virtual ICollection<Contato_Telefone> contato_telefone { get; set; }
    }
}
