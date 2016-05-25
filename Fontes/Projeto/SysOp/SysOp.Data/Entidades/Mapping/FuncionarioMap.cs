using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class FuncionarioMap : EntityTypeConfiguration<FuncionarioEnt>
    {
        public FuncionarioMap()
        {
            // Primary Key
            this.HasKey(t => t.IdFuncionario);

            // Properties
            this.Property(t => t.Foto)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Funcionario");
            this.Property(t => t.IdFuncionario).HasColumnName("IdFuncionario");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");
            this.Property(t => t.ValorHora).HasColumnName("ValorHora");
            this.Property(t => t.Foto).HasColumnName("Foto");
        }
    }
}
