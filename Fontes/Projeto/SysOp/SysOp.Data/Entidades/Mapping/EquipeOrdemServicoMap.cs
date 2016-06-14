using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class EquipeOrdemServicoMap : EntityTypeConfiguration<EquipeOrdemServicoEnt>
    {
        public EquipeOrdemServicoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdEquipeOrdemServico);

            // Properties
            // Table & Column Mappings
            this.ToTable("EquipeOrdemServico");
            this.Property(t => t.IdEquipeOrdemServico).HasColumnName("IdEquipeOrdemServico");
            this.Property(t => t.IdOrdemServico).HasColumnName("IdOrdemServico");
            this.Property(t => t.IdFuncionario).HasColumnName("IdFuncionario");

            // Relationships
            this.HasOptional(t => t.OrdemServico)
                .WithMany(t => t.EquipeOrdemServicoes)
                .HasForeignKey(d => d.IdOrdemServico);

        }
    }
}
