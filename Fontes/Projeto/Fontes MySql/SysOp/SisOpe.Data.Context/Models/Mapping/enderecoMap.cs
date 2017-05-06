using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class enderecoMap : EntityTypeConfiguration<endereco>
    {
        public enderecoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.LOGRADOURO)
                .HasMaxLength(100);

            this.Property(t => t.COMPLEMENTO)
                .HasMaxLength(100);

            this.Property(t => t.BAIRRO)
                .HasMaxLength(50);

            this.Property(t => t.CEP)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("endereco", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_PESSOA).HasColumnName("ID_PESSOA");
            this.Property(t => t.LOGRADOURO).HasColumnName("LOGRADOURO");
            this.Property(t => t.NUMERO).HasColumnName("NUMERO");
            this.Property(t => t.COMPLEMENTO).HasColumnName("COMPLEMENTO");
            this.Property(t => t.BAIRRO).HasColumnName("BAIRRO");
            this.Property(t => t.CEP).HasColumnName("CEP");

            // Relationships
            this.HasRequired(t => t.pessoa)
                .WithMany(t => t.enderecoes)
                .HasForeignKey(d => d.ID_PESSOA);

        }
    }
}
