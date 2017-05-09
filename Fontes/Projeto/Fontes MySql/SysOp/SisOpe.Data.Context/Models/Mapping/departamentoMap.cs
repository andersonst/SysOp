using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class DepartamentoMap : EntityTypeConfiguration<Departamento>
    {
        public DepartamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdDepartamento);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("departamento", "sysop");
            this.Property(t => t.IdDepartamento).HasColumnName("IdDepartamento");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
