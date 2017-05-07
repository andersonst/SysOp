using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class itempedidocompracotacaoMap : EntityTypeConfiguration<ItemPedidoCompraCotacao>
    {
        public itempedidocompracotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemPedidoCompraCotacao);

            // Properties
            // Table & Column Mappings
            this.ToTable("itempedidocompracotacao", "sysop");
            this.Property(t => t.IdItemPedidoCompraCotacao).HasColumnName("IdItemPedidoCompraCotacao");
            this.Property(t => t.IdItemSolicitacaoCompraCotatcao).HasColumnName("IdItemSolicitacaoCompraCotatcao");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.IdPedidoCompra).HasColumnName("IdPedidoCompra");

            // Relationships
            this.HasOptional(t => t.itemsolicitacaocompracotacao)
                .WithMany(t => t.itempedidocompracotacaos)
                .HasForeignKey(d => d.IdItemSolicitacaoCompraCotatcao);
            this.HasOptional(t => t.pedidocompra)
                .WithMany(t => t.itempedidocompracotacaos)
                .HasForeignKey(d => d.IdPedidoCompra);

        }
    }
}
