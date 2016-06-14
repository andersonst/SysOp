using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class ItemSolicitacaoCompraCotacaoMap : EntityTypeConfiguration<ItemSolicitacaoCompraCotacao>
    {
        public ItemSolicitacaoCompraCotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemSolicitacaoCompraCotacao);

            // Properties
            // Table & Column Mappings
            this.ToTable("ItemSolicitacaoCompraCotacao");
            this.Property(t => t.IdItemSolicitacaoCompraCotacao).HasColumnName("IdItemSolicitacaoCompraCotacao");
            this.Property(t => t.IdSolicitacaoCompra).HasColumnName("IdSolicitacaoCompra");
            this.Property(t => t.IdItemRetornoCotacao).HasColumnName("IdItemRetornoCotacao");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.ValorUnitario).HasColumnName("ValorUnitario");

            // Relationships
            this.HasOptional(t => t.ItemRetornoCotacao)
                .WithMany(t => t.ItemSolicitacaoCompraCotacaos)
                .HasForeignKey(d => d.IdItemRetornoCotacao);
            this.HasOptional(t => t.SolicitacaoCompra)
                .WithMany(t => t.ItemSolicitacaoCompraCotacaos)
                .HasForeignKey(d => d.IdSolicitacaoCompra);

        }
    }
}
