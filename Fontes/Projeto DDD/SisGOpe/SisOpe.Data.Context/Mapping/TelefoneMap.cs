using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class TelefoneMap : EntityTypeConfiguration<Telefone>
    {
        public TelefoneMap()
        {
            // Primary Key
            this.HasKey(t => t.IdTelefone);

            // Properties
            this.Property(t => t.Tipo)
                .HasMaxLength(20);

            this.Property(t => t.DDD)
                .HasMaxLength(2);

            this.Property(t => t.Telefone1)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Telefone");
            this.Property(t => t.IdTelefone).HasColumnName("IdTelefone");
            this.Property(t => t.Tipo).HasColumnName("Tipo");
            this.Property(t => t.DDD).HasColumnName("DDD");
            this.Property(t => t.Telefone1).HasColumnName("Telefone");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.Telefones)
                .HasForeignKey(d => d.IdPessoa);

        }
    }
}
