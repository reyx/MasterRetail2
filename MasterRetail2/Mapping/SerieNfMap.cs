using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class SerieNfMap : EntityTypeConfiguration<SerieNf>
    {
        public SerieNfMap()
        {
            // Primary Key
            this.HasKey(t => t.SerieNfId);

            // Properties
            this.Property(t => t.PrincipalString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Principal);

            // Table & Column Mappings
            this.ToTable("SERIES_NF");
            this.Property(t => t.SerieNfId).HasColumnName("ID_SRNF");
            this.Property(t => t.Numero).HasColumnName("NUMERO_SRNF");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.PrincipalString).HasColumnName("PRINCIPAL_SRNF");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.SeriesNf)
                .HasForeignKey(d => d.LojaId);

        }
    }
}