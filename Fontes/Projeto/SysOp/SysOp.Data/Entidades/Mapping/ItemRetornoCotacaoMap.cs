using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class ItemRetornoCotacaoMap : EntityTypeConfiguration<ItemRetornoCotacaoEnt>
    {
        public ItemRetornoCotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemRetornoCotacao);

            // Properties
            // Table & Column Mappings
            this.ToTable("ItemRetornoCotacao");
            this.Property(t => t.IdItemRetornoCotacao).HasColumnName("IdItemRetornoCotacao");
            this.Property(t => t.IdProdutoCotacao).HasColumnName("IdProdutoCotacao");
            this.Property(t => t.IdFornecedorCotacao).HasColumnName("IdFornecedorCotacao");
            this.Property(t => t.QuantidadeFornecedor).HasColumnName("QuantidadeFornecedor");
            this.Property(t => t.ValorUnitarioFornecedor).HasColumnName("ValorUnitarioFornecedor");
            this.Property(t => t.DiasParaEntrega).HasColumnName("DiasParaEntrega");

            // Relationships
            this.HasOptional(t => t.FornecedorCotacao)
                .WithMany(t => t.ItemRetornoCotacaos)
                .HasForeignKey(d => d.IdFornecedorCotacao);
            this.HasOptional(t => t.ProdutoCotacao)
                .WithMany(t => t.ItemRetornoCotacaos)
                .HasForeignKey(d => d.IdProdutoCotacao);

        }
    }
}
