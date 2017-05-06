using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class contato
    {
        public contato()
        {
            this.contato_email = new List<contato_email>();
            this.contato_telefone = new List<contato_telefone>();
        }

        public long ID { get; set; }
        public long ID_CLIENTE { get; set; }
        public string NOME { get; set; }
        public virtual cliente cliente { get; set; }
        public virtual ICollection<contato_email> contato_email { get; set; }
        public virtual ICollection<contato_telefone> contato_telefone { get; set; }
    }
}
