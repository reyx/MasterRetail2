using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class VendedorMap : EntityTypeConfiguration<Vendedor>
    {
        public VendedorMap()
        {
            // Primary Key
            this.HasKey(t => t.VendedorId);

            // Properties
            this.Property(t => t.AtivoString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Ativo);

            // Table & Column Mappings
            this.ToTable("VENDEDORES");
            this.Property(t => t.VendedorId).HasColumnName("COD_VEND");
            this.Property(t => t.AtivoString).HasColumnName("ATIVO_VEND");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.Vendedores)
                .HasForeignKey(d => d.PessoaId);

        }
    }
}