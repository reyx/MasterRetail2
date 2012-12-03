using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class NumeroMapaResumoMap : EntityTypeConfiguration<NumeroMapaResumo>
    {
        public NumeroMapaResumoMap()
        {
            // Primary Key
            this.HasKey(t => t.NumeroMapaResumoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("NUMEROS_MAPA_RESUMO");
            this.Property(t => t.NumeroMapaResumoId).HasColumnName("ID_NMMP");
            this.Property(t => t.Data).HasColumnName("DATA_NMMP");
            this.Property(t => t.Numero).HasColumnName("NUMERO_NMMP");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.NumerosMapaResumo)
                .HasForeignKey(d => d.LojaId);

        }
    }
}