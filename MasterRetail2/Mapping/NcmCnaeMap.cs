using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class NcmCnaeMap : EntityTypeConfiguration<NcmCnae>
    {
        public NcmCnaeMap()
        {
            // Primary Key
            this.HasKey(t => t.NcmCnaeId);

            // Properties
            // Table & Column Mappings
            this.ToTable("NCMS_CNAE");
            this.Property(t => t.NcmCnaeId).HasColumnName("ID_NCCN");
            this.Property(t => t.CnaeId).HasColumnName("ID_CNAE");
            this.Property(t => t.NcmId).HasColumnName("ID_NCM");

            // Relationships
            this.HasOptional(t => t.Cnae)
                .WithMany(t => t.NcmsCnae)
                .HasForeignKey(d => d.CnaeId);

            this.HasOptional(t => t.Ncm)
                .WithMany(t => t.NcmsCnae)
                .HasForeignKey(d => d.NcmId);

        }
    }
}