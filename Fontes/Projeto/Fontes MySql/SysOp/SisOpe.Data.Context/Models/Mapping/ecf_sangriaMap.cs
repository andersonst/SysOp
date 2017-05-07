using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ecf_sangriaMap : EntityTypeConfiguration<Ecf_Sangria>
    {
        public ecf_sangriaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ecf_sangria", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_ECF_MOVIMENTO).HasColumnName("ID_ECF_MOVIMENTO");
            this.Property(t => t.DATA_SANGRIA).HasColumnName("DATA_SANGRIA");
            this.Property(t => t.VALOR).HasColumnName("VALOR");

            // Relationships
            this.HasRequired(t => t.ecf_movimento)
                .WithMany(t => t.ecf_sangria)
                .HasForeignKey(d => d.ID_ECF_MOVIMENTO);

        }
    }
}
