using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ContaCorrenteMap : EntityTypeConfiguration<ContaCorrente>
    {
        public ContaCorrenteMap()
        {
            // Primary Key
            this.HasKey(t => t.ContaCorrenteId);

            // Properties
            this.Property(t => t.Conta)
                .HasMaxLength(20);

            this.Property(t => t.Nome)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CONTAS_CORRENTES");
            this.Property(t => t.ContaCorrenteId).HasColumnName("ID_CTCR");
            this.Property(t => t.AgenciaId).HasColumnName("ID_AGEN");
            this.Property(t => t.Conta).HasColumnName("CONTA_CTCR");
            this.Property(t => t.Nome).HasColumnName("NOME_CTCR");
            this.Property(t => t.SaldoAtual).HasColumnName("SALDOATU_CTCR");
            this.Property(t => t.Cnab).HasColumnName("CNAB_CTCR");

            // Relationships
            this.HasOptional(t => t.Agencia)
                .WithMany(t => t.ContasCorrentes)
                .HasForeignKey(d => d.AgenciaId);

        }
    }
}