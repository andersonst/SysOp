using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Acesso
    {
        public Acesso()
        {
            this.AcessoUsuarios = new List<AcessoUsuario>();
        }

        public int IdAcesso { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<AcessoUsuario> AcessoUsuarios { get; set; }
    }
}
