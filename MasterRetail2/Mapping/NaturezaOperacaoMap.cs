using Rcky.MasterRetail2.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class NaturezaOperacaoMap : EntityTypeConfiguration<NaturezaOperacao>
    {
        public NaturezaOperacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.NaturezaOperacaoId);

            // Properties
            this.Property(t => t.NaturezaOperacaoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Descricao)
                .HasMaxLength(200);

            this.Property(t => t.CalculoIcms)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CalculoIpi)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CalculoSt)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Faturado)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Operacao)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("NATUREZAS_OPERACAO");
            this.Property(t => t.NaturezaOperacaoId).HasColumnName("CFOP_NTOP");
            this.Property(t => t.Descricao).HasColumnName("DESC_NTOP");
            this.Property(t => t.CalculoIcms).HasColumnName("CALCICM_NTOP");
            this.Property(t => t.CalculoIpi).HasColumnName("CALCIPI_NTOP");
            this.Property(t => t.CalculoSt).HasColumnName("CALCSUB_NTOP");
            this.Property(t => t.Faturado).HasColumnName("FATUR_NTOP");
            this.Property(t => t.Observacao).HasColumnName("OBS_NTOP");
            this.Property(t => t.Mensagem).HasColumnName("MENSAGEM_NTOP");
            this.Property(t => t.Operacao).HasColumnName("OPERACAO_NTOP");
            this.Property(t => t.CalculoPis).HasColumnName("CALCPIS_NTOP");
            this.Property(t => t.CalculoCofins).HasColumnName("CALCCOFINS_NTOP");
        }
    }
}