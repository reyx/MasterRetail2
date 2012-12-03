using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TributacaoMap : EntityTypeConfiguration<Tributacao>
    {
        public TributacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.TributacaoId);

            // Properties
            this.Property(t => t.Codigo)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.Tipo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Descricao)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("TRIBUTACOES");
            this.Property(t => t.TributacaoId).HasColumnName("ID_TRIB");
            this.Property(t => t.Codigo).HasColumnName("COD_TRIB");
            this.Property(t => t.Tipo).HasColumnName("TIPO_TRIB");
            this.Property(t => t.Descricao).HasColumnName("DESC_TRIB");
            this.Property(t => t.Observacao).HasColumnName("OBS_TRIB");
        }
    }
}