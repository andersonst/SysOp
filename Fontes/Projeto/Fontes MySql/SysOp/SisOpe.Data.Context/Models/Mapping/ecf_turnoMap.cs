using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_TurnoMap : EntityTypeConfiguration<Ecf_Turno>
    {
        public Ecf_TurnoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DESCRICAO)
                .HasMaxLength(10);

            this.Property(t => t.HORA_INICIO)
                .HasMaxLength(8);

            this.Property(t => t.HORA_FIM)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("ecf_turno", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DESCRICAO).HasColumnName("DESCRICAO");
            this.Property(t => t.HORA_INICIO).HasColumnName("HORA_INICIO");
            this.Property(t => t.HORA_FIM).HasColumnName("HORA_FIM");
        }
    }
}
