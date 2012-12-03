using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class SituacaoTributariaMap : EntityTypeConfiguration<SituacaoTributaria>
    {
        public SituacaoTributariaMap()
        {
            // Primary Key
            this.HasKey(t => t.SituacaoTributariaId);

            // Properties
            this.Property(t => t.Codigo)
                .HasMaxLength(4);

            this.Property(t => t.Descricao)
                .HasMaxLength(155);

            this.Property(t => t.Tipo)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("SITUACOES_TRIBUTARIAS");
            this.Property(t => t.SituacaoTributariaId).HasColumnName("ID_SITB");
            this.Property(t => t.Codigo).HasColumnName("COD_SITB");
            this.Property(t => t.Descricao).HasColumnName("DESC_SITB");
            this.Property(t => t.Tipo).HasColumnName("TIPO_SITB");
        }
    }
}