using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ListaLojaMap : EntityTypeConfiguration<ListaLoja>
    {
        public ListaLojaMap()
        {
            // Primary Key
            this.HasKey(t => t.ListaLojaId);

            // Properties
            this.Property(t => t.Preco)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("LISTAS_LOJA");
            this.Property(t => t.ListaLojaId).HasColumnName("ID_LSLJ");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.ListaId).HasColumnName("COD_LISTA");
            this.Property(t => t.Preco).HasColumnName("CPOPRECO_LILJ");

            // Relationships
            this.HasOptional(t => t.Lista)
                .WithMany(t => t.ListasLoja)
                .HasForeignKey(d => d.ListaId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.ListasLoja)
                .HasForeignKey(d => d.LojaId);

        }
    }
}