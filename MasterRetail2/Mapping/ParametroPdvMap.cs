using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ParametroPdvMap : EntityTypeConfiguration<ParametroPdv>
    {
        public ParametroPdvMap()
        {
            // Primary Key
            this.HasKey(t => t.ParametroPdvId);

            // Properties
            this.Property(t => t.Valor)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("PARAMETROS_PDV");
            this.Property(t => t.ParametroPdvId).HasColumnName("ID_PRPD");
            this.Property(t => t.PdvId).HasColumnName("ID_PDV");
            this.Property(t => t.TipoParametroPdvId).HasColumnName("ID_TPPD");
            this.Property(t => t.Valor).HasColumnName("VALOR_PRPD");
            this.Property(t => t.Texto).HasColumnName("TEXTO_PRPD");

            // Relationships
            this.HasOptional(t => t.Pdv)
                .WithMany(t => t.Parametros)
                .HasForeignKey(d => d.PdvId);

            this.HasOptional(t => t.TipoParametroPdv)
                .WithMany(t => t.ParametrosPdv)
                .HasForeignKey(d => d.TipoParametroPdvId);

        }
    }
}