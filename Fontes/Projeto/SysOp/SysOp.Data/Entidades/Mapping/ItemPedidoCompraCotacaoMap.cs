using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class ItemPedidoCompraCotacaoMap : EntityTypeConfiguration<ItemPedidoCompraCotacaoEnt>
    {
        public ItemPedidoCompraCotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemPedidoCompraCotacao);

            // Properties
            // Table & Column Mappings
            this.ToTable("ItemPedidoCompraCotacao");
            this.Property(t => t.IdItemPedidoCompraCotacao).HasColumnName("IdItemPedidoCompraCotacao");
            this.Property(t => t.IdItemSolicitacaoCompraCotatcao).HasColumnName("IdItemSolicitacaoCompraCotatcao");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.IdPedidoCompra).HasColumnName("IdPedidoCompra");

            // Relationships
            this.HasOptional(t => t.ItemSolicitacaoCompraCotacao)
                .WithMany(t => t.ItemPedidoCompraCotacaos)
                .HasForeignKey(d => d.IdItemSolicitacaoCompraCotatcao);
            this.HasOptional(t => t.PedidoCompra)
                .WithMany(t => t.ItemPedidoCompraCotacaos)
                .HasForeignKey(d => d.IdPedidoCompra);

        }
    }
}
