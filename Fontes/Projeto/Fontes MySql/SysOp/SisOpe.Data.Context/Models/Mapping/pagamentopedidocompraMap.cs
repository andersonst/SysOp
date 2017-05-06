using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class pagamentopedidocompraMap : EntityTypeConfiguration<pagamentopedidocompra>
    {
        public pagamentopedidocompraMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPagamentoPedidoCompra);

            // Properties
            this.Property(t => t.NumeroDocumento)
                .HasMaxLength(20);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("pagamentopedidocompra", "sysop");
            this.Property(t => t.IdPagamentoPedidoCompra).HasColumnName("IdPagamentoPedidoCompra");
            this.Property(t => t.IdPedidoCompra).HasColumnName("IdPedidoCompra");
            this.Property(t => t.Parcela).HasColumnName("Parcela");
            this.Property(t => t.IdFormaPagamento).HasColumnName("IdFormaPagamento");
            this.Property(t => t.NumeroDocumento).HasColumnName("NumeroDocumento");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.DataVencimento).HasColumnName("DataVencimento");
            this.Property(t => t.ValorPago).HasColumnName("ValorPago");
            this.Property(t => t.DataPagamento).HasColumnName("DataPagamento");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasOptional(t => t.pedidocompra)
                .WithMany(t => t.pagamentopedidocompras)
                .HasForeignKey(d => d.IdPedidoCompra);

        }
    }
}
