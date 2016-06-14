using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class ItemTransferenciaEstoqueMap : EntityTypeConfiguration<ItemTransferenciaEstoque>
    {
        public ItemTransferenciaEstoqueMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemTransferenciaEstoque);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ItemTransferenciaEstoque");
            this.Property(t => t.IdItemTransferenciaEstoque).HasColumnName("IdItemTransferenciaEstoque");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.IdLocalOrigem).HasColumnName("IdLocalOrigem");
            this.Property(t => t.IdLocalDestino).HasColumnName("IdLocalDestino");
            this.Property(t => t.IdTE).HasColumnName("IdTE");

            // Relationships
            this.HasOptional(t => t.Produto)
                .WithMany(t => t.ItemTransferenciaEstoques)
                .HasForeignKey(d => d.IdProduto);
            this.HasOptional(t => t.TransferenciaEstoque)
                .WithMany(t => t.ItemTransferenciaEstoques)
                .HasForeignKey(d => d.IdTE);
            this.HasOptional(t => t.Unidade)
                .WithMany(t => t.IdLocalOrigem)
                .HasForeignKey(d => d.IdLocalDestino);
            this.HasOptional(t => t.Unidade1)
                .WithMany(t => t.IdLocalDestino)
                .HasForeignKey(d => d.IdLocalOrigem);

        }
    }
}
