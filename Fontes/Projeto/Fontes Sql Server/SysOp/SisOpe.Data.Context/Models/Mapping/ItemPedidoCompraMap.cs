using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ItemPedidoCompraMap : EntityTypeConfiguration<ItemPedidoCompra>
    {
        public ItemPedidoCompraMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemPedidoCompra);

            // Properties
            // Table & Column Mappings
            this.ToTable("itempedidocompra", "sysop");
            this.Property(t => t.IdItemPedidoCompra).HasColumnName("IdItemPedidoCompra");
            this.Property(t => t.IdItemSolicitacaoCompra).HasColumnName("IdItemSolicitacaoCompra");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.IdPedidoCompra).HasColumnName("IdPedidoCompra");

            // Relationships
            this.HasOptional(t => t.itemsolicitacaocompra)
                .WithMany(t => t.itempedidocompras)
                .HasForeignKey(d => d.IdItemSolicitacaoCompra);
            this.HasOptional(t => t.pedidocompra)
                .WithMany(t => t.itempedidocompras)
                .HasForeignKey(d => d.IdPedidoCompra);

        }
    }
}
