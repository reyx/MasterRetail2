using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TipoSangriaMap : EntityTypeConfiguration<TipoSangria>
    {
        public TipoSangriaMap()
        {
            // Primary Key
            this.HasKey(t => t.TipoSangriaId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Autorizacao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Emissao)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("TIPOS_SANGRIA");
            this.Property(t => t.TipoSangriaId).HasColumnName("COD_TPSG");
            this.Property(t => t.Descricao).HasColumnName("DESC_TPSG");
            this.Property(t => t.Autorizacao).HasColumnName("AUTORIZA_TPSG");
            this.Property(t => t.Emissao).HasColumnName("EMISSAO_TPSG");
        }
    }
}