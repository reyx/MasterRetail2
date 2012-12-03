using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class OcorrenciaPdvMap : EntityTypeConfiguration<OcorrenciaPdv>
    {
        public OcorrenciaPdvMap()
        {
            // Primary Key
            this.HasKey(t => t.OcorrenciaPdvId);

            // Properties
            // Table & Column Mappings
            this.ToTable("OCORRENCIAS_PDV");
            this.Property(t => t.OcorrenciaPdvId).HasColumnName("ID_OCPD");
            this.Property(t => t.MovimentoPdvId).HasColumnName("ID_MVPD");
            this.Property(t => t.TipoOcorrenciaId).HasColumnName("COD_TPOC");
            this.Property(t => t.RecebimentoPdvId).HasColumnName("ID_RCPD");
            this.Property(t => t.SupervisorId).HasColumnName("COD_OPER_SUP");
            this.Property(t => t.TipoSangriaId).HasColumnName("COD_TPSG");
            this.Property(t => t.TipoDespesaId).HasColumnName("ID_TPDS");
            this.Property(t => t.Valor).HasColumnName("VALOR_OCPD");
            this.Property(t => t.Data).HasColumnName("DATA_OCPD");
            this.Property(t => t.Observacao).HasColumnName("OBS_OCPD");

            // Relationships
            this.HasOptional(t => t.MovimentoPdv)
                .WithMany(t => t.Ocorrencias)
                .HasForeignKey(d => d.MovimentoPdvId);

            this.HasOptional(t => t.Operador)
                .WithMany(t => t.OcorrenciasPdv)
                .HasForeignKey(d => d.SupervisorId);

            this.HasOptional(t => t.RecebimentoPdv)
                .WithMany(t => t.OcorrenciasPdv)
                .HasForeignKey(d => d.RecebimentoPdvId);

            this.HasOptional(t => t.TipoDespesa)
                .WithMany(t => t.OcorrenciasPdv)
                .HasForeignKey(d => d.TipoDespesaId);

            this.HasOptional(t => t.TipoOcorrencia)
                .WithMany(t => t.OcorrenciasPdv)
                .HasForeignKey(d => d.TipoOcorrenciaId);

            this.HasOptional(t => t.TipoSangria)
                .WithMany(t => t.OcorrenciasPdv)
                .HasForeignKey(d => d.TipoSangriaId);

        }
    }
}