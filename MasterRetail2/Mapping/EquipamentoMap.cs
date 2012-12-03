using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class EquipamentoMap : EntityTypeConfiguration<Equipamento>
    {
        public EquipamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.EquipamentoId);

            // Properties
            this.Property(t => t.Serie)
                .HasMaxLength(30);

            this.Property(t => t.SerieObrigatoria)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            this.Property(t => t.CodigoBarras)
                .IsFixedLength()
                .HasMaxLength(13);

            // Table & Column Mappings
            this.ToTable("EQUIPAMENTOS");
            this.Property(t => t.EquipamentoId).HasColumnName("ID_EQUIP");
            this.Property(t => t.TipoEquipamentoId).HasColumnName("ID_TPEQ");
            this.Property(t => t.Serie).HasColumnName("SERIE_EQUIP");
            this.Property(t => t.SerieObrigatoria).HasColumnName("SERIEOBRIG_EQUIP");
            this.Property(t => t.DiasDevolucaoPadrao).HasColumnName("DIASDEVOPAD_EQUIP");
            this.Property(t => t.Descricao).HasColumnName("DESC_EQUIP");
            this.Property(t => t.CodigoBarras).HasColumnName("CODBAR_EQUIP");
            this.Property(t => t.Valor).HasColumnName("VALOR_EQUIP");
            this.Property(t => t.ClienteId).HasColumnName("COD_CLI");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");

            // Relationships
            this.HasOptional(t => t.Cliente)
                .WithMany(t => t.Equipamentos)
                .HasForeignKey(d => d.ClienteId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.Equipamentos)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.TipoEquipamento)
                .WithMany(t => t.Equipamentos)
                .HasForeignKey(d => d.TipoEquipamentoId);

        }
    }
}