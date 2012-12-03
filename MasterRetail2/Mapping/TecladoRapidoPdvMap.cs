using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TecladoRapidoPdvMap : EntityTypeConfiguration<TecladoRapidoPdv>
    {
        public TecladoRapidoPdvMap()
        {
            // Primary Key
            this.HasKey(t => t.TecladoRapidoPdvId);

            // Properties
            // Table & Column Mappings
            this.ToTable("TECLADOS_RAPIDOS_PDV");
            this.Property(t => t.TecladoRapidoPdvId).HasColumnName("ID_TRPD");
            this.Property(t => t.PdvId).HasColumnName("ID_PDV");
            this.Property(t => t.TecladoRapidoId).HasColumnName("ID_TCRP");
            this.Property(t => t.Ordem).HasColumnName("ORDEM_TRPD");

            // Relationships
            this.HasOptional(t => t.Pdv)
                .WithMany(t => t.TecladosRapidos)
                .HasForeignKey(d => d.PdvId);

            this.HasOptional(t => t.TecladoRapido)
                .WithMany(t => t.Pdvs)
                .HasForeignKey(d => d.TecladoRapidoId);

        }
    }
}