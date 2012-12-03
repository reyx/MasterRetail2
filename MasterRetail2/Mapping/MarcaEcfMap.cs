using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class MarcaEcfMap : EntityTypeConfiguration<MarcaEcf>
    {
        public MarcaEcfMap()
        {
            // Primary Key
            this.HasKey(t => t.MarcaEcfId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("MARCAS_ECF");
            this.Property(t => t.MarcaEcfId).HasColumnName("ID_MECF");
            this.Property(t => t.Descricao).HasColumnName("DESC_MECF");
            this.Property(t => t.Observacao).HasColumnName("OBS_MECF");
        }
    }
}