using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class SolicitacaoPedidoCompraMap : EntityTypeConfiguration<Solicitacaopedidocompra>
    {
        public SolicitacaoPedidoCompraMap()
        {
            // Primary Key
            this.HasKey(t => t.IdSolicitacaoPedidoCompra);

            // Properties
            // Table & Column Mappings
            this.ToTable("solicitacaopedidocompra", "sysop");
            this.Property(t => t.IdSolicitacaoPedidoCompra).HasColumnName("IdSolicitacaoPedidoCompra");
            this.Property(t => t.IdSolicitacaoCompra).HasColumnName("IdSolicitacaoCompra");
            this.Property(t => t.IdPedidoCompra).HasColumnName("IdPedidoCompra");

            // Relationships
            this.HasOptional(t => t.pedidocompra)
                .WithMany(t => t.solicitacaopedidocompras)
                .HasForeignKey(d => d.IdPedidoCompra);
            this.HasOptional(t => t.solicitacaocompra)
                .WithMany(t => t.solicitacaopedidocompras)
                .HasForeignKey(d => d.IdSolicitacaoCompra);

        }
    }
}
