using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class LinkMap : EntityTypeConfiguration<Link>
    {
        public LinkMap()
        {
            // Primary Key
            this.HasKey(t => t.LinkId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(255);

            this.Property(t => t.Url)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("LINKS");
            this.Property(t => t.LinkId).HasColumnName("ID_LINK");
            this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            this.Property(t => t.Descricao).HasColumnName("DESC_LINK");
            this.Property(t => t.Url).HasColumnName("URL_LINK");
            this.Property(t => t.Ordem).HasColumnName("ORDEM_LINK");
            this.Property(t => t.FuncaoProgramaId).HasColumnName("ID_FNPR");

            // Relationships
            this.HasOptional(t => t.Operador)
                .WithMany(t => t.Links)
                .HasForeignKey(d => d.OperadorId);

        }
    }
}