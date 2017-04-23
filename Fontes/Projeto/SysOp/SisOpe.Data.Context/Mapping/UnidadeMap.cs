using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class UnidadeMap : EntityTypeConfiguration<Unidade>
    {
        public UnidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUnidade);

            // Properties
            // Table & Column Mappings
            this.ToTable("Unidade");
            this.Property(t => t.IdUnidade).HasColumnName("IdUnidade");
            this.Property(t => t.IdPessoaJuridica).HasColumnName("IdPessoaJuridica");
            this.Property(t => t.IdMatriz).HasColumnName("IdMatriz");
        }
    }
}
