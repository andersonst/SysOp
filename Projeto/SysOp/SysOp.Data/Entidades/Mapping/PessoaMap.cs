using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class PessoaMap : EntityTypeConfiguration<PessoaEnt>
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
            this.ToTable("Pessoa");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.TipoCadastro).HasColumnName("TipoCadastro");
        }
    }
}
