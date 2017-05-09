using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_ImpressoraMap : EntityTypeConfiguration<Ecf_Impressora>
    {
        public Ecf_ImpressoraMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CODIGO)
                .HasMaxLength(10);

            this.Property(t => t.SERIE)
                .HasMaxLength(20);

            this.Property(t => t.IDENTIFICACAO)
                .HasMaxLength(250);

            this.Property(t => t.MC)
                .HasMaxLength(2);

            this.Property(t => t.MD)
                .HasMaxLength(2);

            this.Property(t => t.VR)
                .HasMaxLength(2);

            this.Property(t => t.TIPO)
                .HasMaxLength(7);

            this.Property(t => t.MARCA)
                .HasMaxLength(30);

            this.Property(t => t.MODELO_ACBR)
                .HasMaxLength(30);

            this.Property(t => t.MODELO)
                .HasMaxLength(30);

            this.Property(t => t.VERSAO)
                .HasMaxLength(30);

            this.Property(t => t.LE)
                .HasMaxLength(1);

            this.Property(t => t.LEF)
                .HasMaxLength(1);

            this.Property(t => t.MFD)
                .HasMaxLength(1);

            this.Property(t => t.CRENAMFD)
                .HasMaxLength(1);

            this.Property(t => t.DOCTO)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("ecf_impressora", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CODIGO).HasColumnName("CODIGO");
            this.Property(t => t.SERIE).HasColumnName("SERIE");
            this.Property(t => t.IDENTIFICACAO).HasColumnName("IDENTIFICACAO");
            this.Property(t => t.MC).HasColumnName("MC");
            this.Property(t => t.MD).HasColumnName("MD");
            this.Property(t => t.VR).HasColumnName("VR");
            this.Property(t => t.TIPO).HasColumnName("TIPO");
            this.Property(t => t.MARCA).HasColumnName("MARCA");
            this.Property(t => t.MODELO_ACBR).HasColumnName("MODELO_ACBR");
            this.Property(t => t.MODELO).HasColumnName("MODELO");
            this.Property(t => t.VERSAO).HasColumnName("VERSAO");
            this.Property(t => t.LE).HasColumnName("LE");
            this.Property(t => t.LEF).HasColumnName("LEF");
            this.Property(t => t.MFD).HasColumnName("MFD");
            this.Property(t => t.CRENAMFD).HasColumnName("CRENAMFD");
            this.Property(t => t.DOCTO).HasColumnName("DOCTO");
        }
    }
}
