using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TipoDespesaMap : EntityTypeConfiguration<TipoDespesa>
    {
        public TipoDespesaMap()
        {
            // Primary Key
            this.HasKey(t => t.TipoDespesaId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.HistoricoObrigatorioString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.HistoricoObrigatorio);

            this.Property(t => t.PadraoZeroString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.PadraoZero);

            // Table & Column Mappings
            this.ToTable("TIPOS_DESPESA");
            this.Property(t => t.TipoDespesaId).HasColumnName("ID_TPDS");
            this.Property(t => t.GrupoDespesaId).HasColumnName("ID_GRDS");
            this.Property(t => t.Descricao).HasColumnName("DESC_TPDS");
            this.Property(t => t.HistoricoObrigatorioString).HasColumnName("HISTOBRIG_TPDS");
            this.Property(t => t.PadraoZeroString).HasColumnName("PADRAOZERO_TPDS");
            this.Property(t => t.Margem).HasColumnName("MARGEM_TPDS");
            this.Property(t => t.ValorPadrao).HasColumnName("VALORPADRAO_TPDS");

            // Relationships
            this.HasOptional(t => t.GrupoDespesa)
                .WithMany(t => t.TiposDespesa)
                .HasForeignKey(d => d.GrupoDespesaId);

        }
    }
}