using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class RegimeTributarioMap : EntityTypeConfiguration<RegimeTributario>
    {
        public RegimeTributarioMap()
        {
            // Primary Key
            this.HasKey(t => t.RegimeTributarioId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("REGIMES_TRIBUTARIOS");
            this.Property(t => t.RegimeTributarioId).HasColumnName("ID_RGTR");
            this.Property(t => t.Descricao).HasColumnName("DESC_RGTR");
        }
    }
}