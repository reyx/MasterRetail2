using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class HistoricoLancamentoMap : EntityTypeConfiguration<HistoricoLancamento>
    {
        public HistoricoLancamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.HistoricoLancamentoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Operacao)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("HISTORICOS");
            this.Property(t => t.HistoricoLancamentoId).HasColumnName("COD_HIST");
            this.Property(t => t.Descricao).HasColumnName("DESC_HIST");
            this.Property(t => t.Operacao).HasColumnName("OPER_HIST");
        }
    }
}