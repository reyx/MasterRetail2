using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class FoneMap : EntityTypeConfiguration<Fone>
    {
        public FoneMap()
        {
            // Primary Key
            this.HasKey(t => t.FoneId
                );

            // Properties
            this.Property(t => t.Numero)
                .HasMaxLength(20);

            this.Property(t => t.Observacao)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("FONES");
            this.Property(t => t.FoneId).HasColumnName("ID_FONE");
            this.Property(t => t.Numero).HasColumnName("NUMERO_FONE");
            this.Property(t => t.Observacao).HasColumnName("OBS_FONE");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.Fones)
                .HasForeignKey(d => d.PessoaId);

        }
    }
}