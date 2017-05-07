using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class arquivosordemservicoMap : EntityTypeConfiguration<ArquivosOrdemServico>
    {
        public arquivosordemservicoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdArquivosOrdemServico);

            // Properties
            this.Property(t => t.PathArquivo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("arquivosordemservico", "sysop");
            this.Property(t => t.IdArquivosOrdemServico).HasColumnName("IdArquivosOrdemServico");
            this.Property(t => t.IdOrdemServico).HasColumnName("IdOrdemServico");
            this.Property(t => t.PathArquivo).HasColumnName("PathArquivo");

            // Relationships
            this.HasOptional(t => t.ordemservico)
                .WithMany(t => t.arquivosordemservicoes)
                .HasForeignKey(d => d.IdOrdemServico);

        }
    }
}
