using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Situacao_cli
    {
        public Situacao_cli()
        {
            this.clientes = new List<Cliente>();
        }

        public long ID { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public virtual ICollection<Cliente> clientes { get; set; }
    }
}
