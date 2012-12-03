using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class UfWebserviceMap : EntityTypeConfiguration<UfWebservice>
    {
        public UfWebserviceMap()
        {
            // Primary Key
            this.HasKey(t => t.UfWebserviceId);

            // Properties
            // Table & Column Mappings
            this.ToTable("UFS_WEBSERVICE");
            this.Property(t => t.UfWebserviceId).HasColumnName("ID_UFWS");
            this.Property(t => t.UfId).HasColumnName("ID_UF");
            this.Property(t => t.WebserviceId).HasColumnName("ID_WSVC");

            // Relationships
            this.HasOptional(t => t.Uf)
                .WithMany(t => t.Webservices)
                .HasForeignKey(d => d.UfId);

            this.HasOptional(t => t.Webservice)
                .WithMany(t => t.Ufs)
                .HasForeignKey(d => d.WebserviceId);

        }
    }
}