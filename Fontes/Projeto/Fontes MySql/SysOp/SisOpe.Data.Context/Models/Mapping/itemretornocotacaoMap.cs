using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ItemRetornoCotacaoMap : EntityTypeConfiguration<ItemRetornoCotacao>
    {
        public ItemRetornoCotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemRetornoCotacao);

            // Properties
            // Table & Column Mappings
            this.ToTable("itemretornocotacao", "sysop");
            this.Property(t => t.IdItemRetornoCotacao).HasColumnName("IdItemRetornoCotacao");
            this.Property(t => t.IdProdutoCotacao).HasColumnName("IdProdutoCotacao");
            this.Property(t => t.IdFornecedorCotacao).HasColumnName("IdFornecedorCotacao");
            this.Property(t => t.QuantidadeFornecedor).HasColumnName("QuantidadeFornecedor");
            this.Property(t => t.ValorUnitarioFornecedor).HasColumnName("ValorUnitarioFornecedor");
            this.Property(t => t.DiasParaEntrega).HasColumnName("DiasParaEntrega");

            // Relationships
            this.HasOptional(t => t.fornecedorcotacao)
                .WithMany(t => t.itemretornocotacaos)
                .HasForeignKey(d => d.IdFornecedorCotacao);
            this.HasOptional(t => t.produtocotacao)
                .WithMany(t => t.itemretornocotacaos)
                .HasForeignKey(d => d.IdProdutoCotacao);

        }
    }
}
