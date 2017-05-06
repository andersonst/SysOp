using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class sintegra_60aMap : EntityTypeConfiguration<sintegra_60a>
    {
        public sintegra_60aMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SITUACAO_TRIBUTARIA)
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("sintegra_60a", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_SINTEGRA_60M).HasColumnName("ID_SINTEGRA_60M");
            this.Property(t => t.SITUACAO_TRIBUTARIA).HasColumnName("SITUACAO_TRIBUTARIA");
            this.Property(t => t.VALOR).HasColumnName("VALOR");
        }
    }
}
