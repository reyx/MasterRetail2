using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class LayoutBoletoMap : EntityTypeConfiguration<LayoutBoleto>
    {
        public LayoutBoletoMap()
        {
            // Primary Key
            this.HasKey(t => t.LayoutBoletoId);

            // Properties
            this.Property(t => t.TamanhoMilimetros)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TipoRetorno)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Campo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Texto)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("LAYOUT_BOLETOS");
            this.Property(t => t.LayoutBoletoId).HasColumnName("ID_LYBL");
            this.Property(t => t.BancoId).HasColumnName("COD_BCO");
            this.Property(t => t.ContaCorrenteId).HasColumnName("ID_CTCR");
            this.Property(t => t.Linha).HasColumnName("LINHA_LYBL");
            this.Property(t => t.Coluna).HasColumnName("COLUNA_LYBL");
            this.Property(t => t.TamanhoRetorno).HasColumnName("TAMCAR_LYBL");
            this.Property(t => t.Vertical).HasColumnName("VERTICAL_LYBL");
            this.Property(t => t.Horizontal).HasColumnName("HORIZONTAL_LYBL");
            this.Property(t => t.TamanhoMilimetros).HasColumnName("TAMMMM_LYBL");
            this.Property(t => t.TipoRetorno).HasColumnName("TIPOCAR_LYBL");
            this.Property(t => t.Campo).HasColumnName("CAMPO_LYBL");
            this.Property(t => t.SomaDias).HasColumnName("SOMADIAS_LYBL");
            this.Property(t => t.ExtInicial).HasColumnName("EXTINI_LYBL");
            this.Property(t => t.ExtFinal).HasColumnName("EXTTAM_LYBL");
            this.Property(t => t.Texto).HasColumnName("TEXTO_LYBL");

            // Relationships
            this.HasOptional(t => t.Banco)
                .WithMany(t => t.LayoutsBoleto)
                .HasForeignKey(d => d.BancoId);

            this.HasOptional(t => t.ContaCorrente)
                .WithMany(t => t.LayoutsBoletos)
                .HasForeignKey(d => d.ContaCorrenteId);

        }
    }
}