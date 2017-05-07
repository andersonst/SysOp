using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Acesso
    {
        //public Acesso()
        //{
        //    this.acessousuarios = new List<acessousuario>();
        //}

        public int IdAcesso { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<AcessoUsuario> acessousuarios { get; set; }
    }
}
