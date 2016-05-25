using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class ProfissaoFuncionarioMap : EntityTypeConfiguration<ProfissaoFuncionarioEnt>
    {
        public ProfissaoFuncionarioMap()
        {
            // Primary Key
            this.HasKey(t => t.IdProfissaoFuncionario);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProfissaoFuncionario");
            this.Property(t => t.IdProfissaoFuncionario).HasColumnName("IdProfissaoFuncionario");
            this.Property(t => t.IdProfissao).HasColumnName("IdProfissao");
            this.Property(t => t.IdFuncionario).HasColumnName("IdFuncionario");
            this.Property(t => t.DataInicio).HasColumnName("DataInicio");
            this.Property(t => t.DataFim).HasColumnName("DataFim");
        }
    }
}
