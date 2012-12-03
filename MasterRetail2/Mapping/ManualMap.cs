using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ManualMap : EntityTypeConfiguration<Manual>
    {
        public ManualMap()
        {
            // Primary Key
            this.HasKey(t => t.ManualId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("MANUAIS");
            this.Property(t => t.ManualId).HasColumnName("ID_MANL");
            this.Property(t => t.Descricao).HasColumnName("DESC_MANL");
        }
    }
}