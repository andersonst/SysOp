using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class AcessoEnt
    {
        public AcessoEnt()
        {
            this.AcessoUsuarios = new List<AcessoUsuarioEnt>();
        }

        public int IdAcesso { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<AcessoUsuarioEnt> AcessoUsuarios { get; set; }
    }
}
