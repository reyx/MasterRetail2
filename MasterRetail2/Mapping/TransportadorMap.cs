using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TransportadorMap : EntityTypeConfiguration<Transportador>
    {
        public TransportadorMap()
        {
            // Primary Key
            this.HasKey(t => t.TransportadorId);

            // Properties
            this.Property(t => t.AtivoString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Ativo);

            // Table & Column Mappings
            this.ToTable("TRANSPORTADORES");
            this.Property(t => t.TransportadorId).HasColumnName("COD_TRAN");
            this.Property(t => t.AtivoString).HasColumnName("ATIVO_TRAN");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.Transportadores)
                .HasForeignKey(d => d.PessoaId);

        }
    }
}