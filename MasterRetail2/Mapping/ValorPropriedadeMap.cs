using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ValorPropriedadeMap : EntityTypeConfiguration<ValorPropriedade>
    {
        public ValorPropriedadeMap()
        {
            // Primary Key
            this.HasKey(t => t.ValorPropriedadeId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("VALORES_PROPRIEDADE");
            this.Property(t => t.ValorPropriedadeId).HasColumnName("ID_VLPR");
            this.Property(t => t.PropriedadeId).HasColumnName("COD_PROP");
            this.Property(t => t.Descricao).HasColumnName("DESC_VLPR");

            // Relationships
            this.HasOptional(t => t.Propriedade)
                .WithMany(t => t.Valores)
                .HasForeignKey(d => d.PropriedadeId);

        }
    }
}