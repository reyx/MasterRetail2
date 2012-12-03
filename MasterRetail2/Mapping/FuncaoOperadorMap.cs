using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class FuncaoOperadorMap : EntityTypeConfiguration<FuncaoOperador>
    {
        public FuncaoOperadorMap()
        {
            // Primary Key
            this.HasKey(t => t.FuncaoOperadorId);

            // Properties
            this.Property(t => t.PermitidoString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Permitido);


            // Table & Column Mappings
            this.ToTable("FUNCOES_OPERADOR");
            this.Property(t => t.FuncaoOperadorId).HasColumnName("ID_FNOP");
            this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            this.Property(t => t.FuncaoProgramaId).HasColumnName("ID_FNPR");
            this.Property(t => t.PermitidoString).HasColumnName("PERMITIDO_FNOP");

            // Relationships
            this.HasOptional(t => t.Operador)
                .WithMany(t => t.FuncoesOperador)
                .HasForeignKey(d => d.OperadorId);

        }
    }
}