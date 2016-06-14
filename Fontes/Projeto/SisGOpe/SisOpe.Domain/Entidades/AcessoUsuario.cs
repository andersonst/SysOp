using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class AcessoUsuario
    {
        public int IdAcessoUsuario { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdAcesso { get; set; }
        public virtual Acesso Acesso { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
