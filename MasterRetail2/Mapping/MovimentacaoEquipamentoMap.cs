using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class MovimentacaoEquipamentoMap : EntityTypeConfiguration<MovimentacaoEquipamento>
    {
        public MovimentacaoEquipamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.MovimentacaoEquipamentoId);

            // Properties
            this.Property(t => t.Documento)
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("MOVIMENTACOES_EQUIPAMENTO");
            this.Property(t => t.MovimentacaoEquipamentoId).HasColumnName("ID_MVEQ");
            this.Property(t => t.Data).HasColumnName("DATA_MVEQ");
            this.Property(t => t.EquipamentoId).HasColumnName("ID_EQUIP");
            this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            this.Property(t => t.ClienteId).HasColumnName("COD_CLI");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.HistoricoEquipamentoId).HasColumnName("ID_HSEQ");
            this.Property(t => t.Documento).HasColumnName("DOCTO_MVEQ");
            this.Property(t => t.Observacao).HasColumnName("OBS_MVEQ");

            // Relationships
            this.HasOptional(t => t.Cliente)
                .WithMany(t => t.MovimentacoesEquipamento)
                .HasForeignKey(d => d.ClienteId);

            this.HasOptional(t => t.Equipamento)
                .WithMany(t => t.MovimentacoesEquipamento)
                .HasForeignKey(d => d.EquipamentoId);

            this.HasOptional(t => t.HistoricoEquipamento)
                .WithMany(t => t.MovimentacoesEquipamento)
                .HasForeignKey(d => d.HistoricoEquipamentoId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.MovimentacoesEquipamento)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.Operador)
                .WithMany(t => t.MovimentacoesEquipamento)
                .HasForeignKey(d => d.OperadorId);

        }
    }
}