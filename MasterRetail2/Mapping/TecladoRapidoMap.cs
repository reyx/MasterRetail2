using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TecladoRapidoMap : EntityTypeConfiguration<TecladoRapido>
    {
        public TecladoRapidoMap()
        {
            // Primary Key
            this.HasKey(t => t.TecladoRapidoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("TECLADOS_RAPIDOS");
            this.Property(t => t.TecladoRapidoId).HasColumnName("ID_TCRP");
            this.Property(t => t.Descricao).HasColumnName("DESC_TCRP");
            this.Property(t => t.Icone).HasColumnName("ICONE_TCRP");
            this.Property(t => t.Ordem).HasColumnName("ORDEM_TCRP");
        }
    }
}