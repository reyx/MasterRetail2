using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class HistoricoEquipamentoMap : EntityTypeConfiguration<HistoricoEquipamento>
    {
        public HistoricoEquipamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.HistoricoEquipamentoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("HISTORICOS_EQUIPAMENTOS");
            this.Property(t => t.HistoricoEquipamentoId).HasColumnName("ID_HSEQ");
            this.Property(t => t.Descricao).HasColumnName("DESC_HSEQ");
        }
    }
}