using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TipoRecebimentoMap : EntityTypeConfiguration<TipoRecebimento>
    {
        public TipoRecebimentoMap()
        {
            // Primary Key
            this.HasKey(t => t.TipoRecebimentoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(20);

            this.Property(t => t.DescricaoReduzida)
                .HasMaxLength(7);

            this.Property(t => t.ImprimeCheque)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TipoTef)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TefId)
                .HasMaxLength(10);

            this.Property(t => t.GeraRecebimento)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ViasTef)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Detalhe)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Comportamento)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("TIPOS_RECEBIMENTO");
            this.Property(t => t.TipoRecebimentoId).HasColumnName("COD_TPRC");
            this.Property(t => t.Descricao).HasColumnName("DESC_TPRC");
            this.Property(t => t.DescricaoReduzida).HasColumnName("DESCRED_TPRC");
            this.Property(t => t.PontoSangria).HasColumnName("PTSANGRIA_TPRC");
            this.Property(t => t.ImprimeCheque).HasColumnName("IMPCHQ_TPRC");
            this.Property(t => t.TipoTef).HasColumnName("TIPOTEF_TPRC");
            this.Property(t => t.TefId).HasColumnName("IDTEF_TPRC");
            this.Property(t => t.GeraRecebimento).HasColumnName("GERAREC_TPRC");
            this.Property(t => t.Reducao).HasColumnName("REDUCAO_TPRC");
            this.Property(t => t.ViasTef).HasColumnName("VIASTEF_TPRC");
            this.Property(t => t.RedeTefId).HasColumnName("ID_RDTF");
            this.Property(t => t.Detalhe).HasColumnName("DETALHE_TPRC");
            this.Property(t => t.GrupoFechamento).HasColumnName("GRUPOFEC_TPRC");
            this.Property(t => t.Icone).HasColumnName("ICONE_TPRC");
            this.Property(t => t.Comportamento).HasColumnName("COMPORT_TPRC");

            // Relationships
            this.HasOptional(t => t.RedeTef)
                .WithMany(t => t.TiposRecebimento)
                .HasForeignKey(d => d.RedeTefId);

        }
    }
}