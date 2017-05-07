using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class ItemPedidoCompraMap : EntityTypeConfiguration<ItemPedidoCompra>
    {
        public ItemPedidoCompraMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemPedidoCompra);

            // Properties
            // Table & Column Mappings
            this.ToTable("ItemPedidoCompra");
            this.Property(t => t.IdItemPedidoCompra).HasColumnName("IdItemPedidoCompra");
            this.Property(t => t.IdItemSolicitacaoCompra).HasColumnName("IdItemSolicitacaoCompra");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.IdPedidoCompra).HasColumnName("IdPedidoCompra");

            // Relationships
            this.HasOptional(t => t.ItemSolicitacaoCompra)
                .WithMany(t => t.ItemPedidoCompras)
                .HasForeignKey(d => d.IdItemSolicitacaoCompra);
            this.HasOptional(t => t.PedidoCompra)
                .WithMany(t => t.ItemPedidoCompras)
                .HasForeignKey(d => d.IdPedidoCompra);

        }
    }
}
