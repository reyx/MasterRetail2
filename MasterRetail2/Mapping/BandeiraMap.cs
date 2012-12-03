using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class BandeiraMap : EntityTypeConfiguration<Bandeira>
    {
        public BandeiraMap()
        {
            // Primary Key
            this.HasKey(t => t.BandeiraId);

            // Properties
            this.Property(t => t.AtivoString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Ativo);

            // Table & Column Mappings
            this.ToTable("BANDEIRAS");
            this.Property(t => t.BandeiraId).HasColumnName("COD_BAN");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");
            this.Property(t => t.Ativo).HasColumnName("ATIVO_BAN");
            this.Property(t => t.Icone).HasColumnName("ICONE_BAN");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.Bandeiras)
                .HasForeignKey(d => d.PessoaId);

        }
    }
}