using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class PessoaFisicaMap : EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPessoaFisica);

            // Properties
            this.Property(t => t.CPF)
                .HasMaxLength(11);

            this.Property(t => t.RG)
                .HasMaxLength(9);

            this.Property(t => t.Sexo)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("PessoaFisica");
            this.Property(t => t.IdPessoaFisica).HasColumnName("IdPessoaFisica");
            this.Property(t => t.CPF).HasColumnName("CPF");
            this.Property(t => t.RG).HasColumnName("RG");
            this.Property(t => t.DataNascimento).HasColumnName("DataNascimento");
            this.Property(t => t.Sexo).HasColumnName("Sexo");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.PessoaFisicas)
                .HasForeignKey(d => d.IdPessoa);

        }
    }
}
