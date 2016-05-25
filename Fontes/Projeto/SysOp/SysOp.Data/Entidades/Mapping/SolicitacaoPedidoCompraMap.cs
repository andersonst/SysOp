using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class SolicitacaoPedidoCompraMap : EntityTypeConfiguration<SolicitacaoPedidoCompraEnt>
    {
        public SolicitacaoPedidoCompraMap()
        {
            // Primary Key
            this.HasKey(t => t.IdSolicitacaoPedidoCompra);

            // Properties
            // Table & Column Mappings
            this.ToTable("SolicitacaoPedidoCompra");
            this.Property(t => t.IdSolicitacaoPedidoCompra).HasColumnName("IdSolicitacaoPedidoCompra");
            this.Property(t => t.IdSolicitacaoCompra).HasColumnName("IdSolicitacaoCompra");
            this.Property(t => t.IdPedidoCompra).HasColumnName("IdPedidoCompra");

            // Relationships
            this.HasOptional(t => t.PedidoCompra)
                .WithMany(t => t.SolicitacaoPedidoCompras)
                .HasForeignKey(d => d.IdPedidoCompra);
            this.HasOptional(t => t.SolicitacaoCompra)
                .WithMany(t => t.SolicitacaoPedidoCompras)
                .HasForeignKey(d => d.IdSolicitacaoCompra);

        }
    }
}
