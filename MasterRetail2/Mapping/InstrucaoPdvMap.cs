using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class InstrucaoPdvMap : EntityTypeConfiguration<InstrucaoPdv>
    {
        public InstrucaoPdvMap()
        {
            // Primary Key
            this.HasKey(t => t.InstrucaoPdvId);

            // Properties
            this.Property(t => t.Instrucao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ValorChave)
                .HasMaxLength(255);

            this.Property(t => t.Operacao)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("INSTRUCOES_PDV");
            this.Property(t => t.InstrucaoPdvId).HasColumnName("ID_INPD");
            this.Property(t => t.PdvId).HasColumnName("ID_PDV");
            this.Property(t => t.TabelaId).HasColumnName("ID_TAB");
            this.Property(t => t.InstrucaoPdvId).HasColumnName("INSTR_INPD");
            this.Property(t => t.ValorChave).HasColumnName("VALCHAVE_INPD");
            this.Property(t => t.Operacao).HasColumnName("OPERACAO_INPD");
            this.Property(t => t.Data).HasColumnName("DATA_INPD");

            // Relationships
            this.HasOptional(t => t.Pdv)
                .WithMany(t => t.Instrucoes)
                .HasForeignKey(d => d.PdvId);

        }
    }
}