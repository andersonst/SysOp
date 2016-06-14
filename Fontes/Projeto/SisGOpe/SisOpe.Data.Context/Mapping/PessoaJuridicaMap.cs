using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class PessoaJuridicaMap : EntityTypeConfiguration<PessoaJuridica>
    {
        public PessoaJuridicaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPessoaJuridica);

            // Properties
            this.Property(t => t.CNPJ)
                .HasMaxLength(14);

            this.Property(t => t.IE)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PessoaJuridica");
            this.Property(t => t.IdPessoaJuridica).HasColumnName("IdPessoaJuridica");
            this.Property(t => t.CNPJ).HasColumnName("CNPJ");
            this.Property(t => t.IE).HasColumnName("IE");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.PessoaJuridicas)
                .HasForeignKey(d => d.IdPessoa);

        }
    }
}
