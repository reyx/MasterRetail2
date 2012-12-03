using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class PropriedadeMap : EntityTypeConfiguration<Propriedade>
    {
        public PropriedadeMap()
        {
            // Primary Key
            this.HasKey(t => t.PropriedadeId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("PROPRIEDADES");
            this.Property(t => t.PropriedadeId).HasColumnName("COD_PROP");
            this.Property(t => t.Descricao).HasColumnName("DESC_PROP");
        }
    }
}