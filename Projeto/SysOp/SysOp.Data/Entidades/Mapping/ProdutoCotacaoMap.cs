using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class ProdutoCotacaoMap : EntityTypeConfiguration<ProdutoCotacaoEnt>
    {
        public ProdutoCotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdProdutoCotacao);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProdutoCotacao");
            this.Property(t => t.IdProdutoCotacao).HasColumnName("IdProdutoCotacao");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.IdCotacao).HasColumnName("IdCotacao");
            this.Property(t => t.IdDepartamento).HasColumnName("IdDepartamento");
            this.Property(t => t.IdFinalidade).HasColumnName("IdFinalidade");
            this.Property(t => t.QuantidadeCotada).HasColumnName("QuantidadeCotada");

            // Relationships
            this.HasOptional(t => t.Cotacao)
                .WithMany(t => t.ProdutoCotacaos)
                .HasForeignKey(d => d.IdCotacao);
            this.HasOptional(t => t.Departamento)
                .WithMany(t => t.ProdutoCotacaos)
                .HasForeignKey(d => d.IdDepartamento);
            this.HasOptional(t => t.Finalidade)
                .WithMany(t => t.ProdutoCotacaos)
                .HasForeignKey(d => d.IdFinalidade);

        }
    }
}
