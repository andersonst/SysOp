using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class fornecedorcotacaoMap : EntityTypeConfiguration<FornecedorCotacao>
    {
        public fornecedorcotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdFornecedorCotacao);

            // Properties
            this.Property(t => t.Observacao)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("fornecedorcotacao", "sysop");
            this.Property(t => t.IdFornecedorCotacao).HasColumnName("IdFornecedorCotacao");
            this.Property(t => t.IdFornecedor).HasColumnName("IdFornecedor");
            this.Property(t => t.IdCotacao).HasColumnName("IdCotacao");
            this.Property(t => t.ValorFrete).HasColumnName("ValorFrete");
            this.Property(t => t.Observacao).HasColumnName("Observacao");
            this.Property(t => t.DataRetorno).HasColumnName("DataRetorno");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");

            // Relationships
            this.HasOptional(t => t.cotacao)
                .WithMany(t => t.fornecedorcotacaos)
                .HasForeignKey(d => d.IdCotacao);
            this.HasOptional(t => t.pessoa)
                .WithMany(t => t.fornecedorcotacaos)
                .HasForeignKey(d => d.IdPessoa);

        }
    }
}
