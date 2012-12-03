using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class LayoutCnabMap : EntityTypeConfiguration<LayoutCnab>
    {
        public LayoutCnabMap()
        {
            // Primary Key
            this.HasKey(t => t.LayoutCnabId);

            // Properties
            this.Property(t => t.Campo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Alinhamento)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Carpre)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Texto)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("LAYOUT_CNAB");
            this.Property(t => t.LayoutCnabId).HasColumnName("ID_LYCN");
            this.Property(t => t.BancoId).HasColumnName("COD_BCO");
            this.Property(t => t.ContaCorrenteId).HasColumnName("ID_CTCR");
            this.Property(t => t.TipoRegistro).HasColumnName("TIPOREG_LYCN");
            this.Property(t => t.Sequencia).HasColumnName("SEQ_LYCN");
            this.Property(t => t.Campo).HasColumnName("CAMPO_LYCN");
            this.Property(t => t.SomaDias).HasColumnName("SOMADIAS_LYCN");
            this.Property(t => t.Tamanho).HasColumnName("TAMANHO_LYCN");
            this.Property(t => t.Alinhamento).HasColumnName("ALINHA_LYCN");
            this.Property(t => t.Carpre).HasColumnName("CARPRE_LYCN");
            this.Property(t => t.Texto).HasColumnName("TEXTO_LYCN");

            // Relationships
            this.HasOptional(t => t.Banco)
                .WithMany(t => t.LayoutsCnab)
                .HasForeignKey(d => d.BancoId);

            this.HasOptional(t => t.ContaCorrente)
                .WithMany(t => t.LayoutsCnab)
                .HasForeignKey(d => d.ContaCorrenteId);

        }
    }
}