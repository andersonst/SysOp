using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class HistoricoOrdemServicoMap : EntityTypeConfiguration<HistoricoOrdemServico>
    {
        public HistoricoOrdemServicoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdHistoricoOrdemServico);

            // Properties
            this.Property(t => t.Observacao)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("historicoordemservico", "sysop");
            this.Property(t => t.IdHistoricoOrdemServico).HasColumnName("IdHistoricoOrdemServico");
            this.Property(t => t.IdOrdemServico).HasColumnName("IdOrdemServico");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
            this.Property(t => t.Observacao).HasColumnName("Observacao");

            // Relationships
            this.HasOptional(t => t.ordemservico)
                .WithMany(t => t.historicoordemservicoes)
                .HasForeignKey(d => d.IdOrdemServico);

        }
    }
}
