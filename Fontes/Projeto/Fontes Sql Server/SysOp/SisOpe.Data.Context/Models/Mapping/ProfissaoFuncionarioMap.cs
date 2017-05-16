using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ProfissaoFuncionarioMap : EntityTypeConfiguration<ProfissaoFuncionario>
    {
        public ProfissaoFuncionarioMap()
        {
            // Primary Key
            this.HasKey(t => t.IdProfissaoFuncionario);

            // Properties
            // Table & Column Mappings
            this.ToTable("profissaofuncionario", "sysop");
            this.Property(t => t.IdProfissaoFuncionario).HasColumnName("IdProfissaoFuncionario");
            this.Property(t => t.IdProfissao).HasColumnName("IdProfissao");
            this.Property(t => t.IdFuncionario).HasColumnName("IdFuncionario");
            this.Property(t => t.DataInicio).HasColumnName("DataInicio");
            this.Property(t => t.DataFim).HasColumnName("DataFim");
        }
    }
}
