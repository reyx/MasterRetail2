using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ProgramaMap : EntityTypeConfiguration<Programa>
    {
        public ProgramaMap()
        {
            // Primary Key
            this.HasKey(t => t.ProgramaId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PROGRAMAS");
            this.Property(t => t.ProgramaId).HasColumnName("COD_PROG");
            this.Property(t => t.Descricao).HasColumnName("DESC_PROG");
        }
    }
}