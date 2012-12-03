using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ValorMapaResumoMap : EntityTypeConfiguration<ValorMapaResumo>
    {
        public ValorMapaResumoMap()
        {
            // Primary Key
            this.HasKey(t => t.ValorMapaResumoId);

            // Properties
            this.Property(t => t.Codigo)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("VALORES_MAPA_RESUMO");
            this.Property(t => t.ValorMapaResumoId).HasColumnName("ID_VLMR");
            this.Property(t => t.MapaResumoId).HasColumnName("ID_MPRS");
            this.Property(t => t.Codigo).HasColumnName("COD_CT");
            this.Property(t => t.Valor).HasColumnName("VALORTRIB_MPRS");
            this.Property(t => t.Taxa).HasColumnName("TAXATRIB_MPRS");

            // Relationships
            this.HasOptional(t => t.MapaResumo)
                .WithMany(t => t.ValoresMapaResumo)
                .HasForeignKey(d => d.MapaResumoId);

        }
    }
}