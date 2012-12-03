using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class GrauRelacionamentoMap : EntityTypeConfiguration<GrauRelacionamento>
    {
        public GrauRelacionamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.GrauRelacionamentoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("GRAUS_RELACIONAMENTO");
            this.Property(t => t.GrauRelacionamentoId).HasColumnName("COD_GRRL");
            this.Property(t => t.Descricao).HasColumnName("DESC_GRRL");
        }
    }
}