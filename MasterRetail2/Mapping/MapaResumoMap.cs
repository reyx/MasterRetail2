using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class MapaResumoMap : EntityTypeConfiguration<MapaResumo>
    {
        public MapaResumoMap()
        {
            // Primary Key
            this.HasKey(t => t.MapaResumoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("MAPA_RESUMO");
            this.Property(t => t.MapaResumoId).HasColumnName("ID_MPRS");
            this.Property(t => t.Data).HasColumnName("DATA_MPRS");
            this.Property(t => t.Numero).HasColumnName("NUMERO_MPRS");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.EcfId).HasColumnName("ID_ECF");
            this.Property(t => t.ContadorOperacoes).HasColumnName("CONTOP_MPRS");
            this.Property(t => t.GrandeTotalInicial).HasColumnName("GTINI_MPRS");
            this.Property(t => t.GrandeTotalFinal).HasColumnName("GTFIN_MPSR");
            this.Property(t => t.MovimentosDia).HasColumnName("MOVDIA_MPRS");
            this.Property(t => t.CancelamentosDia).HasColumnName("CANCDIA_MPRS");
            this.Property(t => t.DescontosDia).HasColumnName("DESCDIA_MPRS");
            this.Property(t => t.Liquido).HasColumnName("LIQUIDO_MPRS");
            this.Property(t => t.ContadorReducoes).HasColumnName("CONTRED_MPRS");
            this.Property(t => t.SubstituicoesTributarias).HasColumnName("SUBSTRIB_MPRS");
            this.Property(t => t.Isentos).HasColumnName("ISENTOS_MPRS");
            this.Property(t => t.NaoTributados).HasColumnName("NAOTRIB_MPRS");
            this.Property(t => t.Controle).HasColumnName("CONTROP_MPRS");
            this.Property(t => t.ControleOperacaoFinal).HasColumnName("CONTOPFIN_MPRS");

            // Relationships
            this.HasOptional(t => t.Ecf)
                .WithMany(t => t.MapasResumo)
                .HasForeignKey(d => d.EcfId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.MapasResumo)
                .HasForeignKey(d => d.LojaId);

        }
    }
}