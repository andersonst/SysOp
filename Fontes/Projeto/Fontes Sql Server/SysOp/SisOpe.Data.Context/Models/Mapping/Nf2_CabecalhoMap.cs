using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Nf2_CabecalhoMap : EntityTypeConfiguration<Nf2_Cabecalho>
    {
        public Nf2_CabecalhoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NUMERO)
                .HasMaxLength(6);

            this.Property(t => t.SERIE)
                .HasMaxLength(2);

            this.Property(t => t.SUBSERIE)
                .HasMaxLength(2);

            this.Property(t => t.CANCELADA)
                .HasMaxLength(1);

            this.Property(t => t.SINCRONIZADO)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("nf2_cabecalho", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_CFOP).HasColumnName("ID_CFOP");
            this.Property(t => t.ID_ECF_FUNCIONARIO).HasColumnName("ID_ECF_FUNCIONARIO");
            this.Property(t => t.ID_CLIENTE).HasColumnName("ID_CLIENTE");
            this.Property(t => t.NUMERO).HasColumnName("NUMERO");
            this.Property(t => t.DATA_HORA_EMISSAO).HasColumnName("DATA_HORA_EMISSAO");
            this.Property(t => t.SERIE).HasColumnName("SERIE");
            this.Property(t => t.SUBSERIE).HasColumnName("SUBSERIE");
            this.Property(t => t.TOTAL_PRODUTOS).HasColumnName("TOTAL_PRODUTOS");
            this.Property(t => t.TOTAL_NF).HasColumnName("TOTAL_NF");
            this.Property(t => t.BASE_ICMS).HasColumnName("BASE_ICMS");
            this.Property(t => t.ICMS).HasColumnName("ICMS");
            this.Property(t => t.ICMS_OUTRAS).HasColumnName("ICMS_OUTRAS");
            this.Property(t => t.ISSQN).HasColumnName("ISSQN");
            this.Property(t => t.PIS).HasColumnName("PIS");
            this.Property(t => t.COFINS).HasColumnName("COFINS");
            this.Property(t => t.IPI).HasColumnName("IPI");
            this.Property(t => t.TAXA_ACRESCIMO).HasColumnName("TAXA_ACRESCIMO");
            this.Property(t => t.ACRESCIMO).HasColumnName("ACRESCIMO");
            this.Property(t => t.ACRESCIMO_ITENS).HasColumnName("ACRESCIMO_ITENS");
            this.Property(t => t.TAXA_DESCONTO).HasColumnName("TAXA_DESCONTO");
            this.Property(t => t.DESCONTO).HasColumnName("DESCONTO");
            this.Property(t => t.DESCONTO_ITENS).HasColumnName("DESCONTO_ITENS");
            this.Property(t => t.CANCELADA).HasColumnName("CANCELADA");
            this.Property(t => t.SINCRONIZADO).HasColumnName("SINCRONIZADO");

            // Relationships
            this.HasRequired(t => t.cfop)
                .WithMany(t => t.nf2_cabecalho)
                .HasForeignKey(d => d.ID_CFOP);
            this.HasRequired(t => t.pessoa)
                .WithMany(t => t.nf2_cabecalho)
                .HasForeignKey(d => d.ID_CLIENTE);
            this.HasRequired(t => t.pessoa1)
                .WithMany(t => t.nf2_cabecalho1)
                .HasForeignKey(d => d.ID_ECF_FUNCIONARIO);

        }
    }
}
