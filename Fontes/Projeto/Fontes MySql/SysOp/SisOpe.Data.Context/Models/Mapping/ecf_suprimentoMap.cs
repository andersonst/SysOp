using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ecf_suprimentoMap : EntityTypeConfiguration<ecf_suprimento>
    {
        public ecf_suprimentoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ecf_suprimento", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_ECF_MOVIMENTO).HasColumnName("ID_ECF_MOVIMENTO");
            this.Property(t => t.DATA_SUPRIMENTO).HasColumnName("DATA_SUPRIMENTO");
            this.Property(t => t.VALOR).HasColumnName("VALOR");

            // Relationships
            this.HasRequired(t => t.ecf_movimento)
                .WithMany(t => t.ecf_suprimento)
                .HasForeignKey(d => d.ID_ECF_MOVIMENTO);

        }
    }
}
