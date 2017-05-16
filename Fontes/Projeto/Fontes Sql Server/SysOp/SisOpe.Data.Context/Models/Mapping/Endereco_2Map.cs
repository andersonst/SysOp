using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Endereco_2Map : EntityTypeConfiguration<Endereco_2>
    {
        public Endereco_2Map()
        {
            // Primary Key
            this.HasKey(t => t.IdEndereco);

            // Properties
            this.Property(t => t.Logradouro)
                .HasMaxLength(200);

            this.Property(t => t.Complemento)
                .HasMaxLength(50);

            this.Property(t => t.Bairro)
                .HasMaxLength(50);

            this.Property(t => t.Cidade)
                .HasMaxLength(80);

            this.Property(t => t.CEP)
                .HasMaxLength(20);

            this.Property(t => t.PontoReferencia)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("endereco_2", "sysop");
            this.Property(t => t.IdEndereco).HasColumnName("IdEndereco");
            this.Property(t => t.Logradouro).HasColumnName("Logradouro");
            this.Property(t => t.Complemento).HasColumnName("Complemento");
            this.Property(t => t.Bairro).HasColumnName("Bairro");
            this.Property(t => t.Cidade).HasColumnName("Cidade");
            this.Property(t => t.CEP).HasColumnName("CEP");
            this.Property(t => t.PontoReferencia).HasColumnName("PontoReferencia");
            this.Property(t => t.Primario).HasColumnName("Primario");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");

            // Relationships
            this.HasOptional(t => t.pessoa)
                .WithMany(t => t.endereco_2)
                .HasForeignKey(d => d.IdPessoa);

        }
    }
}
