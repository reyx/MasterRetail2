using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class RecebimentoPdvMap : EntityTypeConfiguration<RecebimentoPdv>
    {
        public RecebimentoPdvMap()
        {
            // Primary Key
            this.HasKey(t => t.RecebimentoPdvId);

            // Properties
            // Table & Column Mappings
            this.ToTable("RECEBIMENTOS_PDV");
            this.Property(t => t.RecebimentoPdvId).HasColumnName("ID_RCPD");
            this.Property(t => t.MovimentoPdvId).HasColumnName("ID_MVPD");
            this.Property(t => t.TipoRecebimentoId).HasColumnName("COD_TPRC");
            this.Property(t => t.SubtipoRecebimentoId).HasColumnName("COD_STRC");
            this.Property(t => t.ParcelamentoSubtipoRecebimentoId).HasColumnName("COD_PRST");
            this.Property(t => t.Valor).HasColumnName("VALOR_RCPD");
            this.Property(t => t.Deposito).HasColumnName("DEPOSITO_RCPD");
            this.Property(t => t.Sangria).HasColumnName("SANGRIA_RCPD");
            this.Property(t => t.ValorLiquido).HasColumnName("VALORLIQ_RCPD");
            this.Property(t => t.ValorReal).HasColumnName("VALORREAL_RCPD");

            // Relationships
            this.HasOptional(t => t.MovimentoPdv)
                .WithMany(t => t.Recebimentos)
                .HasForeignKey(d => d.MovimentoPdvId);

        }
    }
}