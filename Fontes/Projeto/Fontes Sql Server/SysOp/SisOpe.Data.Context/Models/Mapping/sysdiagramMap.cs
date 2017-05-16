using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class sysdiagramMap : EntityTypeConfiguration<sysdiagram>
    {
        public sysdiagramMap()
        {
            // Primary Key
            this.HasKey(t => t.diagram_id);

            // Properties
            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(160);

            // Table & Column Mappings
            this.ToTable("sysdiagrams", "sysop");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.principal_id).HasColumnName("principal_id");
            this.Property(t => t.diagram_id).HasColumnName("diagram_id");
            this.Property(t => t.version).HasColumnName("version");
            this.Property(t => t.definition).HasColumnName("definition");
        }
    }
}
