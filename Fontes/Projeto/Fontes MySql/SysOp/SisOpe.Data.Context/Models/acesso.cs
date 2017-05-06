using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class acesso
    {
        public acesso()
        {
            this.acessousuarios = new List<acessousuario>();
        }

        public int IdAcesso { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<acessousuario> acessousuarios { get; set; }
    }
}
