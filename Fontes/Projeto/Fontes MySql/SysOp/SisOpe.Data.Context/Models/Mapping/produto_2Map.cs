using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class produto_2Map : EntityTypeConfiguration<Produto_2>
    {
        public produto_2Map()
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
            this.ToTable("produto_2", "sysop");
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
            this.HasOptional(t => t.marcaproduto)
                .WithMany(t => t.produto_2)
                .HasForeignKey(d => d.IdMarcaProduto);
            this.HasOptional(t => t.tipoproduto)
                .WithMany(t => t.produto_2)
                .HasForeignKey(d => d.IdTipoProduto);
            this.HasOptional(t => t.unidademedida)
                .WithMany(t => t.produto_2)
                .HasForeignKey(d => d.IdUnidadeMedida);

        }
    }
}
