using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class ItemReservaVendaProduto
    {
        public int IdItemReservaProduto { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<System.DateTime> DataSeparacao { get; set; }
        public Nullable<System.DateTime> DataAtual { get; set; }
        public string Status { get; set; }
        public Nullable<int> IdVendaProduto { get; set; }
        public Nullable<int> IdTE { get; set; }
        public Nullable<int> QtdTotalEstoque { get; set; }
        public Nullable<int> IdUnidade { get; set; }
        public Nullable<int> IdReserva { get; set; }
        public virtual Reserva Reserva { get; set; }
        public virtual TransferenciaEstoque TransferenciaEstoque { get; set; }
        public virtual Unidade Unidade { get; set; }
        public virtual VendaProduto VendaProduto { get; set; }
    }
}
