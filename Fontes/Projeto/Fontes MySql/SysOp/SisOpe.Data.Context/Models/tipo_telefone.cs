using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class tipo_telefone
    {
        public tipo_telefone()
        {
            this.contato_telefone = new List<contato_telefone>();
        }

        public long ID { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public virtual ICollection<contato_telefone> contato_telefone { get; set; }
    }
}
