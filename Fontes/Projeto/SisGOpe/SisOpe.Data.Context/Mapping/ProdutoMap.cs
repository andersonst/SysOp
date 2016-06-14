using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdProduto);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(100);

            this.Property(t => t.CodigoBarras)
                .HasMaxLength(50);

            this.Property(t => t.Observacoes)
                .HasMaxLength(100);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Produto");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.IdUnidadeMedida).HasColumnName("IdUnidadeMedida");
            this.Property(t => t.IdMarcaProduto).HasColumnName("IdMarcaProduto");
            this.Property(t => t.IdTipoProduto).HasColumnName("IdTipoProduto");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.QtdMinimaEstoque).HasColumnName("QtdMinimaEstoque");
            this.Property(t => t.CodigoBarras).HasColumnName("CodigoBarras");
            this.Property(t => t.Observacoes).HasColumnName("Observacoes");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.DataValidade).HasColumnName("DataValidade");

            // Relationships
            this.HasOptional(t => t.MarcaProduto)
                .WithMany(t => t.Produtoes)
                .HasForeignKey(d => d.IdMarcaProduto);
            this.HasOptional(t => t.TipoProduto)
                .WithMany(t => t.Produtoes)
                .HasForeignKey(d => d.IdTipoProduto);
            this.HasOptional(t => t.UnidadeMedida)
                .WithMany(t => t.Produtoes)
                .HasForeignKey(d => d.IdUnidadeMedida);

        }
    }
}
