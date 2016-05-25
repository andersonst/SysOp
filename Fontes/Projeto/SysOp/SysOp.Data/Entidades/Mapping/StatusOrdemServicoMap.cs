using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class StatusOrdemServicoMap : EntityTypeConfiguration<StatusOrdemServicoEnt>
    {
        public StatusOrdemServicoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdStatusOrdemServico);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(100);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("StatusOrdemServico");
            this.Property(t => t.IdStatusOrdemServico).HasColumnName("IdStatusOrdemServico");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
