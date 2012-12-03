using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class FoneDialUpMap : EntityTypeConfiguration<FoneDialUp>
    {
        public FoneDialUpMap()
        {
            // Primary Key
            this.HasKey(t => t.FoneDialUpId);

            // Properties
            this.Property(t => t.DDD)
                .HasMaxLength(6);

            this.Property(t => t.Numero)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("FONES_DIALUP");
            this.Property(t => t.FoneDialUpId).HasColumnName("ID_FNDU");
            this.Property(t => t.CidadeId).HasColumnName("ID_CID");
            this.Property(t => t.DDD).HasColumnName("DDD_FNDU");
            this.Property(t => t.Numero).HasColumnName("FONE_FNDU");
        }
    }
}