using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class CnaeMap : EntityTypeConfiguration<Cnae>
    {
        public CnaeMap()
        {
            // Primary Key
            this.HasKey(t => t.CnaeId);

            // Properties
            this.Property(t => t.Secao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Divisao)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Grupo)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.Classe)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.Subclasse)
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.Descricao)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("CNAES");
            this.Property(t => t.CnaeId).HasColumnName("ID_CNAE");
            this.Property(t => t.Secao).HasColumnName("SECAO_CNAE");
            this.Property(t => t.Divisao).HasColumnName("DIVISAO_CNAE");
            this.Property(t => t.Grupo).HasColumnName("GRUPO_CNAE");
            this.Property(t => t.Classe).HasColumnName("CLASSE_CNAE");
            this.Property(t => t.Subclasse).HasColumnName("SUBCLASSE_CNAE");
            this.Property(t => t.Descricao).HasColumnName("DESC_CNAE");
        }
    }
}