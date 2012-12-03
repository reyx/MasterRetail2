using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class MovimentoPdvMap : EntityTypeConfiguration<MovimentoPdv>
    {
        public MovimentoPdvMap()
        {
            // Primary Key
            this.HasKey(t => t.MovimentoPdvId);

            // Properties
            this.Property(t => t.Situacao)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("MOVIMENTOS_PDV");
            this.Property(t => t.MovimentoPdvId).HasColumnName("ID_MVPD");
            this.Property(t => t.Data).HasColumnName("DATA_MVPD");
            this.Property(t => t.Turno).HasColumnName("TURNO_MVPD");
            this.Property(t => t.PdvId).HasColumnName("ID_PDV");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            this.Property(t => t.Situacao).HasColumnName("SITUACAO_MVPD");
            this.Property(t => t.HoraAbertura).HasColumnName("HORAINI_MVPD");
            this.Property(t => t.HoraFechamento).HasColumnName("HORAFEC_MVPD");
            this.Property(t => t.SupervisorAberturaId).HasColumnName("ID_OPER_SUPA");
            this.Property(t => t.SupervisorFechamentoId).HasColumnName("ID_OPER_SUPF");
            this.Property(t => t.Acrescimo).HasColumnName("ACRESCIMOS_MVPD");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.MovimentosPdv)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.Operador)
                .WithMany(t => t.MovimentosPdv)
                .HasForeignKey(d => d.OperadorId);

            this.HasOptional(t => t.SupervisorAbertura)
                .WithMany(t => t.MovimentosPdvAbertura)
                .HasForeignKey(d => d.SupervisorAberturaId);

            this.HasOptional(t => t.SupervisorFechamento)
                .WithMany(t => t.MovimentosPdvFechamento)
                .HasForeignKey(d => d.SupervisorFechamentoId);

            this.HasOptional(t => t.Pdv)
                .WithMany(t => t.Movimentos)
                .HasForeignKey(d => d.PdvId);

        }
    }
}