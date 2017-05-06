using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class itemestoqueMap : EntityTypeConfiguration<itemestoque>
    {
        public itemestoqueMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemEstoque);

            // Properties
            // Table & Column Mappings
            this.ToTable("itemestoque", "sysop");
            this.Property(t => t.IdItemEstoque).HasColumnName("IdItemEstoque");
            this.Property(t => t.IdUnidade).HasColumnName("IdUnidade");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.Data).HasColumnName("Data");

            // Relationships
            this.HasOptional(t => t.produto)
                .WithMany(t => t.itemestoques)
                .HasForeignKey(d => d.IdProduto);
            this.HasOptional(t => t.unidade)
                .WithMany(t => t.itemestoques)
                .HasForeignKey(d => d.IdUnidade);

        }
    }
}
