using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class pessoajuridicaMap : EntityTypeConfiguration<PessoaJuridica>
    {
        public pessoajuridicaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPessoaJuridica);

            // Properties
            this.Property(t => t.CNPJ)
                .HasMaxLength(14);

            this.Property(t => t.IE)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("pessoajuridica", "sysop");
            this.Property(t => t.IdPessoaJuridica).HasColumnName("IdPessoaJuridica");
            this.Property(t => t.CNPJ).HasColumnName("CNPJ");
            this.Property(t => t.IE).HasColumnName("IE");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");

            // Relationships
            this.HasOptional(t => t.pessoa)
                .WithMany(t => t.pessoajuridicas)
                .HasForeignKey(d => d.IdPessoa);

        }
    }
}
