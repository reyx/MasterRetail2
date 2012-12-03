using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class GrupoDespesaMap : EntityTypeConfiguration<GrupoDespesa>
    {
        public GrupoDespesaMap()
        {
            // Primary Key
            this.HasKey(t => t.GrupoDespesaId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GRUPOS_DESPESAS");
            this.Property(t => t.GrupoDespesaId).HasColumnName("ID_GRDS");
            this.Property(t => t.Grupo).HasColumnName("GRUPO_GRDS");
            this.Property(t => t.Descricao).HasColumnName("DESC_GRDS");
        }
    }
}