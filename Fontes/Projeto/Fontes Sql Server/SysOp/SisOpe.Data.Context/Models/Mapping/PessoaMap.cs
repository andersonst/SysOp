using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPessoa);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(100);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("pessoa", "sysop");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.TipoCadastro).HasColumnName("TipoCadastro");
        }
    }
}
