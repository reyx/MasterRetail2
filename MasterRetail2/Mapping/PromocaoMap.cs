using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class PromocaoMap : EntityTypeConfiguration<Promocao>
    {
        public PromocaoMap()
        {
            // Primary Key
            this.HasKey(t => t.PromocaoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("PROMOCOES");
            this.Property(t => t.PromocaoId).HasColumnName("COD_PROM");
            this.Property(t => t.Descricao).HasColumnName("DESC_PROM");
            this.Property(t => t.Quantidade).HasColumnName("QTDE_PROM");
            this.Property(t => t.Valor).HasColumnName("VALOR_PROM");
            this.Property(t => t.Desconto).HasColumnName("DESCONTO_PROM");
        }
    }
}