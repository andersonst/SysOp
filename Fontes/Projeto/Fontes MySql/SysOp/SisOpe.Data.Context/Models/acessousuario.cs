using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class acessousuario
    {
        public int IdAcessoUsuario { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdAcesso { get; set; }
        public virtual acesso acesso { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
