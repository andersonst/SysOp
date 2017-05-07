using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class produtocotacaoMap : EntityTypeConfiguration<ProdutocCotacao>
    {
        public produtocotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdProdutoCotacao);

            // Properties
            // Table & Column Mappings
            this.ToTable("produtocotacao", "sysop");
            this.Property(t => t.IdProdutoCotacao).HasColumnName("IdProdutoCotacao");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.IdCotacao).HasColumnName("IdCotacao");
            this.Property(t => t.IdDepartamento).HasColumnName("IdDepartamento");
            this.Property(t => t.IdFinalidade).HasColumnName("IdFinalidade");
            this.Property(t => t.QuantidadeCotada).HasColumnName("QuantidadeCotada");

            // Relationships
            this.HasOptional(t => t.cotacao)
                .WithMany(t => t.produtocotacaos)
                .HasForeignKey(d => d.IdCotacao);
            this.HasOptional(t => t.departamento)
                .WithMany(t => t.produtocotacaos)
                .HasForeignKey(d => d.IdDepartamento);
            this.HasOptional(t => t.finalidade)
                .WithMany(t => t.produtocotacaos)
                .HasForeignKey(d => d.IdFinalidade);

        }
    }
}
