using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Tipo_Telefone
    {
        public Tipo_Telefone()
        {
            this.contato_telefone = new List<Contato_Telefone>();
        }

        public long ID { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public virtual ICollection<Contato_Telefone> contato_telefone { get; set; }
    }
}
