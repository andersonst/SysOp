using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class unidadeMap : EntityTypeConfiguration<Unidade>
    {
        public unidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUnidade);

            // Properties
            // Table & Column Mappings
            this.ToTable("unidade", "sysop");
            this.Property(t => t.IdUnidade).HasColumnName("IdUnidade");
            this.Property(t => t.IdPessoaJuridica).HasColumnName("IdPessoaJuridica");
            this.Property(t => t.IdMatriz).HasColumnName("IdMatriz");
        }
    }
}
