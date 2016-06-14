using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class PedidoCompraMap : EntityTypeConfiguration<PedidoCompraEnt>
    {
        public PedidoCompraMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPedidoCompra);

            // Properties
            this.Property(t => t.Automatico)
                .HasMaxLength(20);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PedidoCompra");
            this.Property(t => t.IdPedidoCompra).HasColumnName("IdPedidoCompra");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.Automatico).HasColumnName("Automatico");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
