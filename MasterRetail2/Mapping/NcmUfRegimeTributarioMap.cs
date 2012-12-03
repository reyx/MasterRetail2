using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class NcmUfRegimeTributarioMap : EntityTypeConfiguration<NcmUfRegimeTributario>
    {
        public NcmUfRegimeTributarioMap()
        {
            // Primary Key
            this.HasKey(t => t.NcmUfRegimeTributarioId);

            // Properties
            // Table & Column Mappings
            this.ToTable("NCMS_UF_REGIME_TRIBUTARIO");
            this.Property(t => t.NcmUfRegimeTributarioId).HasColumnName("ID_NURT");
            this.Property(t => t.NcmId).HasColumnName("ID_NCM");
            this.Property(t => t.UfId).HasColumnName("ID_UF");
            this.Property(t => t.RegimeTributarioId).HasColumnName("ID_RGTR");
            this.Property(t => t.Mva).HasColumnName("MVA_NURT");
            this.Property(t => t.Reducao).HasColumnName("REDUCAO_NURT");
            this.Property(t => t.Aliquota).HasColumnName("ALIQUOTA_NURT");
            this.Property(t => t.ReducaoSt).HasColumnName("REDUCAOST_NURT");
            this.Property(t => t.AliquotaSt).HasColumnName("ALIQUOTAST_NURT");

            // Relationships
            this.HasOptional(t => t.Ncm)
                .WithMany(t => t.NcmsUfRegimeTributario)
                .HasForeignKey(d => d.NcmId);

            this.HasOptional(t => t.RegimeTributario)
                .WithMany(t => t.NcmsUfRegimeTributario)
                .HasForeignKey(d => d.RegimeTributarioId);

            this.HasOptional(t => t.Uf)
                .WithMany(t => t.NcmsUfRegimeTributario)
                .HasForeignKey(d => d.UfId);

        }
    }
}