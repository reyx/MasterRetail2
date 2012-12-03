using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class SituacaoMap : EntityTypeConfiguration<Situacao>
    {
        public SituacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.SituacaoId);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(30);

            this.Property(t => t.Cor)
                .HasMaxLength(6);

            this.Property(t => t.Acao)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("SITUACOES");
            this.Property(t => t.Cor).HasColumnName("COD_SITU");
            this.Property(t => t.Nome).HasColumnName("NOME_SITU");
            this.Property(t => t.Cor).HasColumnName("COR_SITU");
            this.Property(t => t.Acao).HasColumnName("ACAO_SITU");
        }
    }
}