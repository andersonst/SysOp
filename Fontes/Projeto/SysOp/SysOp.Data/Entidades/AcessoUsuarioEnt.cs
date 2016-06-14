using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class AcessoUsuarioEnt
    {
        public int IdAcessoUsuario { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdAcesso { get; set; }
        public virtual AcessoEnt Acesso { get; set; }
        public virtual UsuarioEnt Usuario { get; set; }
    }
}
