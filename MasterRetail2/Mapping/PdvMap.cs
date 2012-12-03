using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class PdvMap : EntityTypeConfiguration<Pdv>
    {
        public PdvMap()
        {
            // Primary Key
            this.HasKey(t => t.PdvId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PDV");
            this.Property(t => t.PdvId).HasColumnName("ID_PDV");
            this.Property(t => t.Numero).HasColumnName("NUMERO_PDV");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.Descricao).HasColumnName("DESCRICAO_PDV");
            this.Property(t => t.EcfId).HasColumnName("ID_ECF");
            this.Property(t => t.ListaId).HasColumnName("COD_LISTA");
            this.Property(t => t.GrupoPdvId).HasColumnName("COD_GRPD");

            // Relationships
            this.HasOptional(t => t.Ecf)
                .WithMany(t => t.Pdvs)
                .HasForeignKey(d => d.EcfId);

            this.HasOptional(t => t.Grupo)
                .WithMany(t => t.Pdvs)
                .HasForeignKey(d => d.GrupoPdvId);

            this.HasOptional(t => t.Lista)
                .WithMany(t => t.Pdvs)
                .HasForeignKey(d => d.ListaId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.Pdvs)
                .HasForeignKey(d => d.LojaId);

        }
    }
}