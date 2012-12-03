using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ItemTecladoRapidoMap : EntityTypeConfiguration<ItemTecladoRapido>
    {
        public ItemTecladoRapidoMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemTecladoRapidoId);

            // Properties
            this.Property(t => t.Tipo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("ITENS_TECLADO");
            this.Property(t => t.ItemTecladoRapidoId).HasColumnName("ID_ITTC");
            this.Property(t => t.TecladoRapidoId).HasColumnName("ID_TCRP");
            this.Property(t => t.Tecla).HasColumnName("TECLA_ITTC");
            this.Property(t => t.Tipo).HasColumnName("TIPO_ITTC");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
            this.Property(t => t.PromocaoId).HasColumnName("COD_PROM");
            this.Property(t => t.Quantidade).HasColumnName("QTDE_ITTC");
            this.Property(t => t.Descricao).HasColumnName("DESC_ITTC");

            // Relationships
            this.HasOptional(t => t.Produto)
                .WithMany(t => t.ItensTecladoRapido)
                .HasForeignKey(d => d.ProdutoId);

            this.HasOptional(t => t.Promocao)
                .WithMany(t => t.ItensTeclado)
                .HasForeignKey(d => d.PromocaoId);

            this.HasOptional(t => t.TecladoRapido)
                .WithMany(t => t.Teclas)
                .HasForeignKey(d => d.TecladoRapidoId);

        }
    }
}