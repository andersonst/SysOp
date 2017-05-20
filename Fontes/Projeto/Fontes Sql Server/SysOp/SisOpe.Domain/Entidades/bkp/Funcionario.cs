using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Funcionario
    {
        public int IdFuncionario { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public Nullable<decimal> ValorHora { get; set; }
        public string Foto { get; set; }
    }
}
