using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class equipeordemservicoMap : EntityTypeConfiguration<EquipeOrdemServico>
    {
        public equipeordemservicoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdEquipeOrdemServico);

            // Properties
            // Table & Column Mappings
            this.ToTable("equipeordemservico", "sysop");
            this.Property(t => t.IdEquipeOrdemServico).HasColumnName("IdEquipeOrdemServico");
            this.Property(t => t.IdOrdemServico).HasColumnName("IdOrdemServico");
            this.Property(t => t.IdFuncionario).HasColumnName("IdFuncionario");

            // Relationships
            this.HasOptional(t => t.ordemservico)
                .WithMany(t => t.equipeordemservicoes)
                .HasForeignKey(d => d.IdOrdemServico);

        }
    }
}
