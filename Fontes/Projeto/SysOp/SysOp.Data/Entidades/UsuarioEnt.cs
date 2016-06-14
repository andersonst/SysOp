using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class UsuarioEnt
    {
        public UsuarioEnt()
        {
            this.AcessoUsuarios = new List<AcessoUsuarioEnt>();
            this.HistoricoStatusCotacaos = new List<HistoricoStatusCotacaoEnt>();
            this.Reservas = new List<ReservaEnt>();
        }

        public int IdUsuario { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Nullable<bool> Status { get; set; }
        public virtual ICollection<AcessoUsuarioEnt> AcessoUsuarios { get; set; }
        public virtual ICollection<HistoricoStatusCotacaoEnt> HistoricoStatusCotacaos { get; set; }
        public virtual PessoaEnt Pessoa { get; set; }
        public virtual ICollection<ReservaEnt> Reservas { get; set; }
    }
}
