using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TipoEquipamentoMap : EntityTypeConfiguration<TipoEquipamento>
    {
        public TipoEquipamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.TipoEquipamentoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("TIPOS_EQUIPAMENTO");
            this.Property(t => t.TipoEquipamentoId).HasColumnName("ID_TPEQ");
            this.Property(t => t.Descricao).HasColumnName("DESC_TPEQ");
        }
    }
}