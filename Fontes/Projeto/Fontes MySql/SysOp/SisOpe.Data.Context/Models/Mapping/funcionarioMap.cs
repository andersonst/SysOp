using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class funcionarioMap : EntityTypeConfiguration<funcionario>
    {
        public funcionarioMap()
        {
            // Primary Key
            this.HasKey(t => t.IdFuncionario);

            // Properties
            this.Property(t => t.Foto)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("funcionario", "sysop");
            this.Property(t => t.IdFuncionario).HasColumnName("IdFuncionario");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");
            this.Property(t => t.ValorHora).HasColumnName("ValorHora");
            this.Property(t => t.Foto).HasColumnName("Foto");
        }
    }
}
