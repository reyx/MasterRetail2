using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class LocalEstoqueMap : EntityTypeConfiguration<LocalEstoque>
    {
        public LocalEstoqueMap()
        {
            // Primary Key
            this.HasKey(t => t.LocalEstoqueId);

            // Properties
            this.Property(t => t.Descricao)
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("LOCAIS_ESTOQUE");
            this.Property(t => t.LocalEstoqueId).HasColumnName("COD_LCES");
            this.Property(t => t.Descricao).HasColumnName("DESC_LCES");
        }
    }
}