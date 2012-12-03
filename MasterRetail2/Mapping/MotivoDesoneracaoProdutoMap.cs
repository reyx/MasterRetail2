using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class MotivoDesoneracaoProdutoMap : EntityTypeConfiguration<MotivoDesoneracaoProduto>
    {
        public MotivoDesoneracaoProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.MotivoDesoneracaoProdutoId);

            // Properties
            this.Property(t => t.Codigo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MOTIVOS_DESONERACAO_PROD");
            this.Property(t => t.MotivoDesoneracaoProdutoId).HasColumnName("ID_MDSP");
            this.Property(t => t.Codigo).HasColumnName("COD_MDSP");
            this.Property(t => t.Descricao).HasColumnName("DESC_MDSP");
        }
    }
}