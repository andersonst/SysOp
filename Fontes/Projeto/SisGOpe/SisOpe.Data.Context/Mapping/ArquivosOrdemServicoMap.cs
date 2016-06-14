using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class ArquivosOrdemServicoMap : EntityTypeConfiguration<ArquivosOrdemServico>
    {
        public ArquivosOrdemServicoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdArquivosOrdemServico);

            // Properties
            this.Property(t => t.PathArquivo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ArquivosOrdemServico");
            this.Property(t => t.IdArquivosOrdemServico).HasColumnName("IdArquivosOrdemServico");
            this.Property(t => t.IdOrdemServico).HasColumnName("IdOrdemServico");
            this.Property(t => t.PathArquivo).HasColumnName("PathArquivo");

            // Relationships
            this.HasOptional(t => t.OrdemServico)
                .WithMany(t => t.ArquivosOrdemServicoes)
                .HasForeignKey(d => d.IdOrdemServico);

        }
    }
}
