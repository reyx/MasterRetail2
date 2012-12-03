using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ItemManualMap : EntityTypeConfiguration<ItemManual>
    {
        public ItemManualMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemManualId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("ITENS_MANUAL");
            this.Property(t => t.ItemManualId).HasColumnName("ID_ITMN");
            this.Property(t => t.ManualId).HasColumnName("ID_MANL");
            this.Property(t => t.FuncaoProgramaId).HasColumnName("ID_FNPR");
            this.Property(t => t.Descricao).HasColumnName("DESC_ITMN");
            this.Property(t => t.Conteudo).HasColumnName("CONTEUDO_ITMN");

            // Relationships
            this.HasOptional(t => t.FuncaoPrograma)
                .WithMany(t => t.ItensManual)
                .HasForeignKey(d => d.FuncaoProgramaId);

            this.HasOptional(t => t.Manual)
                .WithMany(t => t.Itens)
                .HasForeignKey(d => d.ManualId);

        }
    }
}