using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
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
