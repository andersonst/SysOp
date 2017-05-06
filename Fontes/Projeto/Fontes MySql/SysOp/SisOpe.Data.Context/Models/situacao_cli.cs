using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class situacao_cli
    {
        public situacao_cli()
        {
            this.clientes = new List<cliente>();
        }

        public long ID { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public virtual ICollection<cliente> clientes { get; set; }
    }
}
